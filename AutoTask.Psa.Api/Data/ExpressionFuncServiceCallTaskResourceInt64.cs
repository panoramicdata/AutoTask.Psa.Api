using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ExpressionFuncServiceCallTaskResourceInt64
	/// </summary>
	[DataContract]
	public partial class ExpressionFuncServiceCallTaskResourceInt64
	{
		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum NodeTypeEnum
		{

			/// <summary>
			/// Enum NUMBER_0 for 0
			/// </summary>
			[EnumMember(Value = "0")]
			NUMBER_0 = 0,

			/// <summary>
			/// Enum NUMBER_1 for 1
			/// </summary>
			[EnumMember(Value = "1")]
			NUMBER_1 = 1,

			/// <summary>
			/// Enum NUMBER_2 for 2
			/// </summary>
			[EnumMember(Value = "2")]
			NUMBER_2 = 2,

			/// <summary>
			/// Enum NUMBER_3 for 3
			/// </summary>
			[EnumMember(Value = "3")]
			NUMBER_3 = 3,

			/// <summary>
			/// Enum NUMBER_4 for 4
			/// </summary>
			[EnumMember(Value = "4")]
			NUMBER_4 = 4,

			/// <summary>
			/// Enum NUMBER_5 for 5
			/// </summary>
			[EnumMember(Value = "5")]
			NUMBER_5 = 5,

			/// <summary>
			/// Enum NUMBER_6 for 6
			/// </summary>
			[EnumMember(Value = "6")]
			NUMBER_6 = 6,

			/// <summary>
			/// Enum NUMBER_7 for 7
			/// </summary>
			[EnumMember(Value = "7")]
			NUMBER_7 = 7,

			/// <summary>
			/// Enum NUMBER_8 for 8
			/// </summary>
			[EnumMember(Value = "8")]
			NUMBER_8 = 8,

			/// <summary>
			/// Enum NUMBER_9 for 9
			/// </summary>
			[EnumMember(Value = "9")]
			NUMBER_9 = 9,

			/// <summary>
			/// Enum NUMBER_10 for 10
			/// </summary>
			[EnumMember(Value = "10")]
			NUMBER_10 = 10,

			/// <summary>
			/// Enum NUMBER_11 for 11
			/// </summary>
			[EnumMember(Value = "11")]
			NUMBER_11 = 11,

			/// <summary>
			/// Enum NUMBER_12 for 12
			/// </summary>
			[EnumMember(Value = "12")]
			NUMBER_12 = 12,

			/// <summary>
			/// Enum NUMBER_13 for 13
			/// </summary>
			[EnumMember(Value = "13")]
			NUMBER_13 = 13,

			/// <summary>
			/// Enum NUMBER_14 for 14
			/// </summary>
			[EnumMember(Value = "14")]
			NUMBER_14 = 14,

			/// <summary>
			/// Enum NUMBER_15 for 15
			/// </summary>
			[EnumMember(Value = "15")]
			NUMBER_15 = 15,

			/// <summary>
			/// Enum NUMBER_16 for 16
			/// </summary>
			[EnumMember(Value = "16")]
			NUMBER_16 = 16,

			/// <summary>
			/// Enum NUMBER_17 for 17
			/// </summary>
			[EnumMember(Value = "17")]
			NUMBER_17 = 17,

			/// <summary>
			/// Enum NUMBER_18 for 18
			/// </summary>
			[EnumMember(Value = "18")]
			NUMBER_18 = 18,

			/// <summary>
			/// Enum NUMBER_19 for 19
			/// </summary>
			[EnumMember(Value = "19")]
			NUMBER_19 = 19,

			/// <summary>
			/// Enum NUMBER_20 for 20
			/// </summary>
			[EnumMember(Value = "20")]
			NUMBER_20 = 20,

			/// <summary>
			/// Enum NUMBER_21 for 21
			/// </summary>
			[EnumMember(Value = "21")]
			NUMBER_21 = 21,

			/// <summary>
			/// Enum NUMBER_22 for 22
			/// </summary>
			[EnumMember(Value = "22")]
			NUMBER_22 = 22,

			/// <summary>
			/// Enum NUMBER_23 for 23
			/// </summary>
			[EnumMember(Value = "23")]
			NUMBER_23 = 23,

			/// <summary>
			/// Enum NUMBER_24 for 24
			/// </summary>
			[EnumMember(Value = "24")]
			NUMBER_24 = 24,

			/// <summary>
			/// Enum NUMBER_25 for 25
			/// </summary>
			[EnumMember(Value = "25")]
			NUMBER_25 = 25,

			/// <summary>
			/// Enum NUMBER_26 for 26
			/// </summary>
			[EnumMember(Value = "26")]
			NUMBER_26 = 26,

			/// <summary>
			/// Enum NUMBER_27 for 27
			/// </summary>
			[EnumMember(Value = "27")]
			NUMBER_27 = 27,

			/// <summary>
			/// Enum NUMBER_28 for 28
			/// </summary>
			[EnumMember(Value = "28")]
			NUMBER_28 = 28,

			/// <summary>
			/// Enum NUMBER_29 for 29
			/// </summary>
			[EnumMember(Value = "29")]
			NUMBER_29 = 29,

			/// <summary>
			/// Enum NUMBER_30 for 30
			/// </summary>
			[EnumMember(Value = "30")]
			NUMBER_30 = 30,

			/// <summary>
			/// Enum NUMBER_31 for 31
			/// </summary>
			[EnumMember(Value = "31")]
			NUMBER_31 = 31,

			/// <summary>
			/// Enum NUMBER_32 for 32
			/// </summary>
			[EnumMember(Value = "32")]
			NUMBER_32 = 32,

			/// <summary>
			/// Enum NUMBER_33 for 33
			/// </summary>
			[EnumMember(Value = "33")]
			NUMBER_33 = 33,

			/// <summary>
			/// Enum NUMBER_34 for 34
			/// </summary>
			[EnumMember(Value = "34")]
			NUMBER_34 = 34,

			/// <summary>
			/// Enum NUMBER_35 for 35
			/// </summary>
			[EnumMember(Value = "35")]
			NUMBER_35 = 35,

			/// <summary>
			/// Enum NUMBER_36 for 36
			/// </summary>
			[EnumMember(Value = "36")]
			NUMBER_36 = 36,

			/// <summary>
			/// Enum NUMBER_37 for 37
			/// </summary>
			[EnumMember(Value = "37")]
			NUMBER_37 = 37,

			/// <summary>
			/// Enum NUMBER_38 for 38
			/// </summary>
			[EnumMember(Value = "38")]
			NUMBER_38 = 38,

			/// <summary>
			/// Enum NUMBER_39 for 39
			/// </summary>
			[EnumMember(Value = "39")]
			NUMBER_39 = 39,

			/// <summary>
			/// Enum NUMBER_40 for 40
			/// </summary>
			[EnumMember(Value = "40")]
			NUMBER_40 = 40,

			/// <summary>
			/// Enum NUMBER_41 for 41
			/// </summary>
			[EnumMember(Value = "41")]
			NUMBER_41 = 41,

			/// <summary>
			/// Enum NUMBER_42 for 42
			/// </summary>
			[EnumMember(Value = "42")]
			NUMBER_42 = 42,

			/// <summary>
			/// Enum NUMBER_43 for 43
			/// </summary>
			[EnumMember(Value = "43")]
			NUMBER_43 = 43,

			/// <summary>
			/// Enum NUMBER_44 for 44
			/// </summary>
			[EnumMember(Value = "44")]
			NUMBER_44 = 44,

			/// <summary>
			/// Enum NUMBER_45 for 45
			/// </summary>
			[EnumMember(Value = "45")]
			NUMBER_45 = 45,

			/// <summary>
			/// Enum NUMBER_46 for 46
			/// </summary>
			[EnumMember(Value = "46")]
			NUMBER_46 = 46,

			/// <summary>
			/// Enum NUMBER_47 for 47
			/// </summary>
			[EnumMember(Value = "47")]
			NUMBER_47 = 47,

			/// <summary>
			/// Enum NUMBER_48 for 48
			/// </summary>
			[EnumMember(Value = "48")]
			NUMBER_48 = 48,

			/// <summary>
			/// Enum NUMBER_49 for 49
			/// </summary>
			[EnumMember(Value = "49")]
			NUMBER_49 = 49,

			/// <summary>
			/// Enum NUMBER_50 for 50
			/// </summary>
			[EnumMember(Value = "50")]
			NUMBER_50 = 50,

			/// <summary>
			/// Enum NUMBER_51 for 51
			/// </summary>
			[EnumMember(Value = "51")]
			NUMBER_51 = 51,

			/// <summary>
			/// Enum NUMBER_52 for 52
			/// </summary>
			[EnumMember(Value = "52")]
			NUMBER_52 = 52,

			/// <summary>
			/// Enum NUMBER_53 for 53
			/// </summary>
			[EnumMember(Value = "53")]
			NUMBER_53 = 53,

			/// <summary>
			/// Enum NUMBER_54 for 54
			/// </summary>
			[EnumMember(Value = "54")]
			NUMBER_54 = 54,

			/// <summary>
			/// Enum NUMBER_55 for 55
			/// </summary>
			[EnumMember(Value = "55")]
			NUMBER_55 = 55,

			/// <summary>
			/// Enum NUMBER_56 for 56
			/// </summary>
			[EnumMember(Value = "56")]
			NUMBER_56 = 56,

			/// <summary>
			/// Enum NUMBER_57 for 57
			/// </summary>
			[EnumMember(Value = "57")]
			NUMBER_57 = 57,

			/// <summary>
			/// Enum NUMBER_58 for 58
			/// </summary>
			[EnumMember(Value = "58")]
			NUMBER_58 = 58,

			/// <summary>
			/// Enum NUMBER_59 for 59
			/// </summary>
			[EnumMember(Value = "59")]
			NUMBER_59 = 59,

			/// <summary>
			/// Enum NUMBER_60 for 60
			/// </summary>
			[EnumMember(Value = "60")]
			NUMBER_60 = 60,

			/// <summary>
			/// Enum NUMBER_61 for 61
			/// </summary>
			[EnumMember(Value = "61")]
			NUMBER_61 = 61,

			/// <summary>
			/// Enum NUMBER_62 for 62
			/// </summary>
			[EnumMember(Value = "62")]
			NUMBER_62 = 62,

			/// <summary>
			/// Enum NUMBER_63 for 63
			/// </summary>
			[EnumMember(Value = "63")]
			NUMBER_63 = 63,

			/// <summary>
			/// Enum NUMBER_64 for 64
			/// </summary>
			[EnumMember(Value = "64")]
			NUMBER_64 = 64,

			/// <summary>
			/// Enum NUMBER_65 for 65
			/// </summary>
			[EnumMember(Value = "65")]
			NUMBER_65 = 65,

			/// <summary>
			/// Enum NUMBER_66 for 66
			/// </summary>
			[EnumMember(Value = "66")]
			NUMBER_66 = 66,

			/// <summary>
			/// Enum NUMBER_67 for 67
			/// </summary>
			[EnumMember(Value = "67")]
			NUMBER_67 = 67,

			/// <summary>
			/// Enum NUMBER_68 for 68
			/// </summary>
			[EnumMember(Value = "68")]
			NUMBER_68 = 68,

			/// <summary>
			/// Enum NUMBER_69 for 69
			/// </summary>
			[EnumMember(Value = "69")]
			NUMBER_69 = 69,

			/// <summary>
			/// Enum NUMBER_70 for 70
			/// </summary>
			[EnumMember(Value = "70")]
			NUMBER_70 = 70,

			/// <summary>
			/// Enum NUMBER_71 for 71
			/// </summary>
			[EnumMember(Value = "71")]
			NUMBER_71 = 71,

			/// <summary>
			/// Enum NUMBER_72 for 72
			/// </summary>
			[EnumMember(Value = "72")]
			NUMBER_72 = 72,

			/// <summary>
			/// Enum NUMBER_73 for 73
			/// </summary>
			[EnumMember(Value = "73")]
			NUMBER_73 = 73,

			/// <summary>
			/// Enum NUMBER_74 for 74
			/// </summary>
			[EnumMember(Value = "74")]
			NUMBER_74 = 74,

			/// <summary>
			/// Enum NUMBER_75 for 75
			/// </summary>
			[EnumMember(Value = "75")]
			NUMBER_75 = 75,

			/// <summary>
			/// Enum NUMBER_76 for 76
			/// </summary>
			[EnumMember(Value = "76")]
			NUMBER_76 = 76,

			/// <summary>
			/// Enum NUMBER_77 for 77
			/// </summary>
			[EnumMember(Value = "77")]
			NUMBER_77 = 77,

			/// <summary>
			/// Enum NUMBER_78 for 78
			/// </summary>
			[EnumMember(Value = "78")]
			NUMBER_78 = 78,

			/// <summary>
			/// Enum NUMBER_79 for 79
			/// </summary>
			[EnumMember(Value = "79")]
			NUMBER_79 = 79,

			/// <summary>
			/// Enum NUMBER_80 for 80
			/// </summary>
			[EnumMember(Value = "80")]
			NUMBER_80 = 80,

			/// <summary>
			/// Enum NUMBER_81 for 81
			/// </summary>
			[EnumMember(Value = "81")]
			NUMBER_81 = 81,

			/// <summary>
			/// Enum NUMBER_82 for 82
			/// </summary>
			[EnumMember(Value = "82")]
			NUMBER_82 = 82,

			/// <summary>
			/// Enum NUMBER_83 for 83
			/// </summary>
			[EnumMember(Value = "83")]
			NUMBER_83 = 83,

			/// <summary>
			/// Enum NUMBER_84 for 84
			/// </summary>
			[EnumMember(Value = "84")]
			NUMBER_84 = 84
		}

		/// <summary>
		/// Gets or Sets NodeType
		/// </summary>
		[DataMember(Name = "NodeType", EmitDefaultValue = false)]
		public NodeTypeEnum? NodeType { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ExpressionFuncServiceCallTaskResourceInt64" /> class.
		/// </summary>
		[JsonConstructor]
		public ExpressionFuncServiceCallTaskResourceInt64()
		{
		}

		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; private set; }

		/// <summary>
		/// Gets or Sets Parameters
		/// </summary>
		[DataMember(Name = "Parameters", EmitDefaultValue = false)]
		public List<ParameterExpression> Parameters { get; private set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; private set; }

		/// <summary>
		/// Gets or Sets Body
		/// </summary>
		[DataMember(Name = "Body", EmitDefaultValue = false)]
		public Expression Body { get; private set; }

		/// <summary>
		/// Gets or Sets ReturnType
		/// </summary>
		[DataMember(Name = "ReturnType", EmitDefaultValue = false)]
		public string ReturnType { get; private set; }

		/// <summary>
		/// Gets or Sets TailCall
		/// </summary>
		[DataMember(Name = "TailCall", EmitDefaultValue = false)]
		public bool? TailCall { get; private set; }

		/// <summary>
		/// Gets or Sets CanReduce
		/// </summary>
		[DataMember(Name = "CanReduce", EmitDefaultValue = false)]
		public bool? CanReduce { get; private set; }
	}
}
