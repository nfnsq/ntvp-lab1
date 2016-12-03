namespace View
{
    partial class SalaryRateForm
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
            this.buttonRemovePerson = new System.Windows.Forms.Button();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.dataGridViewObject = new System.Windows.Forms.DataGridView();
            this.PersonSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxObject
            // 
            this.groupBoxObject.Controls.Add(this.buttonRemovePerson);
            this.groupBoxObject.Controls.Add(this.buttonAddPerson);
            this.groupBoxObject.Controls.Add(this.dataGridViewObject);
            this.groupBoxObject.Location = new System.Drawing.Point(12, 27);
            this.groupBoxObject.Name = "groupBoxObject";
            this.groupBoxObject.Size = new System.Drawing.Size(310, 171);
            this.groupBoxObject.TabIndex = 0;
            this.groupBoxObject.TabStop = false;
            this.groupBoxObject.Text = "Objects";
            // 
            // buttonRemovePerson
            // 
            this.buttonRemovePerson.Location = new System.Drawing.Point(210, 136);
            this.buttonRemovePerson.Name = "buttonRemovePerson";
            this.buttonRemovePerson.Size = new System.Drawing.Size(94, 26);
            this.buttonRemovePerson.TabIndex = 2;
            this.buttonRemovePerson.Text = "Remove Person";
            this.buttonRemovePerson.UseVisualStyleBackColor = true;
            this.buttonRemovePerson.Click += new System.EventHandler(this.buttonRemovePerson_Click);
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Location = new System.Drawing.Point(110, 136);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(94, 26);
            this.buttonAddPerson.TabIndex = 1;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // dataGridViewObject
            // 
            this.dataGridViewObject.AllowUserToAddRows = false;
            this.dataGridViewObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewObject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonSurname,
            this.PersonName,
            this.PayAmount});
            this.dataGridViewObject.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewObject.Name = "dataGridViewObject";
            this.dataGridViewObject.ReadOnly = true;
            this.dataGridViewObject.Size = new System.Drawing.Size(298, 111);
            this.dataGridViewObject.TabIndex = 0;
            // 
            // PersonSurname
            // 
            this.PersonSurname.HeaderText = "Surname";
            this.PersonSurname.Name = "PersonSurname";
            this.PersonSurname.ReadOnly = true;
            this.PersonSurname.Width = 70;
            // 
            // PersonName
            // 
            this.PersonName.HeaderText = "Name";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 70;
            // 
            // PayAmount
            // 
            this.PayAmount.HeaderText = "Pay Amount";
            this.PayAmount.Name = "PayAmount";
            this.PayAmount.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SalaryRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBoxObject);
            this.Controls.Add(this.menuStrip1);
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

        private System.Windows.Forms.GroupBox groupBoxObject;
        private System.Windows.Forms.Button buttonRemovePerson;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayAmount;
        public System.Windows.Forms.DataGridView dataGridViewObject;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

