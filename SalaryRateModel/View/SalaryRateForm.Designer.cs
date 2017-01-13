namespace View
{
    public partial class SalaryRateForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxObject = new System.Windows.Forms.GroupBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.buttonRemovePerson = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.dataGridViewObject = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectControlView = new View.ObjectControl();
            this.groupBoxObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxObject
            // 
            this.groupBoxObject.Controls.Add(this.modifyButton);
            this.groupBoxObject.Controls.Add(this.buttonRemovePerson);
            this.groupBoxObject.Controls.Add(this.buttonAddPerson);
            this.groupBoxObject.Controls.Add(this.dataGridViewObject);
            this.groupBoxObject.Location = new System.Drawing.Point(12, 27);
            this.groupBoxObject.Name = "groupBoxObject";
            this.groupBoxObject.Size = new System.Drawing.Size(319, 171);
            this.groupBoxObject.TabIndex = 0;
            this.groupBoxObject.TabStop = false;
            this.groupBoxObject.Text = "Objects";
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(18, 136);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(94, 25);
            this.modifyButton.TabIndex = 3;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // buttonRemovePerson
            // 
            this.buttonRemovePerson.Location = new System.Drawing.Point(218, 136);
            this.buttonRemovePerson.Name = "buttonRemovePerson";
            this.buttonRemovePerson.Size = new System.Drawing.Size(94, 26);
            this.buttonRemovePerson.TabIndex = 2;
            this.buttonRemovePerson.Text = "Remove Person";
            this.buttonRemovePerson.UseVisualStyleBackColor = true;
            this.buttonRemovePerson.Click += new System.EventHandler(this.ButtonRemovePerson_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(118, 136);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(94, 26);
            this.buttonAddPerson.TabIndex = 1;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.ButtonAddPerson_Click);
            // 
            // dataGridViewObject
            // 
            this.dataGridViewObject.AllowUserToAddRows = false;
            this.dataGridViewObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObject.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewObject.Name = "dataGridViewObject";
            this.dataGridViewObject.ReadOnly = true;
            this.dataGridViewObject.Size = new System.Drawing.Size(300, 111);
            this.dataGridViewObject.TabIndex = 0;
            this.dataGridViewObject.SelectionChanged += new System.EventHandler(this.dataGridViewObject_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // objectControlView
            // 
            this.objectControlView.Location = new System.Drawing.Point(12, 204);
            this.objectControlView.Name = "objectControlView";
            this.objectControlView.Object = null;
            this.objectControlView.ReadOnly = false;
            this.objectControlView.Size = new System.Drawing.Size(327, 280);
            this.objectControlView.TabIndex = 2;
            // 
            // SalaryRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 488);
            this.Controls.Add(this.objectControlView);
            this.Controls.Add(this.groupBoxObject);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalaryRateForm";
            this.Text = "SalaryRateForm";
            this.groupBoxObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemovePerson;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewObject;
        private System.Windows.Forms.GroupBox groupBoxObject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ObjectControl objectControlView;
        private System.Windows.Forms.Button modifyButton;
    }
}

