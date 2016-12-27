namespace View
{
    partial class ObjectControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.personDataGroupBox = new System.Windows.Forms.GroupBox();
            this.countDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.personSurnameTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.typeOfRateLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.dayAmountLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.paidPerHourLabel = new System.Windows.Forms.Label();
            this.hourAmountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.personDataGroupBox.SuspendLayout();
            this.countDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personDataGroupBox
            // 
            this.personDataGroupBox.Controls.Add(this.personNameTextBox);
            this.personDataGroupBox.Controls.Add(this.personSurnameTextBox);
            this.personDataGroupBox.Controls.Add(this.nameLabel);
            this.personDataGroupBox.Controls.Add(this.SurnameLabel);
            this.personDataGroupBox.Location = new System.Drawing.Point(3, 3);
            this.personDataGroupBox.Name = "personDataGroupBox";
            this.personDataGroupBox.Size = new System.Drawing.Size(315, 78);
            this.personDataGroupBox.TabIndex = 0;
            this.personDataGroupBox.TabStop = false;
            this.personDataGroupBox.Text = "Person Data";
            // 
            // countDataGroupBox
            // 
            this.countDataGroupBox.Controls.Add(this.textBox5);
            this.countDataGroupBox.Controls.Add(this.textBox4);
            this.countDataGroupBox.Controls.Add(this.textBox3);
            this.countDataGroupBox.Controls.Add(this.textBox2);
            this.countDataGroupBox.Controls.Add(this.radioButton3);
            this.countDataGroupBox.Controls.Add(this.radioButton2);
            this.countDataGroupBox.Controls.Add(this.radioButton1);
            this.countDataGroupBox.Controls.Add(this.textBox1);
            this.countDataGroupBox.Controls.Add(this.hourAmountLabel);
            this.countDataGroupBox.Controls.Add(this.paidPerHourLabel);
            this.countDataGroupBox.Controls.Add(this.rateLabel);
            this.countDataGroupBox.Controls.Add(this.dayAmountLabel);
            this.countDataGroupBox.Controls.Add(this.salaryLabel);
            this.countDataGroupBox.Controls.Add(this.typeOfRateLabel);
            this.countDataGroupBox.Location = new System.Drawing.Point(3, 87);
            this.countDataGroupBox.Name = "countDataGroupBox";
            this.countDataGroupBox.Size = new System.Drawing.Size(315, 188);
            this.countDataGroupBox.TabIndex = 1;
            this.countDataGroupBox.TabStop = false;
            this.countDataGroupBox.Text = "Data for count";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(19, 22);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // personSurnameTextBox
            // 
            this.personSurnameTextBox.Location = new System.Drawing.Point(118, 19);
            this.personSurnameTextBox.Name = "personSurnameTextBox";
            this.personSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personSurnameTextBox.TabIndex = 2;
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.Location = new System.Drawing.Point(118, 45);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personNameTextBox.TabIndex = 3;
            // 
            // typeOfRateLabel
            // 
            this.typeOfRateLabel.AutoSize = true;
            this.typeOfRateLabel.Location = new System.Drawing.Point(19, 21);
            this.typeOfRateLabel.Name = "typeOfRateLabel";
            this.typeOfRateLabel.Size = new System.Drawing.Size(64, 13);
            this.typeOfRateLabel.TabIndex = 0;
            this.typeOfRateLabel.Text = "Type of rate";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(19, 45);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Salary";
            // 
            // dayAmountLabel
            // 
            this.dayAmountLabel.AutoSize = true;
            this.dayAmountLabel.Location = new System.Drawing.Point(19, 71);
            this.dayAmountLabel.Name = "dayAmountLabel";
            this.dayAmountLabel.Size = new System.Drawing.Size(63, 13);
            this.dayAmountLabel.TabIndex = 2;
            this.dayAmountLabel.Text = "Amount day";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(19, 97);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 3;
            this.rateLabel.Text = "Rate";
            // 
            // paidPerHourLabel
            // 
            this.paidPerHourLabel.AutoSize = true;
            this.paidPerHourLabel.Location = new System.Drawing.Point(19, 123);
            this.paidPerHourLabel.Name = "paidPerHourLabel";
            this.paidPerHourLabel.Size = new System.Drawing.Size(70, 13);
            this.paidPerHourLabel.TabIndex = 4;
            this.paidPerHourLabel.Text = "Paid per hour";
            // 
            // hourAmountLabel
            // 
            this.hourAmountLabel.AutoSize = true;
            this.hourAmountLabel.Location = new System.Drawing.Point(19, 149);
            this.hourAmountLabel.Name = "hourAmountLabel";
            this.hourAmountLabel.Size = new System.Drawing.Size(68, 13);
            this.hourAmountLabel.TabIndex = 5;
            this.hourAmountLabel.Text = "Hour amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(118, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fixed";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Variable";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(243, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hourly";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 20);
            this.textBox5.TabIndex = 13;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countDataGroupBox);
            this.Controls.Add(this.personDataGroupBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(321, 280);
            this.personDataGroupBox.ResumeLayout(false);
            this.personDataGroupBox.PerformLayout();
            this.countDataGroupBox.ResumeLayout(false);
            this.countDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personDataGroupBox;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.TextBox personSurnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.GroupBox countDataGroupBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label hourAmountLabel;
        private System.Windows.Forms.Label paidPerHourLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label dayAmountLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label typeOfRateLabel;
    }
}
