namespace DocxSearcher
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.rBtnRegex = new System.Windows.Forms.RadioButton();
            this.rBtnText = new System.Windows.Forms.RadioButton();
            this.resultListView = new System.Windows.Forms.ListView();
            this.resultColumn2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultColumn3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultColumn4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearchDirectory = new System.Windows.Forms.GroupBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSearchDirectory = new System.Windows.Forms.Button();
            this.cBoxUseSubdirectories = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.resultColumn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxFind.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxSearchDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(8, 48);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(97, 17);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Find in DOCX:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(8, 68);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // cBoxCaseSensitive
            // 
            this.cBoxCaseSensitive.AutoSize = true;
            this.cBoxCaseSensitive.Location = new System.Drawing.Point(8, 23);
            this.cBoxCaseSensitive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxCaseSensitive.Name = "cBoxCaseSensitive";
            this.cBoxCaseSensitive.Size = new System.Drawing.Size(168, 21);
            this.cBoxCaseSensitive.TabIndex = 3;
            this.cBoxCaseSensitive.Text = "Search case sensitive";
            this.cBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFind.Controls.Add(this.rBtnRegex);
            this.groupBoxFind.Controls.Add(this.rBtnText);
            this.groupBoxFind.Controls.Add(this.cBoxCaseSensitive);
            this.groupBoxFind.Controls.Add(this.txtSearch);
            this.groupBoxFind.Controls.Add(this.lb1);
            this.groupBoxFind.Location = new System.Drawing.Point(8, 139);
            this.groupBoxFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFind.Size = new System.Drawing.Size(314, 167);
            this.groupBoxFind.TabIndex = 1;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "Find";
            // 
            // rBtnRegex
            // 
            this.rBtnRegex.AutoSize = true;
            this.rBtnRegex.Location = new System.Drawing.Point(12, 128);
            this.rBtnRegex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnRegex.Name = "rBtnRegex";
            this.rBtnRegex.Size = new System.Drawing.Size(151, 21);
            this.rBtnRegex.TabIndex = 9;
            this.rBtnRegex.Text = "Regular expression";
            this.rBtnRegex.UseVisualStyleBackColor = true;
            // 
            // rBtnText
            // 
            this.rBtnText.AutoSize = true;
            this.rBtnText.Checked = true;
            this.rBtnText.Location = new System.Drawing.Point(12, 100);
            this.rBtnText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnText.Name = "rBtnText";
            this.rBtnText.Size = new System.Drawing.Size(56, 21);
            this.rBtnText.TabIndex = 7;
            this.rBtnText.TabStop = true;
            this.rBtnText.Text = "Text";
            this.rBtnText.UseVisualStyleBackColor = true;
            // 
            // resultListView
            // 
            this.resultListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.resultListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resultColumn1,
            this.resultColumn2,
            this.resultColumn3,
            this.resultColumn4});
            this.resultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultListView.FullRowSelect = true;
            this.resultListView.Location = new System.Drawing.Point(0, 0);
            this.resultListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultListView.MultiSelect = false;
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(565, 389);
            this.resultListView.TabIndex = 8;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.ItemActivate += new System.EventHandler(this.resultListView_ItemActivate);
            this.resultListView.SelectedIndexChanged += new System.EventHandler(this.resultListView_SelectedIndexChanged);
            // 
            // resultColumn2
            // 
            this.resultColumn2.Text = "File Name";
            this.resultColumn2.Width = 100;
            // 
            // resultColumn3
            // 
            this.resultColumn3.Text = "Size [KB]";
            // 
            // resultColumn4
            // 
            this.resultColumn4.Text = "File Path";
            this.resultColumn4.Width = 235;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSearchDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxFind);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultListView);
            this.splitContainer1.Size = new System.Drawing.Size(900, 389);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBoxSearchDirectory
            // 
            this.groupBoxSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchDirectory.Controls.Add(this.txtDirectory);
            this.groupBoxSearchDirectory.Controls.Add(this.btnSearchDirectory);
            this.groupBoxSearchDirectory.Controls.Add(this.cBoxUseSubdirectories);
            this.groupBoxSearchDirectory.Location = new System.Drawing.Point(8, 4);
            this.groupBoxSearchDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSearchDirectory.Name = "groupBoxSearchDirectory";
            this.groupBoxSearchDirectory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSearchDirectory.Size = new System.Drawing.Size(314, 128);
            this.groupBoxSearchDirectory.TabIndex = 8;
            this.groupBoxSearchDirectory.TabStop = false;
            this.groupBoxSearchDirectory.Text = "Search Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(8, 62);
            this.txtDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(344, 22);
            this.txtDirectory.TabIndex = 4;
            // 
            // btnSearchDirectory
            // 
            this.btnSearchDirectory.Location = new System.Drawing.Point(8, 23);
            this.btnSearchDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchDirectory.Name = "btnSearchDirectory";
            this.btnSearchDirectory.Size = new System.Drawing.Size(133, 31);
            this.btnSearchDirectory.TabIndex = 3;
            this.btnSearchDirectory.Text = "Browse folder...";
            this.btnSearchDirectory.UseVisualStyleBackColor = true;
            this.btnSearchDirectory.Click += new System.EventHandler(this.btnSearchDirectory_Click);
            // 
            // cBoxUseSubdirectories
            // 
            this.cBoxUseSubdirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxUseSubdirectories.AutoSize = true;
            this.cBoxUseSubdirectories.Location = new System.Drawing.Point(8, 94);
            this.cBoxUseSubdirectories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxUseSubdirectories.Name = "cBoxUseSubdirectories";
            this.cBoxUseSubdirectories.Size = new System.Drawing.Size(187, 21);
            this.cBoxUseSubdirectories.TabIndex = 2;
            this.cBoxUseSubdirectories.Text = "Search in subdirectories ";
            this.cBoxUseSubdirectories.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(8, 314);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(314, 71);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search DOCX";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // resultColumn1
            // 
            this.resultColumn1.Text = "Number";
            this.resultColumn1.Width = 108;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 389);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Docx Searcher";
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxSearchDirectory.ResumeLayout(false);
            this.groupBoxSearchDirectory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cBoxCaseSensitive;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader resultColumn2;
        private System.Windows.Forms.ColumnHeader resultColumn3;
        private System.Windows.Forms.ColumnHeader resultColumn4;
        private System.Windows.Forms.RadioButton rBtnRegex;
        private System.Windows.Forms.RadioButton rBtnText;
        private System.Windows.Forms.GroupBox groupBoxSearchDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSearchDirectory;
        private System.Windows.Forms.CheckBox cBoxUseSubdirectories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader resultColumn1;
    }
}

