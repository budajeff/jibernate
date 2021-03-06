﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jibernate;

namespace jibernateTests
{
	[TestClass]
	public class ParserFormatterTests
	{
		[TestMethod]
		public void CanParseFormatSmallLog()
		{ 
			const string input = @"NHibernate.SQL: DEBUG - SELECT ID as y0_ from a_table as t where t.ID > :p0;:p0 = 0 [Type: Decimal (0:0:0)];";
			var values = new ParserFormatter(input).ParsePlaceholderValues(input);
			Assert.IsNotNull(values);
			Assert.AreEqual(1, values.Count);
			var sql = new ParserFormatter(input).FormatAsSql(input, values);
			Assert.AreEqual(@"SELECT ID as y0_ from a_table as t where t.ID > 0", sql);
		}

		[TestMethod]
		public void CanParseFormatSqLiteLog()
		{
			const string input = @"NHibernate.SQL: DEBUG - SELECT ID as y0_ from a_table as t where t.ID > @p0;@p0 = 0 [Type: Decimal (0:0:0)];";
			var values = new ParserFormatter(input).ParsePlaceholderValues(input);
			Assert.IsNotNull(values);
			Assert.AreEqual(1, values.Count);
			var sql = new ParserFormatter(input).FormatAsSql(input, values);
			Assert.AreEqual(@"SELECT ID as y0_ from a_table as t where t.ID > 0", sql);
		}

		[TestMethod]
		public void CanParseDoubleDigitPlaceholders()
		{
			const string input = @"NHibernate.SQL: DEBUG - SELECT tealias1_.TIME_AND_EXPENSE_ID as y0_, sum((case when this_.BILLED_AMOUNT > :p0 then :p1 else :p2 end)) as y1_ FROM INVOICE_DETAIL this_ inner join ACCOUNTS_RECEIVABLE aralias2_ on this_.ACCOUNTS_RECEIVABLE_ID=aralias2_.ACCOUNTS_RECEIVABLE_ID inner join TIME_AND_EXPENSE tealias1_ on this_.TIME_AND_EXPENSE_ID=tealias1_.TIME_AND_EXPENSE_ID WHERE :p3 = tealias1_.COMPANY_ID and (this_.IS_DELETED = :p4 and aralias2_.IS_DELETED = :p5) and not (:p6 = aralias2_.ACCOUNTS_RECEIVABLE_SUBTYPE_ID) and :p7 = tealias1_.TIME_AND_EXPENSE_TYPE_ID and (tealias1_.TIME_AND_EXPENSE_ID in (:p8)) GROUP BY tealias1_.TIME_AND_EXPENSE_ID HAVING not (:p9 = sum((case when this_.BILLED_AMOUNT > :p10 then :p11 else :p12 end)));:p0 = 0 [Type: Decimal (0:0:0)], :p1 = 1 [Type: Int32 (0:0:0)], :p2 = 0 [Type: Int32 (0:0:0)], :p3 = '5B80623B94F848AFA6B691EFAAEE4A47' [Type: String (0:0:0)], :p4 = False [Type: Boolean (0:0:0)], :p5 = False [Type: Boolean (0:0:0)], :p6 = 'PARTIALINVOICE' [Type: String (0:0:0)], :p7 = 'PROGRESSBILLING' [Type: String (0:0:0)], :p8 = '459A4CE196F745DD92C9C81F31BC0CE7' [Type: String (0:0:0)], :p9 = 1 [Type: Int32 (0:0:0)], :p10 = 0 [Type: Decimal (0:0:0)], :p11 = 1 [Type: Int32 (0:0:0)], :p12 = 0 [Type: Int32 (0:0:0)]";
			var values = new ParserFormatter(input).ParsePlaceholderValues(input);
			Assert.IsNotNull(values);
			Assert.AreEqual(13, values.Count);
		}

