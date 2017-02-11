using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jibernate
{
	public partial class MainForm : Form
	{
		IList<PlaceholderValue> _placeholderValues;
		string _originalSourceText;

		public MainForm()
		{
			InitializeComponent();
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
			this._sourceTextBox.Text = Clipboard.GetText();
			this._placeholderValues = ParserFormatter.ParsePlaceholderValues(this._sourceTextBox.Text);
			this._placeholderGrid.DataSource = new BindingSource { DataSource = _placeholderValues };
		}

		private void _sendSqlToClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this._sqlTextBox.Text);
		}

		private void _placeholderGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this._sqlTextBox.Text = ParserFormatter.FormatAsSql(this._sourceTextBox.Text, this._placeholderValues);
		}
	}
}
