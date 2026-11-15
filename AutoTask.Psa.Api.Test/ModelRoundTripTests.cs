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

	private static readonly Dictionary<Type, object> Scalars = new()
	{
		[typeof(string)] = "sample",
		[typeof(bool)] = true,
		[typeof(DateTime)] = new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc),
		[typeof(byte[])] = new byte[] { 1, 2, 3 }
	};

	private static object? ScalarSample(Type type)
		=> Scalars.TryGetValue(type, out var known) ? known
		: type.IsEnum ? Enum.GetValues(type).GetValue(0)
		: type.IsPrimitive || type == typeof(decimal) ? Convert.ChangeType(7, type, System.Globalization.CultureInfo.InvariantCulture)
		: null;

	private static bool IsList(Type type)
		=> type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);

	private static object ListSample(Type listType, int depth)
	{
		var list = Activator.CreateInstance(listType)!;
		var item = depth < MaxDepth ? Sample(listType.GetGenericArguments()[0], depth + 1) : null;
		if (item is not null)
		{
			listType.GetMethod(nameof(List<int>.Add))!.Invoke(list, [item]);
		}

		return list;
	}

	private static object? Sample(Type type, int depth)
	{
		var underlying = Nullable.GetUnderlyingType(type) ?? type;

		if (ScalarSample(underlying) is { } scalar)
		{
			return scalar;
		}

		if (IsList(underlying))
		{
			return ListSample(underlying, depth);
		}

		return underlying.IsClass && !underlying.IsAbstract && underlying.GetConstructor(Type.EmptyTypes) is not null && depth < MaxDepth
			? Populate(underlying, depth + 1)
			: null;
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