		[TestMethod]
		public void CanParseSevenPlaceholders()
		{
			const string input = @"
NHibernate.SQL: DEBUG - SELECT this_.GROUP_BY__CLIENT_ID as GROUP1_101_0_, this_.COMPANY_ID as COMPANY2_101_0_, this_.CLIENT__CODE as CLIENT3_101_0_, this_.CLIENT__NAME as CLIENT4_101_0_, this_.PARTNER__EMPLOYEE_ID as PARTNER5_101_0_, this_.PARTNER__EMPLOYEE__CODE as PARTNER6_101_0_, this_.SORT_TIMESTAMP as SORT7_101_0_, this_.posted_open_amount as posted8_101_0_, this_.oldest_balance_days as oldest9_101_0_, FALSE as formula177_0_ FROM ( select  
	COMPANY_ID,
	GROUP_BY__CLIENT_ID,
	CLIENT__CODE,
	CLIENT__NAME,
	PARTNER__EMPLOYEE_ID,
	PARTNER__EMPLOYEE__CODE,
	sort_timestamp,
	posted_open_amount,
	oldest_balance_days,
	newest_invoice_date,
	newest_entry_date
from
(
	select  
		cv.COMPANY_ID,
		cv.CLIENT_ID as GROUP_BY__CLIENT_ID,
		cv.code as CLIENT__CODE,
		cv.name as CLIENT__NAME,
		cv.PARTNER__EMPLOYEE_ID,
		cv.PARTNER__EMPLOYEE__CODE,
		cv.SORT_TIMESTAMP as sort_timestamp,
		sum(arov.posted_open_amount) as posted_open_amount,
		max(
			  case when arov.posted_open_amount <> 0
			  then DATE_PART('day', date(:p0) - arov.entry_date) - 1 else null end)  as oldest_balance_days,
		max(
			  case when arov.accounts_receivable_type_id = 'INVOICE' -- 1 = INV
			  then arov.entry_date else null end) as newest_invoice_date,
		max(arov.entry_date) as newest_entry_date
	from
		some_view as cv
	inner join 
		accounts_receivable_open_view as arov
		on cv.client_id = arov.client_id
	group by
		cv.company_id,
		cv.client_id,
		cv.code,
		cv.name,
		cv.partner__employee_id,
		cv.partner__employee__code,
		cv.sort_timestamp
) as X
WHERE
	case when :p1
	then newest_invoice_date is null 
		or newest_invoice_date < date(:p2)
	else true = true
	end
ORDER BY
	sort_timestamp ) this_ WHERE FALSE = :p3 and (this_.oldest_balance_days > :p4) and this_.COMPANY_ID = :p5 ORDER BY this_.CLIENT__CODE asc, this_.SORT_TIMESTAMP asc limit :p6;:p0 = '1999-01-01' [Type: String (0:0:0)], :p1 = False [Type: Boolean (0:0:0)], :p2 = '1999-01-01' [Type: String (0:0:0)], :p3 = False [Type: Boolean (0:0:0)], :p4 = 5 [Type: Int32 (0:0:0)], :p5 = '58F88EA5D5604750B5B6F82E930AADAC' [Type: String (0:0:0)], :p6 = 0 [Type: Int32 (0:0:0)]";

			var values = new ParserFormatter(input).ParsePlaceholderValues(@";:p0 = '1999-01-01' [Type: String (0:0:0)], :p1 = False [Type: Boolean (0:0:0)], :p2 = '1999-01-01' [Type: String (0:0:0)], :p3 = False [Type: Boolean (0:0:0)], :p4 = 5 [Type: Int32 (0:0:0)], :p5 = '58F88EA5D5604750B5B6F82E930AADAC' [Type: String (0:0:0)], :p6 = 0 [Type: Int32 (0:0:0)]");
			Assert.IsNotNull(values);
			Assert.AreEqual(7, values.Count);

			var v1 = values[0];
			Assert.AreEqual(v1.DisplayName, "p0");
			//var result = ParserFormatter.Parse(input);
			//Assert.IsNotNull(result);

			var sql = new ParserFormatter(input).FormatAsSql(input, new ParserFormatter(input).ParsePlaceholderValues(input));
			Assert.IsNotNull(sql);
		}

		[TestMethod]
		public void CanParseAndFormatSelectOnePlaceholder()
		{
			const string input = @"NHibernate.SQL: DEBUG - SELECT contactema0_.CONTACT_ID as CONTACT13_15_1_, contactema0_.CONTACT_EMAIL_ID as CONTACT1_15_1_, contactema0_.CONTACT_EMAIL_ID as CONTACT1_15_0_, contactema0_.CREATED as CREATED2_15_0_, contactema0_.CHANGED as CHANGED3_15_0_, contactema0_.DELETED as DELETED4_15_0_, contactema0_.IS_DELETED as IS5_15_0_, contactema0_.CREATED_BY__CONTACT_ID as CREATED6_15_0_, contactema0_.CHANGED_BY__CONTACT_ID as CHANGED7_15_0_, contactema0_.EMAIL_ADDRESS as EMAIL8_15_0_, contactema0_.CONTACT_EMAIL_TYPE_ID as CONTACT9_15_0_, contactema0_.EMAIL_TYPE_SPECIFIED as EMAIL10_15_0_, contactema0_.SORT_ORDER as SORT11_15_0_, contactema0_.IS_PRIMARY as IS12_15_0_, contactema0_.CONTACT_ID as CONTACT13_15_0_ FROM SOME_TABLE contactema0_ WHERE  (contactema0_.IS_DELETED=FALSE) and contactema0_.CONTACT_ID=:p0;:p0 = 'B04712F663BF4FF0A6F5BC93A12FDC6C' [Type: String (0:0:0)]";

			var values = new ParserFormatter(input).ParsePlaceholderValues(input);
			Assert.IsNotNull(values);
			Assert.AreEqual(1, values.Count);
			var value = values[0];
			Assert.AreEqual("'B04712F663BF4FF0A6F5BC93A12FDC6C'", value.Value);
			Assert.AreEqual("p0", value.DisplayName);
			var sql = new ParserFormatter(input).FormatAsSql(input, values);
			const string expectedSql = @"SELECT contactema0_.CONTACT_ID as CONTACT13_15_1_, contactema0_.CONTACT_EMAIL_ID as CONTACT1_15_1_, contactema0_.CONTACT_EMAIL_ID as CONTACT1_15_0_, contactema0_.CREATED as CREATED2_15_0_, contactema0_.CHANGED as CHANGED3_15_0_, contactema0_.DELETED as DELETED4_15_0_, contactema0_.IS_DELETED as IS5_15_0_, contactema0_.CREATED_BY__CONTACT_ID as CREATED6_15_0_, contactema0_.CHANGED_BY__CONTACT_ID as CHANGED7_15_0_, contactema0_.EMAIL_ADDRESS as EMAIL8_15_0_, contactema0_.CONTACT_EMAIL_TYPE_ID as CONTACT9_15_0_, contactema0_.EMAIL_TYPE_SPECIFIED as EMAIL10_15_0_, contactema0_.SORT_ORDER as SORT11_15_0_, contactema0_.IS_PRIMARY as IS12_15_0_, contactema0_.CONTACT_ID as CONTACT13_15_0_ FROM SOME_TABLE contactema0_ WHERE  (contactema0_.IS_DELETED=FALSE) and contactema0_.CONTACT_ID='B04712F663BF4FF0A6F5BC93A12FDC6C'";
			Assert.AreEqual(expectedSql, sql);
		}
	}
}
