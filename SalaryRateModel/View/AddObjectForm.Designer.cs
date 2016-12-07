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
            this.groupBoxPersonData = new System.Windows.Forms.GroupBox();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.textBoxPersonSurname = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.buttonRandomData = new System.Windows.Forms.Button();
            this.radioButtonFixed = new System.Windows.Forms.RadioButton();
            this.textBoxHourAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaidPerHour = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxAmountDay = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.hourAmountLabel = new System.Windows.Forms.Label();
            this.paidPerHourLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.amountDayLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.typeOfRateLabel = new System.Windows.Forms.Label();
            this.radioButtonHourly = new System.Windows.Forms.RadioButton();
            this.radioButtonVariable = new System.Windows.Forms.RadioButton();
            this.groupBoxCountData = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonData.SuspendLayout();
            this.groupBoxCountData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonData
            // 
            this.groupBoxPersonData.Controls.Add(this.textBoxPersonName);
            this.groupBoxPersonData.Controls.Add(this.textBoxPersonSurname);
            this.groupBoxPersonData.Controls.Add(this.nameLabel);
            this.groupBoxPersonData.Controls.Add(this.surnameLabel);
            this.groupBoxPersonData.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxPersonData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonData.Name = "groupBoxPersonData";
            this.groupBoxPersonData.Size = new System.Drawing.Size(310, 73);
            this.groupBoxPersonData.TabIndex = 0;
            this.groupBoxPersonData.TabStop = false;
            this.groupBoxPersonData.Text = "Person data";
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(112, 45);
            this.textBoxPersonName.MaxLength = 15;
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPersonName.Size = new System.Drawing.Size(109, 20);
            this.textBoxPersonName.TabIndex = 31;
            this.textBoxPersonName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPersonName_Validating);
            // 
            // textBoxPersonSurname
            // 
            this.textBoxPersonSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPersonSurname.Location = new System.Drawing.Point(112, 19);
            this.textBoxPersonSurname.MaxLength = 15;
            this.textBoxPersonSurname.Name = "textBoxPersonSurname";
            this.textBoxPersonSurname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPersonSurname.Size = new System.Drawing.Size(109, 20);
            this.textBoxPersonSurname.TabIndex = 30;
            this.textBoxPersonSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPersonSurname_Validating);
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
            // buttonRandomData
            // 
            this.buttonRandomData.Location = new System.Drawing.Point(12, 326);
            this.buttonRandomData.Name = "buttonRandomData";
            this.buttonRandomData.Size = new System.Drawing.Size(126, 23);
            this.buttonRandomData.TabIndex = 33;
            this.buttonRandomData.Text = "Create Random Data";
            this.buttonRandomData.UseVisualStyleBackColor = true;
            this.buttonRandomData.Click += new System.EventHandler(this.ButtonRandomData_Click);
            // 
            // radioButtonFixed
            // 
            this.radioButtonFixed.AutoSize = true;
            this.radioButtonFixed.Location = new System.Drawing.Point(112, 26);
            this.radioButtonFixed.Name = "radioButtonFixed";
            this.radioButtonFixed.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFixed.TabIndex = 0;
            this.radioButtonFixed.TabStop = true;
            this.radioButtonFixed.Text = "Fixed";
            this.radioButtonFixed.UseVisualStyleBackColor = true;
            this.radioButtonFixed.CheckedChanged += new System.EventHandler(this.RadioButtonFixed_CheckedChanged);
            // 
            // textBoxHourAmount
            // 
            this.textBoxHourAmount.Location = new System.Drawing.Point(112, 153);
            this.textBoxHourAmount.MaxLength = 3;
            this.textBoxHourAmount.Name = "textBoxHourAmount";
            this.textBoxHourAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxHourAmount.Size = new System.Drawing.Size(26, 20);
            this.textBoxHourAmount.TabIndex = 29;
            this.textBoxHourAmount.Visible = false;
            this.textBoxHourAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHourAmount_Validating);
            // 
            // textBoxPaidPerHour
            // 
            this.textBoxPaidPerHour.Location = new System.Drawing.Point(112, 127);
            this.textBoxPaidPerHour.MaxLength = 4;
            this.textBoxPaidPerHour.Name = "textBoxPaidPerHour";
            this.textBoxPaidPerHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPaidPerHour.Size = new System.Drawing.Size(34, 20);
            this.textBoxPaidPerHour.TabIndex = 28;
            this.textBoxPaidPerHour.Visible = false;
            this.textBoxPaidPerHour.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPaidPerHour_Validating);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(112, 101);
            this.textBoxRate.MaxLength = 4;
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxRate.Size = new System.Drawing.Size(34, 20);
            this.textBoxRate.TabIndex = 27;
            this.textBoxRate.Visible = false;
            this.textBoxRate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRate_Validating);
            // 
            // textBoxAmountDay
            // 
            this.textBoxAmountDay.Location = new System.Drawing.Point(112, 75);
            this.textBoxAmountDay.MaxLength = 3;
            this.textBoxAmountDay.Name = "textBoxAmountDay";
            this.textBoxAmountDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAmountDay.Size = new System.Drawing.Size(34, 20);
            this.textBoxAmountDay.TabIndex = 26;
            this.textBoxAmountDay.Visible = false;
            this.textBoxAmountDay.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAmountDay_Validating);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(112, 49);
            this.textBoxSalary.MaxLength = 7;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSalary.Size = new System.Drawing.Size(50, 20);
            this.textBoxSalary.TabIndex = 25;
            this.textBoxSalary.Visible = false;
            this.textBoxSalary.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSalary_Validating);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(247, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(166, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // hourAmountLabel
            // 
            this.hourAmountLabel.AutoSize = true;
            this.hourAmountLabel.Location = new System.Drawing.Point(14, 156);
            this.hourAmountLabel.Name = "hourAmountLabel";
            this.hourAmountLabel.Size = new System.Drawing.Size(68, 13);
            this.hourAmountLabel.TabIndex = 16;
            this.hourAmountLabel.Text = "Hour amount";
            this.hourAmountLabel.Visible = false;
            // 
            // paidPerHourLabel
            // 
            this.paidPerHourLabel.AutoSize = true;
            this.paidPerHourLabel.Location = new System.Drawing.Point(14, 130);
            this.paidPerHourLabel.Name = "paidPerHourLabel";
            this.paidPerHourLabel.Size = new System.Drawing.Size(70, 13);
            this.paidPerHourLabel.TabIndex = 15;
            this.paidPerHourLabel.Text = "Paid per hour";
            this.paidPerHourLabel.Visible = false;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(14, 104);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(30, 13);
            this.rateLabel.TabIndex = 14;
            this.rateLabel.Text = "Rate";
            this.rateLabel.Visible = false;
            // 
            // amountDayLabel
            // 
            this.amountDayLabel.AutoSize = true;
            this.amountDayLabel.Location = new System.Drawing.Point(14, 78);
            this.amountDayLabel.Name = "amountDayLabel";
            this.amountDayLabel.Size = new System.Drawing.Size(65, 13);
            this.amountDayLabel.TabIndex = 13;
            this.amountDayLabel.Text = "Amount Day";
            this.amountDayLabel.Visible = false;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(14, 52);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 12;
            this.salaryLabel.Text = "Salary";
            this.salaryLabel.Visible = false;
            // 
            // typeOfRateLabel
            // 
            this.typeOfRateLabel.AutoSize = true;
            this.typeOfRateLabel.Location = new System.Drawing.Point(14, 28);
            this.typeOfRateLabel.Name = "typeOfRateLabel";
            this.typeOfRateLabel.Size = new System.Drawing.Size(64, 13);
            this.typeOfRateLabel.TabIndex = 9;
            this.typeOfRateLabel.Text = "Type of rate";
            // 
            // radioButtonHourly
            // 
            this.radioButtonHourly.AutoSize = true;
            this.radioButtonHourly.Location = new System.Drawing.Point(237, 26);
            this.radioButtonHourly.Name = "radioButtonHourly";
            this.radioButtonHourly.Size = new System.Drawing.Size(55, 17);
            this.radioButtonHourly.TabIndex = 2;
            this.radioButtonHourly.TabStop = true;
            this.radioButtonHourly.Text = "Houlry";
            this.radioButtonHourly.UseVisualStyleBackColor = true;
            this.radioButtonHourly.CheckedChanged += new System.EventHandler(this.RadioButtonHourly_CheckedChanged);
            // 
            // radioButtonVariable
            // 
            this.radioButtonVariable.AutoSize = true;
            this.radioButtonVariable.Location = new System.Drawing.Point(168, 26);
            this.radioButtonVariable.Name = "radioButtonVariable";
            this.radioButtonVariable.Size = new System.Drawing.Size(63, 17);
            this.radioButtonVariable.TabIndex = 1;
            this.radioButtonVariable.TabStop = true;
            this.radioButtonVariable.Text = "Variable";
            this.radioButtonVariable.UseVisualStyleBackColor = true;
            this.radioButtonVariable.CheckedChanged += new System.EventHandler(this.RadioButtonVariable_CheckedChanged);
            // 
            // groupBoxCountData
            // 
            this.groupBoxCountData.Controls.Add(this.radioButtonFixed);
            this.groupBoxCountData.Controls.Add(this.typeOfRateLabel);
            this.groupBoxCountData.Controls.Add(this.radioButtonVariable);
            this.groupBoxCountData.Controls.Add(this.radioButtonHourly);
            this.groupBoxCountData.Controls.Add(this.textBoxHourAmount);
            this.groupBoxCountData.Controls.Add(this.salaryLabel);
            this.groupBoxCountData.Controls.Add(this.textBoxPaidPerHour);
            this.groupBoxCountData.Controls.Add(this.amountDayLabel);
            this.groupBoxCountData.Controls.Add(this.textBoxRate);
            this.groupBoxCountData.Controls.Add(this.rateLabel);
            this.groupBoxCountData.Controls.Add(this.textBoxAmountDay);
            this.groupBoxCountData.Controls.Add(this.paidPerHourLabel);
            this.groupBoxCountData.Controls.Add(this.textBoxSalary);
            this.groupBoxCountData.Controls.Add(this.hourAmountLabel);
            this.groupBoxCountData.Location = new System.Drawing.Point(12, 91);
            this.groupBoxCountData.Name = "groupBoxCountData";
            this.groupBoxCountData.Size = new System.Drawing.Size(310, 181);
            this.groupBoxCountData.TabIndex = 34;
            this.groupBoxCountData.TabStop = false;
            this.groupBoxCountData.Text = "Data for count";
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.groupBoxCountData);
            this.Controls.Add(this.buttonRandomData);
            this.Controls.Add(this.groupBoxPersonData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "AddObjectForm";
            this.Text = "AddObjectForm";
            this.groupBoxPersonData.ResumeLayout(false);
            this.groupBoxPersonData.PerformLayout();
            this.groupBoxCountData.ResumeLayout(false);
            this.groupBoxCountData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        public System.Windows.Forms.TextBox textBoxHourAmount;
        public System.Windows.Forms.TextBox textBoxPaidPerHour;
        public System.Windows.Forms.TextBox textBoxRate;
        public System.Windows.Forms.TextBox textBoxAmountDay;
        public System.Windows.Forms.TextBox textBoxSalary;
        public System.Windows.Forms.TextBox textBoxPersonName;
        public System.Windows.Forms.TextBox textBoxPersonSurname;
        public System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRandomData;
        public System.Windows.Forms.GroupBox groupBoxPersonData;
        private System.Windows.Forms.GroupBox groupBoxCountData;
        private System.Windows.Forms.Button buttonCancel;
    }
}