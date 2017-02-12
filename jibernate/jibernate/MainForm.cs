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
		string _originalSourceText;

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
				sc.Styles[Style.Sql.Word].Bold = true;
				sc.Styles[Style.Sql.Number].ForeColor = Color.DarkOrange;
				sc.Styles[Style.Sql.Operator].ForeColor = Color.Blue;
				sc.Styles[Style.Sql.Comment].ForeColor = Color.Green;
				sc.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
				sc.SetKeywords(0, "select from where having order by group by asc desc");
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
			this._originalSourceText = Clipboard.GetText();
			this._sourceTextBoxSc.Text = Clipboard.GetText();
			try
			{
				this._placeholderValues = ParserFormatter.ParsePlaceholderValues(this._sourceTextBoxSc.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(
					this,
					"Could not parse clipboard text as an NHibernate.SQL log message." 
					+ Environment.NewLine 
					+ ex.Message,
					"jibernate",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
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

			this._sqlTextBoxSc.Text = ParserFormatter.FormatAsSql(this._originalSourceText, this._placeholderValues);
		}

		private void _placeholderGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this._sqlTextBoxSc.Text = ParserFormatter.FormatAsSql(this._originalSourceText, this._placeholderValues);
		}

		private void _sentSqlToClipboardButton_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this._sqlTextBoxSc.Text);
		}
	}
}
