using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoTask.Psa.Api.Test;

/// <summary>Reflection-driven checks over every entity model in the Data namespace.</summary>
public class ModelRoundTripTests
{
	private const int MaxDepth = 2;

	private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web);

	private static readonly Assembly ApiAssembly = typeof(AutoTaskClient).Assembly;

	public static TheoryData<string> ModelNames()
	{
		var data = new TheoryData<string>();
		foreach (var type in ModelTypes())
		{
			data.Add(type.Name);
		}

		return data;
	}

	private static IEnumerable<Type> ModelTypes()
		=> ApiAssembly.GetTypes()
			.Where(t => t.IsClass && !t.IsAbstract && t.IsPublic && t.Namespace == typeof(TicketModel).Namespace)
			.Where(t => !t.IsGenericTypeDefinition && !typeof(JsonConverter).IsAssignableFrom(t) && t.GetConstructor(Type.EmptyTypes) is not null)
			.OrderBy(t => t.Name, StringComparer.Ordinal);

	private static Type ModelByName(string name)
		=> ModelTypes().Single(t => t.Name == name);

	private static IEnumerable<PropertyInfo> SettableProperties(Type type)
		=> type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Where(p => p.GetIndexParameters().Length == 0 && p.GetGetMethod() is not null && p.GetSetMethod() is not null);

	private static object? Sample(Type type, int depth)
	{
		var underlying = Nullable.GetUnderlyingType(type) ?? type;

		if (underlying == typeof(string))
		{
			return "sample";
		}

		if (underlying == typeof(bool))
		{
			return true;
		}

		if (underlying == typeof(DateTime))
		{
			return new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc);
		}

		if (underlying.IsEnum)
		{
			return Enum.GetValues(underlying).GetValue(0);
		}

		if (underlying.IsPrimitive || underlying == typeof(decimal))
		{
			return Convert.ChangeType(7, underlying, System.Globalization.CultureInfo.InvariantCulture);
		}

		if (underlying == typeof(byte[]))
		{
			return new byte[] { 1, 2, 3 };
		}

		if (underlying.IsGenericType && underlying.GetGenericTypeDefinition() == typeof(List<>))
		{
			var list = (System.Collections.IList)Activator.CreateInstance(underlying)!;
			if (depth < MaxDepth)
			{
				var item = Sample(underlying.GetGenericArguments()[0], depth + 1);
				if (item is not null)
				{
					list.Add(item);
				}
			}

			return list;
		}

		if (underlying.IsClass && !underlying.IsAbstract && underlying.GetConstructor(Type.EmptyTypes) is not null && depth < MaxDepth)
		{
			return Populate(underlying, depth + 1);
		}

		return null;
	}

	private static object Populate(Type type, int depth)
	{
		var instance = Activator.CreateInstance(type)!;
		foreach (var property in SettableProperties(type))
		{
			var value = Sample(property.PropertyType, depth);
			if (value is not null)
			{
				property.SetValue(instance, value);
			}
		}

		return instance;
	}

	[Fact]
	public void ModelTypes_AreDiscovered()
		=> ModelTypes().Count().Should().BeGreaterThan(150);

	[Theory]
	[MemberData(nameof(ModelNames))]
	public void Model_PropertiesReturnWhatWasSet(string name)
	{
		var type = ModelByName(name);
		var instance = Activator.CreateInstance(type)!;

		foreach (var property in SettableProperties(type))
		{
			var value = Sample(property.PropertyType, MaxDepth);
			if (value is null)
			{
				continue;
			}

			property.SetValue(instance, value);

			var actual = property.GetValue(instance);
			if (value is ValueType or string)
			{
				actual.Should().Be(value, because: $"{name}.{property.Name}");
			}
			else
			{
				actual.Should().BeSameAs(value, because: $"{name}.{property.Name}");
			}
		}
	}

	[Theory]
	[MemberData(nameof(ModelNames))]
	public void Model_SurvivesAJsonRoundTrip(string name)
	{
		var type = ModelByName(name);
		var original = Populate(type, 0);

		var json = JsonSerializer.Serialize(original, type, Options);
		var round = JsonSerializer.Deserialize(json, type, Options);

		round.Should().NotBeNull();
		JsonSerializer.Serialize(round, type, Options).Should().Be(json, because: name);
	}

	[Fact]
	public void TaxCategoryModel_CreateCopiesEveryValue()
	{
		var fields = new List<UserDefinedField> { new() };

		var model = TaxCategoryModel.Create(5, "desc", true, "name", fields);

		model.Id.Should().Be(5);
		model.Description.Should().Be("desc");
		model.IsActive.Should().BeTrue();
		model.Name.Should().Be("name");
		model.UserDefinedFields.Should().HaveCount(1);
	}

	[Fact]
	public void TaxCategoryModel_CreateWithoutFieldsLeavesThemEmpty()
		=> TaxCategoryModel.Create(1, "d", false, "n").UserDefinedFields.Should().BeEmpty();
}
