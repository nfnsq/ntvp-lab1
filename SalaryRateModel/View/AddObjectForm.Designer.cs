namespace View
{
    partial class AddObjectForm
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.buttonRandomData = new System.Windows.Forms.Button();
            this.radioButtonFixed = new System.Windows.Forms.RadioButton();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHourAmount = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPaidPerHour = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAmountDay = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSalary = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.hourAmountLabel = new System.Windows.Forms.Label();
            this.paidPerHourLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.amountDayLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.typeOfRateLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.radioButtonHourly = new System.Windows.Forms.RadioButton();
            this.radioButtonVariable = new System.Windows.Forms.RadioButton();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.buttonRandomData);
            this.groupBoxData.Controls.Add(this.radioButtonFixed);
            this.groupBoxData.Controls.Add(this.maskedTextBox3);
            this.groupBoxData.Controls.Add(this.maskedTextBox2);
            this.groupBoxData.Controls.Add(this.maskedTextBox1);
            this.groupBoxData.Controls.Add(this.maskedTextBoxHourAmount);
            this.groupBoxData.Controls.Add(this.maskedTextBoxPaidPerHour);
            this.groupBoxData.Controls.Add(this.maskedTextBoxRate);
            this.groupBoxData.Controls.Add(this.maskedTextBoxAmountDay);
            this.groupBoxData.Controls.Add(this.maskedTextBoxSalary);
            this.groupBoxData.Controls.Add(this.buttonCancel);
            this.groupBoxData.Controls.Add(this.buttonOK);
            this.groupBoxData.Controls.Add(this.hourAmountLabel);
            this.groupBoxData.Controls.Add(this.paidPerHourLabel);
            this.groupBoxData.Controls.Add(this.rateLabel);
            this.groupBoxData.Controls.Add(this.amountDayLabel);
            this.groupBoxData.Controls.Add(this.salaryLabel);
            this.groupBoxData.Controls.Add(this.typeOfRateLabel);
            this.groupBoxData.Controls.Add(this.secondNameLabel);
            this.groupBoxData.Controls.Add(this.nameLabel);
            this.groupBoxData.Controls.Add(this.surnameLabel);
            this.groupBoxData.Controls.Add(this.radioButtonHourly);
            this.groupBoxData.Controls.Add(this.radioButtonVariable);
            this.groupBoxData.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(310, 337);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Data";
            // 
            // buttonRandomData
            // 
            this.buttonRandomData.Location = new System.Drawing.Point(166, 279);
            this.buttonRandomData.Name = "buttonRandomData";
            this.buttonRandomData.Size = new System.Drawing.Size(126, 23);
            this.buttonRandomData.TabIndex = 33;
            this.buttonRandomData.Text = "Create Random Data";
            this.buttonRandomData.UseVisualStyleBackColor = true;
            this.buttonRandomData.Click += new System.EventHandler(this.buttonRandomData_Click);
            // 
            // radioButtonFixed
            // 
            this.radioButtonFixed.AutoSize = true;
            this.radioButtonFixed.Location = new System.Drawing.Point(112, 97);
            this.radioButtonFixed.Name = "radioButtonFixed";
            this.radioButtonFixed.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFixed.TabIndex = 0;
            this.radioButtonFixed.TabStop = true;
            this.radioButtonFixed.Text = "Fixed";
            this.radioButtonFixed.UseVisualStyleBackColor = true;
            this.radioButtonFixed.CheckedChanged += new System.EventHandler(this.radioButtonFixed_CheckedChanged);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(112, 71);
            this.maskedTextBox3.Mask = ">?<?????????";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = ' ';
            this.maskedTextBox3.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox3.TabIndex = 32;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(112, 45);
            this.maskedTextBox2.Mask = ">?<?????????";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = ' ';
            this.maskedTextBox2.Size = new System.Drawing.Size(69, 20);
            this.maskedTextBox2.TabIndex = 31;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 19);
            this.maskedTextBox1.Mask = ">?<?????????????";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // maskedTextBoxHourAmount
            // 
            this.maskedTextBoxHourAmount.Location = new System.Drawing.Point(112, 224);
            this.maskedTextBoxHourAmount.Mask = "0000";
            this.maskedTextBoxHourAmount.Name = "maskedTextBoxHourAmount";
            this.maskedTextBoxHourAmount.PromptChar = ' ';
            this.maskedTextBoxHourAmount.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxHourAmount.TabIndex = 29;
            this.maskedTextBoxHourAmount.Visible = false;
            // 
            // maskedTextBoxPaidPerHour
            // 
            this.maskedTextBoxPaidPerHour.Location = new System.Drawing.Point(112, 198);
            this.maskedTextBoxPaidPerHour.Mask = "0000";
            this.maskedTextBoxPaidPerHour.Name = "maskedTextBoxPaidPerHour";
            this.maskedTextBoxPaidPerHour.PromptChar = ' ';
            this.maskedTextBoxPaidPerHour.Size = new System.Drawing.Size(34, 20);
            this.maskedTextBoxPaidPerHour.TabIndex = 28;
            this.maskedTextBoxPaidPerHour.Visible = false;
            // 
            // maskedTextBoxRate
            // 
            this.maskedTextBoxRate.Location = new System.Drawing.Point(112, 172);
            this.maskedTextBoxRate.Mask = "0.00";
            this.maskedTextBoxRate.Name = "maskedTextBoxRate";
            this.maskedTextBoxRate.PromptChar = ' ';
            this.maskedTextBoxRate.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxRate.TabIndex = 27;
            this.maskedTextBoxRate.Visible = false;
            // 
            // maskedTextBoxAmountDay
            // 
            this.maskedTextBoxAmountDay.Location = new System.Drawing.Point(112, 146);
            this.maskedTextBoxAmountDay.Mask = "000";
            this.maskedTextBoxAmountDay.Name = "maskedTextBoxAmountDay";
            this.maskedTextBoxAmountDay.PromptChar = ' ';
            this.maskedTextBoxAmountDay.Size = new System.Drawing.Size(26, 20);
            this.maskedTextBoxAmountDay.TabIndex = 26;
            this.maskedTextBoxAmountDay.Visible = false;
            // 
            // maskedTextBoxSalary
            // 
            this.maskedTextBoxSalary.Location = new System.Drawing.Point(112, 120);
            this.maskedTextBoxSalary.Mask = "000000";
            this.maskedTextBoxSalary.Name = "maskedTextBoxSalary";
            this.maskedTextBoxSalary.PromptChar = ' ';
            this.maskedTextBoxSalary.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxSalary.TabIndex = 25;
            this.maskedTextBoxSalary.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(229, 308);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(148, 308);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // hourAmountLabel
            // 
            this.hourAmountLabel.AutoSize = true;
            this.hourAmountLabel.Location = new System.Drawing.Point(14, 227);
            this.hourAmountLabel.Name = "hourAmountLabel";
            this.hourAmountLabel.Size = new System.Drawing.Size(68, 13);
            this.hourAmountLabel.TabIndex = 16;
            this.hourAmountLabel.Text = "Hour amount";
            this.hourAmountLabel.Visible = false;
            // 
            // paidPerHourLabel
            // 
            this.paidPerHourLabel.AutoSize = true;
            this.paidPerHourLabel.Location = new System.Drawing.Point(14, 201);
            this.paidPerHourLabel.Name = "paidPerHourLabel";
            this.paidPerHourLabel.Size = new System.Drawing.Size(70, 13);
            this.paidPerHourLabel.TabIndex = 15;
            this.paidPerHourLabel.Text = "Paid per hour";
            this.paidPerHourLabel.Visible = false;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(14, 175);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 14;
            this.rateLabel.Text = "Rate";
            this.rateLabel.Visible = false;
            // 
            // amountDayLabel
            // 
            this.amountDayLabel.AutoSize = true;
            this.amountDayLabel.Location = new System.Drawing.Point(14, 149);
            this.amountDayLabel.Name = "amountDayLabel";
            this.amountDayLabel.Size = new System.Drawing.Size(65, 13);
            this.amountDayLabel.TabIndex = 13;
            this.amountDayLabel.Text = "Amount Day";
            this.amountDayLabel.Visible = false;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(14, 123);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 12;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.Visible = false;
            // 
            // typeOfRateLabel
            // 
            this.typeOfRateLabel.AutoSize = true;
            this.typeOfRateLabel.Location = new System.Drawing.Point(14, 99);
            this.typeOfRateLabel.Name = "typeOfRateLabel";
            this.typeOfRateLabel.Size = new System.Drawing.Size(64, 13);
            this.typeOfRateLabel.TabIndex = 9;
            this.typeOfRateLabel.Text = "Type of rate";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(14, 74);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(75, 13);
            this.secondNameLabel.TabIndex = 8;
            this.secondNameLabel.Text = "Second Name";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(14, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(14, 22);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "Surname";
            // 
            // radioButtonHourly
            // 
            this.radioButtonHourly.AutoSize = true;
            this.radioButtonHourly.Location = new System.Drawing.Point(237, 97);
            this.radioButtonHourly.Name = "radioButtonHourly";
            this.radioButtonHourly.Size = new System.Drawing.Size(55, 17);
            this.radioButtonHourly.TabIndex = 2;
            this.radioButtonHourly.TabStop = true;
            this.radioButtonHourly.Text = "Houlry";
            this.radioButtonHourly.UseVisualStyleBackColor = true;
            this.radioButtonHourly.CheckedChanged += new System.EventHandler(this.radioButtonHourly_CheckedChanged);
            // 
            // radioButtonVariable
            // 
            this.radioButtonVariable.AutoSize = true;
            this.radioButtonVariable.Location = new System.Drawing.Point(168, 97);
            this.radioButtonVariable.Name = "radioButtonVariable";
            this.radioButtonVariable.Size = new System.Drawing.Size(63, 17);
            this.radioButtonVariable.TabIndex = 1;
            this.radioButtonVariable.TabStop = true;
            this.radioButtonVariable.Text = "Variable";
            this.radioButtonVariable.UseVisualStyleBackColor = true;
            this.radioButtonVariable.CheckedChanged += new System.EventHandler(this.radioButtonVariable_CheckedChanged);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBoxData);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeOfRateLabel;
        private System.Windows.Forms.Label amountDayLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label hourAmountLabel;
        private System.Windows.Forms.Label paidPerHourLabel;
        private System.Windows.Forms.Label rateLabel;
        public System.Windows.Forms.RadioButton radioButtonHourly;
        public System.Windows.Forms.RadioButton radioButtonVariable;
        public System.Windows.Forms.RadioButton radioButtonFixed;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxHourAmount;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPaidPerHour;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxRate;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxAmountDay;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxSalary;
        public System.Windows.Forms.MaskedTextBox maskedTextBox3;
        public System.Windows.Forms.MaskedTextBox maskedTextBox2;
        public System.Windows.Forms.MaskedTextBox maskedTextBox1;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRandomData;
    }
}