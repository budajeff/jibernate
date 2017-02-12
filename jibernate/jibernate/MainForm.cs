using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET;

namespace jibernate
{
	public partial class MainForm : Form
	{
		IList<PlaceholderValue> _placeholderValues;

		public MainForm()
		{
			InitializeComponent();
			this._placeholderGrid.AutoGenerateColumns = false;

			foreach (var sc in new[] {this._sourceTextBoxSc, this._sqlTextBoxSc })
			{
				sc.WrapMode = WrapMode.Whitespace;
				sc.StyleClearAll();
				sc.Lexer = Lexer.Sql;
				sc.Styles[Style.Sql.Word].ForeColor = Color.Blue;
				sc.Styles[Style.Sql.String].ForeColor = Color.Blue;
				sc.Styles[Style.Sql.Number].ForeColor = Color.Green;
				sc.Styles[Style.Sql.Character].ForeColor = Color.Green;
				sc.Styles[Style.Sql.Operator].ForeColor = Color.Blue;
				sc.Styles[Style.Sql.QuotedIdentifier].ForeColor = Color.Blue;
				sc.SetKeywords(0, "select from where having order by group by asc desc case when then else end inner join left outer on in some not and or sum");
			}
		}

		private void _placeholderGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			e.FormattingApplied = true;
		}

		private void _placeholderGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.Cancel = true;
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void _getFromClipboardButton_Click(object sender, EventArgs e)
		{
			this._sourceTextBoxSc.Text = Clipboard.GetText();
		}

		private void _placeholderGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this._sqlTextBoxSc.Text = ParserFormatter.FormatAsSql(this._sourceTextBoxSc.Text, this._placeholderValues);
		}

		private void _sentSqlToClipboardButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this._sqlTextBoxSc.Text);
		}

		private void _prettyPrintButton_Click(object sender, EventArgs e)
		{
			this._sqlTextBoxSc.Text = ParserFormatter.PrettyPrintSql(this._sqlTextBoxSc.Text);
		}

		private void _sourceTextBoxSc_TextChanged(object sender, EventArgs e)
		{
			this.Reparse();
		}

		private void Reparse()
		{
			try
			{
				this._placeholderValues = ParserFormatter.ParsePlaceholderValues(this._sourceTextBoxSc.Text);
			}
			catch (Exception ex)
			{
				this._sqlTextBoxSc.Text = "Error: Could not parse clipboard text as an NHibernate.SQL log message.";
				return;
			}

			if (this._placeholderGrid.DataSource != null)
			{
				((BindingSource)this._placeholderGrid.DataSource).Clear();
			}
			else
			{
				this._placeholderGrid.DataSource = new BindingSource();
			}
			foreach (var item in this._placeholderValues)
				((BindingSource)this._placeholderGrid.DataSource).Add(item);

			this._sqlTextBoxSc.Text = ParserFormatter.FormatAsSql(this._sourceTextBoxSc.Text, this._placeholderValues);
		}
	}
}
