using System;
using System.ComponentModel;
using System.Windows.Forms;
using SalaryRateModel;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace View
{
    /// <summary>
    /// Объект для ввода и отображения данных сотрудника
    /// </summary>
    public partial class ObjectControl : UserControl
    {
        /// <summary>
        /// Конструктор для создания нового объекта
        /// </summary>
        public ObjectControl()
        {
            InitializeComponent();
        }

        private bool _readOnly;
        /// <summary>
        /// Признак редактируемости объекта
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly == null)
                    return;
                if (_readOnly == true)
                {
                    SetReadOnly(true);
                }
                else
                {
                    SetReadOnly(false);
                }
            }
        }
        /// <summary>
        /// Метод для установки редактируемости объекта
        /// </summary>
        /// <param name="state"></param>
        private void SetReadOnly(bool state)
        {
            foreach (Control groupBox in this.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control textbox in groupBox.Controls)
                    {
                        if (textbox is TextBox)
                        {
                            textbox.Enabled = !state;
                        }
                    }
                    foreach (Control radioButton in groupBox.Controls)
                    {
                        if (radioButton is RadioButton)
                        {
                            radioButton.Enabled = !state;
                        }
                    }
                }
            }
        }

        private SalaryRateModel.Employee _object = null;
        /// <summary>
        /// Объект сотрудник
        /// </summary>
        public Employee Object
        {
            get
            {
                int size = 0;
                SalaryRateModel.Parameter[] paramters = new SalaryRateModel.Parameter[size];

                if (fixedRadioButton.Checked)
                {
                    size = 2;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(salaryTextBox.Text);
                    paramters[1].Value = double.Parse(amountDayTextBox.Text);
                    paramters[0].Description = SalaryRateModel.Properties.Resources.Salary;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.DayAmount;

                    _object = new FixedRate(paramters);
                    _object.Name = personNameTextBox.Text;
                    _object.Surname = personSurnameTextBox.Text;
                }
                if (variableRadioButton.Checked)
                {
                    size = 3;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(salaryTextBox.Text);
                    paramters[1].Value = double.Parse(amountDayTextBox.Text);
                    paramters[2].Value = double.Parse(rateTextBox.Text);

                    paramters[0].Description = SalaryRateModel.Properties.Resources.Salary;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.DayAmount;
                    paramters[2].Description = SalaryRateModel.Properties.Resources.Rate;

                    _object = new VariableRate(paramters);
                    _object.Name = personNameTextBox.Text;
                    _object.Surname = personSurnameTextBox.Text;
                }
                if (hourlyRadioButton.Checked)
                {
                    size = 2;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(hourAmountTextBox.Text);
                    paramters[1].Value = double.Parse(paidPerHourTextBox.Text);
                    paramters[0].Description = SalaryRateModel.Properties.Resources.HourAmount;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.PaidPerHour;

                    _object = new HourlyRate(paramters);
                    _object.Name = personNameTextBox.Text;
                    _object.Surname = personSurnameTextBox.Text;
                }
                
                return _object;
            }
            set
            {
                _object = value;
                if (_object == null)
                    return;
                personNameTextBox.Text = _object.Name;
                personSurnameTextBox.Text = _object.Surname;
                if (_object.Parameters.Length == 3)
                {
                    variableRadioButton.Checked = true;
                    salaryTextBox.Text = _object.Parameters[0].Value.ToString();
                    amountDayTextBox.Text = _object.Parameters[1].Value.ToString();
                    rateTextBox.Text = _object.Parameters[2].Value.ToString();
                }
                if ((_object.Parameters.Length == 2) &&
                    (_object.Parameters[1].Description == SalaryRateModel.Properties.Resources.PaidPerHour))
                {
                    hourlyRadioButton.Checked = true;
                    hourAmountTextBox.Text = _object.Parameters[0].Value.ToString();
                    paidPerHourTextBox.Text = _object.Parameters[1].Value.ToString();
                }
                if ((_object.Parameters.Length == 2) &&
                    (_object.Parameters[1].Description == SalaryRateModel.Properties.Resources.DayAmount))
                {
                    fixedRadioButton.Checked = true;
                    salaryTextBox.Text = _object.Parameters[0].Value.ToString();
                    amountDayTextBox.Text = _object.Parameters[1].Value.ToString();
                }
            }
        }
        /// <summary>
        /// Метод для проерки вводимых пользователем значений
        /// </summary>
        private void DataValidating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[0-9]+$");
            if ((regex.IsMatch(((TextBox)sender).Text) != true) && (((TextBox)sender).Text != ""))
            {
                MessageBox.Show("Invalid data. Please, try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                ((TextBox)sender).Text = "";
            }
        }
        /// <summary>
        /// Метод измененяет объект
        /// для отображения данных сотрудника 
        /// с типом начисления зарплаты по окладу
        /// </summary>
        private void fixedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fixedRadioButton.Checked)
            {
                salaryLabel.Visible = true;
                dayAmountLabel.Visible = true;
                salaryTextBox.Visible = true;
                amountDayTextBox.Visible = true;
            }
            else
            {
                salaryLabel.Visible = false;
                dayAmountLabel.Visible = false;
                salaryTextBox.Visible = false;
                amountDayTextBox.Visible = false;
            }
        }
        /// <summary>
        /// Метод измененяет объект
        /// для отображения данных сотрудника 
        /// с типом начисления зарплаты по ставке
        /// </summary>
        private void variableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (variableRadioButton.Checked)
            {
                salaryLabel.Visible = true;
                dayAmountLabel.Visible = true;
                rateLabel.Visible = true;

                salaryTextBox.Visible = true;
                amountDayTextBox.Visible = true;
                rateTextBox.Visible = true;
            }
            else
            {
                salaryLabel.Visible = false;
                dayAmountLabel.Visible = false;
                rateLabel.Visible = false;

                salaryTextBox.Visible = false;
                amountDayTextBox.Visible = false;
                rateTextBox.Visible = false;
            }
        }
        /// <summary>
        /// Метод измененяет объект
        /// для отображения данных сотрудника 
        /// с типом начисления зарплаты по почасовой оплате
        /// </summary>
        private void hourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hourlyRadioButton.Checked)
            {
                paidPerHourTextBox.Location = new System.Drawing.Point(118, 42);
                hourAmountTextBox.Location = new System.Drawing.Point(118, 68);
                paidPerHourLabel.Location = new System.Drawing.Point(19, 45);
                hourAmountLabel.Location = new System.Drawing.Point(19, 71);
                paidPerHourLabel.Visible = true;
                hourAmountLabel.Visible = true;

                paidPerHourTextBox.Visible = true;
                hourAmountTextBox.Visible = true;
            }
            else
            {
                paidPerHourLabel.Visible = false;
                hourAmountLabel.Visible = false;

                paidPerHourTextBox.Visible = false;
                hourAmountTextBox.Visible = false;
            }
        }
        /// <summary>
        /// Метод для очистки отображаемых данных в объекте
        /// </summary>
        public void Clear()
        {
            foreach (Control groupBox in this.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control textbox in groupBox.Controls)
                    {
                        if (textbox is TextBox)
                        {
                            textbox.Text = "";
                        }
                    }
                }
            }
            fixedRadioButton.Checked = false;
            variableRadioButton.Checked = false;
            hourlyRadioButton.Checked = false;
        }
    }
}
