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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this._placeholderGrid = new System.Windows.Forms.DataGridView();
			this._placeholderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this._placeholdersTopPanel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this._textEditorsSplitContainer = new System.Windows.Forms.SplitContainer();
			this._sourceTextBoxSc = new ScintillaNET.Scintilla();
			this._logInstructionsPanel = new System.Windows.Forms.Panel();
			this._nHibernateTextLabel = new System.Windows.Forms.Label();
			this._getFromClipboardButton = new System.Windows.Forms.Button();
			this._sqlTextBoxSc = new ScintillaNET.Scintilla();
			this._sqlTopPanel = new System.Windows.Forms.Panel();
			this._prettyPrintButton = new System.Windows.Forms.Button();
			this._sentSqlToClipboardButton = new System.Windows.Forms.Button();
			this._sqlTopLabel = new System.Windows.Forms.Label();
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
			this._logInstructionsPanel.SuspendLayout();
			this._sqlTopPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _placeholderGrid
			// 
			this._placeholderGrid.AllowUserToAddRows = false;
			this._placeholderGrid.AllowUserToDeleteRows = false;
			this._placeholderGrid.AllowUserToResizeRows = false;
			this._placeholderGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this._placeholderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._placeholderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._placeholderColumn,
            this._valueColumn});
			this._placeholderGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this._placeholderGrid.Location = new System.Drawing.Point(0, 20);
			this._placeholderGrid.Name = "_placeholderGrid";
			this._placeholderGrid.RowHeadersVisible = false;
			this._placeholderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this._placeholderGrid.Size = new System.Drawing.Size(329, 558);
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
			this._mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
			this._mainSplitContainer.Size = new System.Drawing.Size(1031, 582);
			this._mainSplitContainer.SplitterDistance = 333;
			this._mainSplitContainer.TabIndex = 1;
			// 
			// _placeholdersTopPanel
			// 
			this._placeholdersTopPanel.AutoSize = true;
			this._placeholdersTopPanel.Controls.Add(this.label3);
			this._placeholdersTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._placeholdersTopPanel.Location = new System.Drawing.Point(0, 0);
			this._placeholdersTopPanel.Name = "_placeholdersTopPanel";
			this._placeholdersTopPanel.Size = new System.Drawing.Size(329, 20);
			this._placeholdersTopPanel.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "NHibernate Placeholders";
			// 
			// _textEditorsSplitContainer
			// 
			this._textEditorsSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._textEditorsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._textEditorsSplitContainer.Location = new System.Drawing.Point(0, 0);
			this._textEditorsSplitContainer.Name = "_textEditorsSplitContainer";
			this._textEditorsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// _textEditorsSplitContainer.Panel1
			// 
			this._textEditorsSplitContainer.Panel1.Controls.Add(this._sourceTextBoxSc);
			this._textEditorsSplitContainer.Panel1.Controls.Add(this._logInstructionsPanel);
			// 
			// _textEditorsSplitContainer.Panel2
			// 
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTextBoxSc);
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTopPanel);
			this._textEditorsSplitContainer.Size = new System.Drawing.Size(694, 582);
			this._textEditorsSplitContainer.SplitterDistance = 243;
			this._textEditorsSplitContainer.SplitterWidth = 5;
			this._textEditorsSplitContainer.TabIndex = 0;
			// 
			// _sourceTextBoxSc
			// 
			this._sourceTextBoxSc.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sourceTextBoxSc.Location = new System.Drawing.Point(0, 33);
			this._sourceTextBoxSc.Name = "_sourceTextBoxSc";
			this._sourceTextBoxSc.Size = new System.Drawing.Size(690, 206);
			this._sourceTextBoxSc.TabIndex = 3;
			this._sourceTextBoxSc.Text = "Copy a NHibernate.SQL log message and paste it into this box...";
			this._sourceTextBoxSc.TextChanged += new System.EventHandler(this._sourceTextBoxSc_TextChanged);
			this._sourceTextBoxSc.Click += new System.EventHandler(this._sourceTextBoxSc_Click);
			// 
			// _logInstructionsPanel
			// 
			this._logInstructionsPanel.AutoSize = true;
			this._logInstructionsPanel.Controls.Add(this._nHibernateTextLabel);
			this._logInstructionsPanel.Controls.Add(this._getFromClipboardButton);
			this._logInstructionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._logInstructionsPanel.Location = new System.Drawing.Point(0, 0);
			this._logInstructionsPanel.Name = "_logInstructionsPanel";
			this._logInstructionsPanel.Size = new System.Drawing.Size(690, 33);
			this._logInstructionsPanel.TabIndex = 2;
			// 
			// _nHibernateTextLabel
			// 
			this._nHibernateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nHibernateTextLabel.Location = new System.Drawing.Point(3, 9);
			this._nHibernateTextLabel.Name = "_nHibernateTextLabel";
			this._nHibernateTextLabel.Size = new System.Drawing.Size(204, 24);
			this._nHibernateTextLabel.TabIndex = 1;
			this._nHibernateTextLabel.Text = "NHibernate.SQL Log Message";
			// 
			// _getFromClipboardButton
			// 
			this._getFromClipboardButton.Location = new System.Drawing.Point(213, 5);
			this._getFromClipboardButton.Name = "_getFromClipboardButton";
			this._getFromClipboardButton.Size = new System.Drawing.Size(115, 24);
			this._getFromClipboardButton.TabIndex = 0;
			this._getFromClipboardButton.Text = "Paste From Clipboard";
			this._getFromClipboardButton.UseVisualStyleBackColor = true;
			this._getFromClipboardButton.Click += new System.EventHandler(this._getFromClipboardButton_Click);
			// 
			// _sqlTextBoxSc
			// 
			this._sqlTextBoxSc.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sqlTextBoxSc.Location = new System.Drawing.Point(0, 34);
			this._sqlTextBoxSc.Name = "_sqlTextBoxSc";
			this._sqlTextBoxSc.Size = new System.Drawing.Size(690, 296);
			this._sqlTextBoxSc.TabIndex = 4;
			this._sqlTextBoxSc.Text = "...then the SQL statement will appear here. Change placeholder values in the grid" +
    " to the left.";
			this._sqlTextBoxSc.MouseClick += new System.Windows.Forms.MouseEventHandler(this._sqlTextBoxSc_MouseClick);
			// 
			// _sqlTopPanel
			// 
			this._sqlTopPanel.Controls.Add(this._prettyPrintButton);
			this._sqlTopPanel.Controls.Add(this._sentSqlToClipboardButton);
			this._sqlTopPanel.Controls.Add(this._sqlTopLabel);
			this._sqlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._sqlTopPanel.Location = new System.Drawing.Point(0, 0);
			this._sqlTopPanel.Name = "_sqlTopPanel";
			this._sqlTopPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this._sqlTopPanel.Size = new System.Drawing.Size(690, 34);
			this._sqlTopPanel.TabIndex = 3;
			// 
			// _prettyPrintButton
			// 
			this._prettyPrintButton.Location = new System.Drawing.Point(154, 5);
			this._prettyPrintButton.Name = "_prettyPrintButton";
			this._prettyPrintButton.Size = new System.Drawing.Size(67, 23);
			this._prettyPrintButton.TabIndex = 2;
			this._prettyPrintButton.Text = "Pretty Print";
			this._prettyPrintButton.UseVisualStyleBackColor = true;
			this._prettyPrintButton.Click += new System.EventHandler(this._prettyPrintButton_Click);
			// 
			// _sentSqlToClipboardButton
			// 
			this._sentSqlToClipboardButton.Location = new System.Drawing.Point(47, 5);
			this._sentSqlToClipboardButton.Name = "_sentSqlToClipboardButton";
			this._sentSqlToClipboardButton.Size = new System.Drawing.Size(101, 23);
			this._sentSqlToClipboardButton.TabIndex = 0;
			this._sentSqlToClipboardButton.Text = "Copy to Clipboard";
			this._sentSqlToClipboardButton.UseVisualStyleBackColor = true;
			this._sentSqlToClipboardButton.Click += new System.EventHandler(this._sentSqlToClipboardButton_Click);
			// 
			// _sqlTopLabel
			// 
			this._sqlTopLabel.AutoSize = true;
			this._sqlTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sqlTopLabel.Location = new System.Drawing.Point(5, 3);
			this._sqlTopLabel.Name = "_sqlTopLabel";
			this._sqlTopLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this._sqlTopLabel.Size = new System.Drawing.Size(36, 22);
			this._sqlTopLabel.TabIndex = 1;
			this._sqlTopLabel.Text = "SQL";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 582);
			this.Controls.Add(this._mainSplitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
			((System.ComponentModel.ISupportInitialize)(this._textEditorsSplitContainer)).EndInit();
			this._textEditorsSplitContainer.ResumeLayout(false);
			this._logInstructionsPanel.ResumeLayout(false);
			this._sqlTopPanel.ResumeLayout(false);
			this._sqlTopPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView _placeholderGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn _placeholderColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn _valueColumn;
		private System.Windows.Forms.SplitContainer _mainSplitContainer;
		private System.Windows.Forms.SplitContainer _textEditorsSplitContainer;
		private System.Windows.Forms.Label _nHibernateTextLabel;
		private System.Windows.Forms.Button _getFromClipboardButton;
		private System.Windows.Forms.Panel _placeholdersTopPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel _logInstructionsPanel;
		private System.Windows.Forms.Panel _sqlTopPanel;
		private System.Windows.Forms.Label _sqlTopLabel;
		private System.Windows.Forms.Button _sentSqlToClipboardButton;
		private ScintillaNET.Scintilla _sourceTextBoxSc;
		private ScintillaNET.Scintilla _sqlTextBoxSc;
		private System.Windows.Forms.Button _prettyPrintButton;
	}
}

