﻿using System;
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
		public string DisplayName { get { return "p" + this.Name.IndexString; } }
		public string Value { get; set; }
		public string SourceText { get; set; }
		public string ValueMetadata { get; set; }
	}

	public class ParserFormatter
	{
		readonly char _delimiter;
		public ParserFormatter(string text)
		{
			this._delimiter = text.IndexOf(";:p0") > 0 ? ':' : '@';
		}

		/// <summary>
		/// Example input:
		/// ;:p0 = '1999-01-01' [Type: String (0:0:0)], :p1 = False [Type: Boolean (0:0:0)], :p2 = '1999-01-01' [Type: String (0:0:0)], :p3 = False [Type: Boolean (0:0:0)], :p4 = 5 [Type: Int32 (0:0:0)], :p5 = '58F88EA5D5604750B5B6F82E930AADAC' [Type: String (0:0:0)], :p6 = 0 [Type: Int32 (0:0:0)]";
		/// </summary>
		public IList<PlaceholderValue> ParsePlaceholderValues(string text)
		{
			if (string.IsNullOrWhiteSpace(text))
				return new List<PlaceholderValue>();

			var parts = text.Trim().Split(new[] { ";"+_delimiter + "p0" }, StringSplitOptions.None);
			text = _delimiter+"p0" + parts[1];

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
		public PlaceholderValue ParsePlaceholderValue(string text)
		{
			var placeholderValue = new PlaceholderValue { Name = ParsePlaceholderName(text) };
			if (placeholderValue.Name == null)//no placeholder found in the given text
				return null;
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
		public PlaceholderName ParsePlaceholderName(string placeholderText)
		{
			if (string.IsNullOrWhiteSpace(placeholderText) || placeholderText.Length < 3)//min length of placeholder text
				return null;

			var i = 0;
			while (i < placeholderText.Length)
			{
				if (placeholderText[i] == _delimiter && placeholderText[i + 1] == 'p')
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

		public string FormatAsSql(string nHibernateText, IList<PlaceholderValue> values)
		{
			if (values == null)
				return "";

			var parts = nHibernateText.Split(new[] { ";"+_delimiter+"p0" }, StringSplitOptions.None);
			var sqlText = parts[0];

			//remove possible prefixes
			sqlText = sqlText.Replace("NHibernate.SQL: DEBUG -", "").Trim();

			//replace placeholders in descending order so double digit placeholders don't get replaced by single digit placeholder values
			foreach (var value in values.OrderByDescending(value => value.Name.Index))
			{
				sqlText = sqlText.Replace(_delimiter+value.DisplayName, value.Value);
			}
			sqlText.Trim();
			return sqlText;
		}

		static bool IsKeyword(IList<string> sqlText, Int32 location, IList<string> keyword)
		{
			if (location + keyword.Count >= sqlText.Count)
				return false;
			var s = location;
			var k = 0;
			while (k < keyword.Count)
			{
				if (!string.Equals(sqlText[s], keyword[k], StringComparison.InvariantCultureIgnoreCase))
					return false;
				s++;
				k++;
			}
			return true;
		}

		public string PrettyPrintSql(string sqlText)
		{
			var keywords = new List<string[]>();
 				keywords.Add(new []{"and"});
				keywords.Add(new []{"or"});
				keywords.Add(new []{"select"});
				keywords.Add(new []{"from"});
				keywords.Add(new []{"where"});
				keywords.Add(new []{"having"});
				keywords.Add(new []{"order", "by"}); 
				keywords.Add(new []{"group", "by"});
				keywords.Add(new []{"inner", "join"});
				keywords.Add(new []{"outer", "join"});
				keywords.Add(new []{"left", "outer", "join"});
				keywords.Add(new[] { "cross", "join" });

			var formattedSql = string.Empty;
			var words = sqlText.Split(new[] { ' ', '\t' });
			for (var i = 0; i < words.Length; i++)
			{
				var word = words[i];
				if (keywords.Any(keyword => IsKeyword(words, i, keyword)))
				{
					formattedSql += Environment.NewLine + Environment.NewLine + word + " ";
				}
				else
				{
					formattedSql += word + " ";
				}
			}
			return formattedSql;
		}
	}
}
