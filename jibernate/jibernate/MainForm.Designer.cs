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
			this._placeholdersLabel = new System.Windows.Forms.Label();
			this._textEditorsSplitContainer = new System.Windows.Forms.SplitContainer();
			this._nHibernateTextLabel = new System.Windows.Forms.Label();
			this._sqlTextLabel = new System.Windows.Forms.Label();
			this._buttonPanel = new System.Windows.Forms.Panel();
			this._closeButton = new System.Windows.Forms.Button();
			this._sendSqlToClipboard = new System.Windows.Forms.Button();
			this._getFromClipboardButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._placeholderGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).BeginInit();
			this._mainSplitContainer.Panel1.SuspendLayout();
			this._mainSplitContainer.Panel2.SuspendLayout();
			this._mainSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._textEditorsSplitContainer)).BeginInit();
			this._textEditorsSplitContainer.Panel1.SuspendLayout();
			this._textEditorsSplitContainer.Panel2.SuspendLayout();
			this._textEditorsSplitContainer.SuspendLayout();
			this._buttonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _sourceTextBox
			// 
			this._sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sourceTextBox.Location = new System.Drawing.Point(0, 35);
			this._sourceTextBox.Name = "_sourceTextBox";
			this._sourceTextBox.ReadOnly = true;
			this._sourceTextBox.Size = new System.Drawing.Size(290, 382);
			this._sourceTextBox.TabIndex = 0;
			this._sourceTextBox.Text = "Paste NHibernate.SQL log message here...";
			// 
			// _sqlTextBox
			// 
			this._sqlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._sqlTextBox.Location = new System.Drawing.Point(0, 33);
			this._sqlTextBox.Name = "_sqlTextBox";
			this._sqlTextBox.ReadOnly = true;
			this._sqlTextBox.Size = new System.Drawing.Size(341, 384);
			this._sqlTextBox.TabIndex = 1;
			this._sqlTextBox.Text = "...then SQL Client -friendly SQL text will appear here";
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
			this._placeholderGrid.Location = new System.Drawing.Point(0, 35);
			this._placeholderGrid.Name = "_placeholderGrid";
			this._placeholderGrid.RowHeadersVisible = false;
			this._placeholderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this._placeholderGrid.Size = new System.Drawing.Size(213, 382);
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
			this._mainSplitContainer.Panel1.Controls.Add(this._placeholdersLabel);
			// 
			// _mainSplitContainer.Panel2
			// 
			this._mainSplitContainer.Panel2.Controls.Add(this._textEditorsSplitContainer);
			this._mainSplitContainer.Size = new System.Drawing.Size(852, 417);
			this._mainSplitContainer.SplitterDistance = 213;
			this._mainSplitContainer.TabIndex = 1;
			// 
			// _placeholdersLabel
			// 
			this._placeholdersLabel.AutoSize = true;
			this._placeholdersLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this._placeholdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._placeholdersLabel.Location = new System.Drawing.Point(0, 0);
			this._placeholdersLabel.Name = "_placeholdersLabel";
			this._placeholdersLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
			this._placeholdersLabel.Size = new System.Drawing.Size(100, 35);
			this._placeholdersLabel.TabIndex = 3;
			this._placeholdersLabel.Text = "Placeholders";
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
			this._textEditorsSplitContainer.Panel1.Controls.Add(this._nHibernateTextLabel);
			// 
			// _textEditorsSplitContainer.Panel2
			// 
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTextBox);
			this._textEditorsSplitContainer.Panel2.Controls.Add(this._sqlTextLabel);
			this._textEditorsSplitContainer.Size = new System.Drawing.Size(635, 417);
			this._textEditorsSplitContainer.SplitterDistance = 290;
			this._textEditorsSplitContainer.TabIndex = 0;
			// 
			// _nHibernateTextLabel
			// 
			this._nHibernateTextLabel.AutoSize = true;
			this._nHibernateTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this._nHibernateTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._nHibernateTextLabel.Location = new System.Drawing.Point(0, 0);
			this._nHibernateTextLabel.Name = "_nHibernateTextLabel";
			this._nHibernateTextLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
			this._nHibernateTextLabel.Size = new System.Drawing.Size(122, 35);
			this._nHibernateTextLabel.TabIndex = 1;
			this._nHibernateTextLabel.Text = "nHibernate Text";
			// 
			// _sqlTextLabel
			// 
			this._sqlTextLabel.AutoSize = true;
			this._sqlTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this._sqlTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._sqlTextLabel.Location = new System.Drawing.Point(0, 0);
			this._sqlTextLabel.Name = "_sqlTextLabel";
			this._sqlTextLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 8);
			this._sqlTextLabel.Size = new System.Drawing.Size(41, 33);
			this._sqlTextLabel.TabIndex = 2;
			this._sqlTextLabel.Text = "SQL";
			// 
			// _buttonPanel
			// 
			this._buttonPanel.Controls.Add(this._closeButton);
			this._buttonPanel.Controls.Add(this._sendSqlToClipboard);
			this._buttonPanel.Controls.Add(this._getFromClipboardButton);
			this._buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._buttonPanel.Location = new System.Drawing.Point(0, 417);
			this._buttonPanel.Name = "_buttonPanel";
			this._buttonPanel.Size = new System.Drawing.Size(852, 34);
			this._buttonPanel.TabIndex = 2;
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeButton.Location = new System.Drawing.Point(774, 3);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(75, 23);
			this._closeButton.TabIndex = 2;
			this._closeButton.Text = "Close";
			this._closeButton.UseVisualStyleBackColor = true;
			this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
			// 
			// _sendSqlToClipboard
			// 
			this._sendSqlToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._sendSqlToClipboard.Location = new System.Drawing.Point(636, 3);
			this._sendSqlToClipboard.Name = "_sendSqlToClipboard";
			this._sendSqlToClipboard.Size = new System.Drawing.Size(132, 23);
			this._sendSqlToClipboard.TabIndex = 1;
			this._sendSqlToClipboard.Text = "Send SQL to Clipboard";
			this._sendSqlToClipboard.UseVisualStyleBackColor = true;
			this._sendSqlToClipboard.Click += new System.EventHandler(this._sendSqlToClipboard_Click);
			// 
			// _getFromClipboardButton
			// 
			this._getFromClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._getFromClipboardButton.Location = new System.Drawing.Point(426, 3);
			this._getFromClipboardButton.Name = "_getFromClipboardButton";
			this._getFromClipboardButton.Size = new System.Drawing.Size(204, 23);
			this._getFromClipboardButton.TabIndex = 0;
			this._getFromClipboardButton.Text = "Get nHibernate Text from Clipboard";
			this._getFromClipboardButton.UseVisualStyleBackColor = true;
			this._getFromClipboardButton.Click += new System.EventHandler(this._getFromClipboardButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 451);
			this.Controls.Add(this._mainSplitContainer);
			this.Controls.Add(this._buttonPanel);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "jibernate";
			((System.ComponentModel.ISupportInitialize)(this._placeholderGrid)).EndInit();
			this._mainSplitContainer.Panel1.ResumeLayout(false);
			this._mainSplitContainer.Panel1.PerformLayout();
			this._mainSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).EndInit();
			this._mainSplitContainer.ResumeLayout(false);
			this._textEditorsSplitContainer.Panel1.ResumeLayout(false);
			this._textEditorsSplitContainer.Panel1.PerformLayout();
			this._textEditorsSplitContainer.Panel2.ResumeLayout(false);
			this._textEditorsSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._textEditorsSplitContainer)).EndInit();
			this._textEditorsSplitContainer.ResumeLayout(false);
			this._buttonPanel.ResumeLayout(false);
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
		private System.Windows.Forms.Label _sqlTextLabel;
		private System.Windows.Forms.Panel _buttonPanel;
		private System.Windows.Forms.Button _sendSqlToClipboard;
		private System.Windows.Forms.Button _getFromClipboardButton;
		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.Label _placeholdersLabel;
	}
}

