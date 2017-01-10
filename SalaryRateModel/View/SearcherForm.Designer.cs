namespace View
{
    partial class SearcherForm
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchData = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.Search.SuspendLayout();
            this.Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.buttonSearch);
            this.Search.Controls.Add(this.textBoxSearchData);
            this.Search.Location = new System.Drawing.Point(12, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(372, 64);
            this.Search.TabIndex = 1;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(291, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxSearchData
            // 
            this.textBoxSearchData.Location = new System.Drawing.Point(15, 30);
            this.textBoxSearchData.MaxLength = 10;
            this.textBoxSearchData.Name = "textBoxSearchData";
            this.textBoxSearchData.Size = new System.Drawing.Size(259, 20);
            this.textBoxSearchData.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.dataGridViewResult);
            this.Results.Location = new System.Drawing.Point(12, 82);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(372, 156);
            this.Results.TabIndex = 2;
            this.Results.TabStop = false;
            this.Results.Text = "Result";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(360, 131);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // SearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 250);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Search);
            this.Name = "SearcherForm";
            this.Text = "SearchForm";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchData;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.DataGridView dataGridViewResult;

    }
}