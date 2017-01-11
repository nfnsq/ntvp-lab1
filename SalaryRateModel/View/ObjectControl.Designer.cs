namespace View
{
    public partial class ObjectControl
    {
        /// <summary> 
        /// “ребуетс€ переменна€ конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// ќсвободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управл€емый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region  од, автоматически созданный конструктором компонентов

        /// <summary> 
        /// ќб€зательный метод дл€ поддержки конструктора - не измен€йте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.personDataGroupBox = new System.Windows.Forms.GroupBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.personSurnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.countDataGroupBox = new System.Windows.Forms.GroupBox();
            this.hourAmountTextBox = new System.Windows.Forms.TextBox();
            this.paidPerHourTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.amountDayTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.variableRadioButton = new System.Windows.Forms.RadioButton();
            this.fixedRadioButton = new System.Windows.Forms.RadioButton();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.hourAmountLabel = new System.Windows.Forms.Label();
            this.paidPerHourLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.dayAmountLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.typeOfRateLabel = new System.Windows.Forms.Label();
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
            // personNameTextBox
            // 
            this.personNameTextBox.Location = new System.Drawing.Point(118, 45);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personNameTextBox.TabIndex = 3;
            // 
            // personSurnameTextBox
            // 
            this.personSurnameTextBox.Location = new System.Drawing.Point(118, 19);
            this.personSurnameTextBox.Name = "personSurnameTextBox";
            this.personSurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.personSurnameTextBox.TabIndex = 2;
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
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(19, 22);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname";
            // 
            // countDataGroupBox
            // 
            this.countDataGroupBox.Controls.Add(this.hourAmountTextBox);
            this.countDataGroupBox.Controls.Add(this.paidPerHourTextBox);
            this.countDataGroupBox.Controls.Add(this.rateTextBox);
            this.countDataGroupBox.Controls.Add(this.amountDayTextBox);
            this.countDataGroupBox.Controls.Add(this.hourlyRadioButton);
            this.countDataGroupBox.Controls.Add(this.variableRadioButton);
            this.countDataGroupBox.Controls.Add(this.fixedRadioButton);
            this.countDataGroupBox.Controls.Add(this.salaryTextBox);
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
            // hourAmountTextBox
            // 
            this.hourAmountTextBox.Location = new System.Drawing.Point(118, 146);
            this.hourAmountTextBox.Name = "hourAmountTextBox";
            this.hourAmountTextBox.Size = new System.Drawing.Size(35, 20);
            this.hourAmountTextBox.TabIndex = 13;
            this.hourAmountTextBox.Visible = false;
            // 
            // paidPerHourTextBox
            // 
            this.paidPerHourTextBox.Location = new System.Drawing.Point(118, 120);
            this.paidPerHourTextBox.Name = "paidPerHourTextBox";
            this.paidPerHourTextBox.Size = new System.Drawing.Size(50, 20);
            this.paidPerHourTextBox.TabIndex = 12;
            this.paidPerHourTextBox.Visible = false;
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(118, 94);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(35, 20);
            this.rateTextBox.TabIndex = 11;
            this.rateTextBox.Visible = false;
            // 
            // amountDayTextBox
            // 
            this.amountDayTextBox.Location = new System.Drawing.Point(118, 68);
            this.amountDayTextBox.Name = "amountDayTextBox";
            this.amountDayTextBox.Size = new System.Drawing.Size(50, 20);
            this.amountDayTextBox.TabIndex = 10;
            this.amountDayTextBox.Visible = false;
            // 
            // hourlyRadioButton
            // 
            this.hourlyRadioButton.AutoSize = true;
            this.hourlyRadioButton.Location = new System.Drawing.Point(243, 19);
            this.hourlyRadioButton.Name = "hourlyRadioButton";
            this.hourlyRadioButton.Size = new System.Drawing.Size(55, 17);
            this.hourlyRadioButton.TabIndex = 9;
            this.hourlyRadioButton.TabStop = true;
            this.hourlyRadioButton.Text = "Hourly";
            this.hourlyRadioButton.UseVisualStyleBackColor = true;
            this.hourlyRadioButton.CheckedChanged += new System.EventHandler(this.hourlyRadioButton_CheckedChanged);
            // 
            // variableRadioButton
            // 
            this.variableRadioButton.AutoSize = true;
            this.variableRadioButton.Location = new System.Drawing.Point(174, 19);
            this.variableRadioButton.Name = "variableRadioButton";
            this.variableRadioButton.Size = new System.Drawing.Size(63, 17);
            this.variableRadioButton.TabIndex = 8;
            this.variableRadioButton.TabStop = true;
            this.variableRadioButton.Text = "Variable";
            this.variableRadioButton.UseVisualStyleBackColor = true;
            this.variableRadioButton.CheckedChanged += new System.EventHandler(this.variableRadioButton_CheckedChanged);
            // 
            // fixedRadioButton
            // 
            this.fixedRadioButton.AutoSize = true;
            this.fixedRadioButton.Location = new System.Drawing.Point(118, 19);
            this.fixedRadioButton.Name = "fixedRadioButton";
            this.fixedRadioButton.Size = new System.Drawing.Size(50, 17);
            this.fixedRadioButton.TabIndex = 7;
            this.fixedRadioButton.TabStop = true;
            this.fixedRadioButton.Text = "Fixed";
            this.fixedRadioButton.UseVisualStyleBackColor = true;
            this.fixedRadioButton.CheckedChanged += new System.EventHandler(this.fixedRadioButton_CheckedChanged);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(118, 42);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(50, 20);
            this.salaryTextBox.TabIndex = 6;
            this.salaryTextBox.Visible = false;
            this.salaryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DataValidating);
            // 
            // hourAmountLabel
            // 
            this.hourAmountLabel.AutoSize = true;
            this.hourAmountLabel.Location = new System.Drawing.Point(19, 149);
            this.hourAmountLabel.Name = "hourAmountLabel";
            this.hourAmountLabel.Size = new System.Drawing.Size(68, 13);
            this.hourAmountLabel.TabIndex = 5;
            this.hourAmountLabel.Text = "Hour amount";
            this.hourAmountLabel.Visible = false;
            // 
            // paidPerHourLabel
            // 
            this.paidPerHourLabel.AutoSize = true;
            this.paidPerHourLabel.Location = new System.Drawing.Point(19, 123);
            this.paidPerHourLabel.Name = "paidPerHourLabel";
            this.paidPerHourLabel.Size = new System.Drawing.Size(70, 13);
            this.paidPerHourLabel.TabIndex = 4;
            this.paidPerHourLabel.Text = "Paid per hour";
            this.paidPerHourLabel.Visible = false;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(19, 97);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 3;
            this.rateLabel.Text = "Rate";
            this.rateLabel.Visible = false;
            // 
            // dayAmountLabel
            // 
            this.dayAmountLabel.AutoSize = true;
            this.dayAmountLabel.Location = new System.Drawing.Point(19, 71);
            this.dayAmountLabel.Name = "dayAmountLabel";
            this.dayAmountLabel.Size = new System.Drawing.Size(63, 13);
            this.dayAmountLabel.TabIndex = 2;
            this.dayAmountLabel.Text = "Amount day";
            this.dayAmountLabel.Visible = false;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(19, 45);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.Visible = false;
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
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.countDataGroupBox);
            this.Controls.Add(this.personDataGroupBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(327, 280);
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
        private System.Windows.Forms.TextBox hourAmountTextBox;
        private System.Windows.Forms.TextBox paidPerHourTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.TextBox amountDayTextBox;
        private System.Windows.Forms.RadioButton hourlyRadioButton;
        private System.Windows.Forms.RadioButton variableRadioButton;
        private System.Windows.Forms.RadioButton fixedRadioButton;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Label hourAmountLabel;
        private System.Windows.Forms.Label paidPerHourLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label dayAmountLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label typeOfRateLabel;
    }
}
