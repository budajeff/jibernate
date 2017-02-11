namespace jibernate
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._sourceTextBox = new System.Windows.Forms.RichTextBox();
			this._sqlTextBox = new System.Windows.Forms.RichTextBox();
			this._placeholderGrid = new System.Windows.Forms.DataGridView();
			this._placeholderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this._placeholdersTopPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._textEditorsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this._nHibernateTextInstructionsLabel = new System.Windows.Forms.Label();
			this._nHibernateTextLabel = new System.Windows.Forms.Label();
			this._getFromClipboardButton = new System.Windows.Forms.Button();
			this._sqlTopPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this._sqlTopLabel = new System.Windows.Forms.Label();
			this._sentSqlToClipboardButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._placeholderGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).BeginInit();
			this._mainSplitContainer.Panel1.SuspendLayout();
			this._mainSplitContainer.Panel2.SuspendLayout();
			this._mainSplitContainer.SuspendLayout();
			this._placeholdersTopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._textEditorsSplitContainer)).BeginInit();
			this._textEditorsSplitContainer.Panel1.SuspendLayout();
			this._textEditorsSplitContainer.Panel2.SuspendLayout();
			this._textEditorsSplitContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this._sqlTopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _sourceTextBox
			// 
			this._sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sourceTextBox.Location = new System.Drawing.Point(0, 118);
			this._sourceTextBox.Name = "_sourceTextBox";
			this._sourceTextBox.ReadOnly = true;
			this._sourceTextBox.Size = new System.Drawing.Size(290, 333);
			this._sourceTextBox.TabIndex = 0;
			this._sourceTextBox.Text = "";
			// 
			// _sqlTextBox
			// 
			this._sqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sqlTextBox.Location = new System.Drawing.Point(0, 117);
			this._sqlTextBox.Name = "_sqlTextBox";
			this._sqlTextBox.ReadOnly = true;
			this._sqlTextBox.Size = new System.Drawing.Size(341, 334);
			this._sqlTextBox.TabIndex = 1;
			this._sqlTextBox.Text = "";
			// 
			// _placeholderGrid
			// 
			this._placeholderGrid.AllowUserToAddRows = false;
			this._placeholderGrid.AllowUserToDeleteRows = false;
			this._placeholderGrid.AllowUserToResizeRows = false;
			this._placeholderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._placeholderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._placeholderColumn,
            this._valueColumn});
			this._placeholderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._placeholderGrid.Location = new System.Drawing.Point(0, 116);
			this._placeholderGrid.Name = "_placeholderGrid";
			this._placeholderGrid.RowHeadersVisible = false;
			this._placeholderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this._placeholderGrid.Size = new System.Drawing.Size(213, 335);
			this._placeholderGrid.TabIndex = 2;
			this._placeholderGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this._placeholderGrid_CellEndEdit);
			this._placeholderGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this._placeholderGrid_CellFormatting);
			this._placeholderGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this._placeholderGrid_DataError);
			// 
			// _placeholderColumn
			// 
			this._placeholderColumn.DataPropertyName = "DisplayName";
			this._placeholderColumn.HeaderText = "Placeholder";
			this._placeholderColumn.Name = "_placeholderColumn";
			this._placeholderColumn.ReadOnly = true;
			// 
			// _valueColumn
			// 
			this._valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this._valueColumn.DataPropertyName = "Value";
			this._valueColumn.HeaderText = "Value";
			this._valueColumn.Name = "_valueColumn";
			this._valueColumn.Width = 59;
			// 
			// _mainSplitContainer
			// 
			this._mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._mainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this._mainSplitContainer.Name = "_mainSplitContainer";
			// 
			// _mainSplitContainer.Panel1
			// 
			this._mainSplitContainer.Panel1.Controls.Add(this._placeholderGrid);
			this._mainSplitContainer.Panel1.Controls.Add(this._placeholdersTopPanel);
			// 
			// _mainSplitContainer.Panel2
			// 
			this._mainSplitContainer.Panel2.Controls.Add(this._textEditorsSplitContainer);
			this._mainSplitContainer.Size = new System.Drawing.Size(852, 451);
			this._mainSplitContainer.SplitterDistance = 213;
			this._mainSplitContainer.TabIndex = 1;
			// 
			// _placeholdersTopPanel
			// 
			this._placeholdersTopPanel.AutoSize = true;
			this._placeholdersTopPanel.Controls.Add(this.label2);
			this._placeholdersTopPanel.Controls.Add(this.label3);
			this._placeholdersTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._placeholdersTopPanel.Location = new System.Drawing.Point(0, 0);
			this._placeholdersTopPanel.Name = "_placeholdersTopPanel";
			this._placeholdersTopPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 68);
			this._placeholdersTopPanel.Size = new System.Drawing.Size(213, 116);
			this._placeholdersTopPanel.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(196, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Placeholder values can be edited below";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
			this.label3.Size = new System.Drawing.Size(185, 35);
			this.label3.TabIndex = 1;
			this.label3.Text = "NHibernate Placeholders";
			// 
			// _textEditorsSplitContainer
			// 
			this._textEditorsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._textEditorsSplitContainer.Location = new System.Drawing.Point(0, 0);
			this._textEditorsSplitContainer.Name = "_textEditorsSplitContainer";
			// 
			// _textEditorsSplitContainer.Panel1
			// 
			this._textEditorsSplitContainer.Panel1.Controls.Add(this._sourceTextBox);
			this._textEditorsSplitContainer.Panel1.Controls.Add(this.panel1);
			// 
			// _textEditorsSplitContainer.Panel2
			// 
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTextBox);
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTopPanel);
			this._textEditorsSplitContainer.Size = new System.Drawing.Size(635, 451);
			this._textEditorsSplitContainer.SplitterDistance = 290;
			this._textEditorsSplitContainer.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this._nHibernateTextInstructionsLabel);
			this.panel1.Controls.Add(this._nHibernateTextLabel);
			this.panel1.Controls.Add(this._getFromClipboardButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.panel1.Size = new System.Drawing.Size(290, 118);
			this.panel1.TabIndex = 2;
			// 
			// _nHibernateTextInstructionsLabel
			// 
			this._nHibernateTextInstructionsLabel.AutoSize = true;
			this._nHibernateTextInstructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._nHibernateTextInstructionsLabel.Location = new System.Drawing.Point(0, 35);
			this._nHibernateTextInstructionsLabel.MaximumSize = new System.Drawing.Size(200, 0);
			this._nHibernateTextInstructionsLabel.Name = "_nHibernateTextInstructionsLabel";
			this._nHibernateTextInstructionsLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this._nHibernateTextInstructionsLabel.Size = new System.Drawing.Size(199, 49);
			this._nHibernateTextInstructionsLabel.TabIndex = 2;
			this._nHibernateTextInstructionsLabel.Text = "Copy a NHibernate.SQL log message into your clipboard, then press the button belo" +
    "w";
			// 
			// _nHibernateTextLabel
			// 
			this._nHibernateTextLabel.AutoSize = true;
			this._nHibernateTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this._nHibernateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nHibernateTextLabel.Location = new System.Drawing.Point(0, 0);
			this._nHibernateTextLabel.Name = "_nHibernateTextLabel";
			this._nHibernateTextLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
			this._nHibernateTextLabel.Size = new System.Drawing.Size(124, 35);
			this._nHibernateTextLabel.TabIndex = 1;
			this._nHibernateTextLabel.Text = "NHibernate Text";
			// 
			// _getFromClipboardButton
			// 
			this._getFromClipboardButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._getFromClipboardButton.Location = new System.Drawing.Point(0, 84);
			this._getFromClipboardButton.Name = "_getFromClipboardButton";
			this._getFromClipboardButton.Size = new System.Drawing.Size(290, 24);
			this._getFromClipboardButton.TabIndex = 0;
			this._getFromClipboardButton.Text = "Get nHibernate Text from Clipboard";
			this._getFromClipboardButton.UseVisualStyleBackColor = true;
			this._getFromClipboardButton.Click += new System.EventHandler(this._getFromClipboardButton_Click);
			// 
			// _sqlTopPanel
			// 
			this._sqlTopPanel.AutoSize = true;
			this._sqlTopPanel.Controls.Add(this.label1);
			this._sqlTopPanel.Controls.Add(this._sqlTopLabel);
			this._sqlTopPanel.Controls.Add(this._sentSqlToClipboardButton);
			this._sqlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._sqlTopPanel.Location = new System.Drawing.Point(0, 0);
			this._sqlTopPanel.Name = "_sqlTopPanel";
			this._sqlTopPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this._sqlTopPanel.Size = new System.Drawing.Size(341, 117);
			this._sqlTopPanel.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(0, 35);
			this.label1.MaximumSize = new System.Drawing.Size(200, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.label1.Size = new System.Drawing.Size(200, 49);
			this.label1.TabIndex = 2;
			this.label1.Text = "Valid SQL based on the NHibernate.SQL log message and the placeholder values is b" +
    "elow";
			// 
			// _sqlTopLabel
			// 
			this._sqlTopLabel.AutoSize = true;
			this._sqlTopLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this._sqlTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sqlTopLabel.Location = new System.Drawing.Point(0, 0);
			this._sqlTopLabel.Name = "_sqlTopLabel";
			this._sqlTopLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
			this._sqlTopLabel.Size = new System.Drawing.Size(41, 35);
			this._sqlTopLabel.TabIndex = 1;
			this._sqlTopLabel.Text = "SQL";
			// 
			// _sentSqlToClipboardButton
			// 
			this._sentSqlToClipboardButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._sentSqlToClipboardButton.Location = new System.Drawing.Point(0, 84);
			this._sentSqlToClipboardButton.Name = "_sentSqlToClipboardButton";
			this._sentSqlToClipboardButton.Size = new System.Drawing.Size(341, 23);
			this._sentSqlToClipboardButton.TabIndex = 0;
			this._sentSqlToClipboardButton.Text = "Send SQL to Clipboard";
			this._sentSqlToClipboardButton.UseVisualStyleBackColor = true;
			this._sentSqlToClipboardButton.Click += new System.EventHandler(this._sentSqlToClipboardButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 451);
			this.Controls.Add(this._mainSplitContainer);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "jibernate";
			((System.ComponentModel.ISupportInitialize)(this._placeholderGrid)).EndInit();
			this._mainSplitContainer.Panel1.ResumeLayout(false);
			this._mainSplitContainer.Panel1.PerformLayout();
			this._mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).EndInit();
			this._mainSplitContainer.ResumeLayout(false);
			this._placeholdersTopPanel.ResumeLayout(false);
			this._placeholdersTopPanel.PerformLayout();
			this._textEditorsSplitContainer.Panel1.ResumeLayout(false);
			this._textEditorsSplitContainer.Panel1.PerformLayout();
			this._textEditorsSplitContainer.Panel2.ResumeLayout(false);
			this._textEditorsSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._textEditorsSplitContainer)).EndInit();
			this._textEditorsSplitContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this._sqlTopPanel.ResumeLayout(false);
			this._sqlTopPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _sourceTextBox;
		private System.Windows.Forms.RichTextBox _sqlTextBox;
		private System.Windows.Forms.DataGridView _placeholderGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn _placeholderColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _valueColumn;
		private System.Windows.Forms.SplitContainer _mainSplitContainer;
		private System.Windows.Forms.SplitContainer _textEditorsSplitContainer;
		private System.Windows.Forms.Label _nHibernateTextLabel;
		private System.Windows.Forms.Button _getFromClipboardButton;
		private System.Windows.Forms.Panel _placeholdersTopPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label _nHibernateTextInstructionsLabel;
		private System.Windows.Forms.Panel _sqlTopPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _sqlTopLabel;
		private System.Windows.Forms.Button _sentSqlToClipboardButton;
	}
}

