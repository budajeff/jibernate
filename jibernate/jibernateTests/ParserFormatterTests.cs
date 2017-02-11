﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using jibernate;

namespace jibernateTests
{
	[TestClass]
	public class ParserFormatterTests
	{
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
		Client_View as cv
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

			var values = ParserFormatter.ParsePlaceholderValues(@";:p0 = '1999-01-01' [Type: String (0:0:0)], :p1 = False [Type: Boolean (0:0:0)], :p2 = '1999-01-01' [Type: String (0:0:0)], :p3 = False [Type: Boolean (0:0:0)], :p4 = 5 [Type: Int32 (0:0:0)], :p5 = '58F88EA5D5604750B5B6F82E930AADAC' [Type: String (0:0:0)], :p6 = 0 [Type: Int32 (0:0:0)]");
			Assert.IsNotNull(values);
			Assert.AreEqual(7, values.Count);

			var v1 = values[0];
			Assert.AreEqual(v1.DisplayName, ":p0");
			//var result = ParserFormatter.Parse(input);
			//Assert.IsNotNull(result);

			var sql = ParserFormatter.FormatAsSql(input, ParserFormatter.ParsePlaceholderValues(input));
			Assert.IsNotNull(sql);
		}
	}
}
