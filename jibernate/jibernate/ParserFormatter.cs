using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace jibernate
{
	public class PlaceholderName
	{
		public string SourceText { get; set; }
		public string IndexString { get; set; }
		public Int32? Index
		{
			get
			{
				Int32 index;
				if (Int32.TryParse(this.IndexString, out index))
				{
					return index;
				}
				return null;
			}
		}
	}
	public class PlaceholderValue
	{
		public PlaceholderName Name { get; set; }
		public string DisplayName { get { return ":p" + this.Name.IndexString; } }
		public string Value { get; set; }
		public string SourceText { get; set; }
		public string ValueMetadata { get; set; }
	}
	//public class Placeholder
	//{
	//	public PlaceholderName Name { get; set; }
	//	public PlaceholderValue Value { get; set; }
	//	public string NameForBinding { get { return this.Name.IndexString; } }
	//	public string ValueForBinding
	//	{
	//		get
	//		{
	//			return this.Value.Value;
	//		}
	//		set { this.Value.Value = value; }
	//	}
	//}

	public static class ParserFormatter
	{
		/// <summary>
		/// Example input:
		/// ;:p0 = '1999-01-01' [Type: String (0:0:0)], :p1 = False [Type: Boolean (0:0:0)], :p2 = '1999-01-01' [Type: String (0:0:0)], :p3 = False [Type: Boolean (0:0:0)], :p4 = 5 [Type: Int32 (0:0:0)], :p5 = '58F88EA5D5604750B5B6F82E930AADAC' [Type: String (0:0:0)], :p6 = 0 [Type: Int32 (0:0:0)]";
		/// </summary>
		public static IList<PlaceholderValue> ParsePlaceholderValues(string text)
		{
			var parts = text.Trim().Split(new[] { ";:p0" }, StringSplitOptions.None);
			text = ":p0" + parts[1];

			var values = new List<PlaceholderValue>();
			Int32 i = 0;
			while (i < text.Length)
			{
				PlaceholderValue value = ParsePlaceholderValue(text.Substring(i));
				if (value == null)
					return values;
				values.Add(value);
				i += value.SourceText.Length;
			}
			return values;
		}

		/// <summary>
		/// Example input:
		/// :p1 = False [Type: Boolean (0:0:0)]
		/// </summary>
		public static PlaceholderValue ParsePlaceholderValue(string text)
		{
			var placeholderValue = new PlaceholderValue { Name = ParsePlaceholderName(text) };
			Int32 i = placeholderValue.Name.SourceText.Length;
			while (text[i] != '=')
			{
				i++;
			}
			i++;//skip =
			while (text[i] != '[')
			{
				placeholderValue.Value += text[i];
				i++;
			}
			placeholderValue.Value = placeholderValue.Value.Trim();

			//parse value metadata
			placeholderValue.ValueMetadata = "";
			while (text[i] != ']')
			{
				placeholderValue.ValueMetadata += text[i];
				i++;
			}
			i++;//skip ]
			placeholderValue.SourceText = text.Substring(0, i);
			return placeholderValue;
		}

		/// <summary>
		/// Example input:
		/// :p13 
		/// </summary>
		public static PlaceholderName ParsePlaceholderName(string placeholderText)
		{
			if (string.IsNullOrWhiteSpace(placeholderText))
				return null;

			var i = 0;
			while (i < placeholderText.Length)
			{
				if (placeholderText[i] == ':' && placeholderText[i + 1] == 'p')
					break;
				i++;
			}

			i++;//skip :
			i++;//skip p
			var name = new PlaceholderName();
			while (Char.IsDigit(placeholderText[i]))
			{
				name.IndexString += placeholderText[i];
				i++;
			}
			name.SourceText = placeholderText.Substring(0, i);
			return name;
		}

		public static string FormatAsSql(string nHibernateText, IList<PlaceholderValue> values)
		{
			var parts = nHibernateText.Split(new []{";:p0"}, StringSplitOptions.None);
			var sqlText = parts[0];
			
			//remove possible prefixes
			sqlText = sqlText.Replace("NHibernate.SQL: DEBUG -", "").Trim();

			foreach(var value in values)
			{
				sqlText = sqlText.Replace(value.DisplayName+" ", value.Value+" ");
			}
			sqlText.Trim();
			return sqlText;
		}
	}
}
