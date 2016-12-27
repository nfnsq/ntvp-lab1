using System;
using System.ComponentModel;
using System.Windows.Forms;
using SalaryRateModel;
using System.Text.RegularExpressions;
using System.Globalization;
using Global;

namespace View
{
    public partial class AddObjectForm : Form
    {

        private static int size = 0;
        /// <summary>
        /// Создание объекта
        /// </summary>
        public static Employee[] _employeeList = new Employee[size];

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddObjectForm()
        {
            InitializeComponent();
            #if !DEBUG
            buttonRandomData.Visible = false;         
            #endif

        }

        /// <summary>
        /// События при нажатии buttonOK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                int length = 0;
                Parameter[] parameters = new Parameter[length];

                foreach (Control groupBoxCD in this.Controls)
                {
                    if ((groupBoxCD is GroupBox)
                        && (groupBoxCD.Name == "groupBoxCountData"))
                    {
                        foreach (Control textbox in groupBoxCD.Controls)
                        {
                            if ((textbox is TextBox) && (textbox.Visible == true))
                            {
                                length++;
                                Array.Resize<Parameter>(ref parameters, length);
                                parameters[length - 1].Value = double.Parse(textbox.Text,
                                CultureInfo.InvariantCulture);
                                if (textbox.Name == textBoxSalary.Name)
                                    parameters[length - 1].Description = Global.Properties.Resources.Salary;
                                if (textbox.Name == textBoxAmountDay.Name)
                                    parameters[length - 1].Description = Global.Properties.Resources.DayAmount;
                                if (textbox.Name == textBoxHourAmount.Name)
                                    parameters[length - 1].Description = Global.Properties.Resources.HourAmount;
                                if (textbox.Name == textBoxPaidPerHour.Name)
                                    parameters[length - 1].Description = Global.Properties.Resources.PaidPerHour;
                                if (textbox.Name == textBoxRate.Name)
                                    parameters[length - 1].Description = Global.Properties.Resources.Rate;
                            }
                        }
                    }
                }
                size = size + 1;
                Array.Resize<Employee>(ref _employeeList, size);
                
                if (radioButtonFixed.Checked)
                {
                    _employeeList[size - 1] = new FixedRate(parameters);
                }
                if (radioButtonHourly.Checked)
                    _employeeList[size - 1] = new HourlyRate(parameters);
                
                if (radioButtonVariable.Checked)
                    _employeeList[size - 1] = new VariableRate(parameters);

                if (_employeeList[size - 1] != null)
                {
                    _employeeList[size - 1].Name = textBoxPersonName.Text;
                    _employeeList[size - 1].Surname = textBoxPersonSurname.Text;
                    SalaryRateForm.dt.Rows.Add(_employeeList[size - 1].Surname,
                        _employeeList[size - 1].Name, _employeeList[size - 1].GetSummOfPay());
                }
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Oops! There are empty fields. Please, try again.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Отображение необходимых для заполнения полей для
        /// класса FixedRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonFixed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFixed.Checked)
            {
                textBoxSalary.Visible = true;
                textBoxAmountDay.Visible = true;
                salaryLabel.Visible = true;
                amountDayLabel.Visible = true;
            }
            else
            {
                textBoxSalary.Visible = false;
                textBoxAmountDay.Visible = false;
                salaryLabel.Visible = false;
                amountDayLabel.Visible = false;
            }
        }

        /// <summary>
        /// Отображение необходимых для заполнения полей для
        /// класса VariableRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVariable.Checked)
            {
                textBoxAmountDay.Visible = true;
                textBoxSalary.Visible = true;
                textBoxRate.Visible = true;
                amountDayLabel.Visible = true;
                salaryLabel.Visible = true;
                rateLabel.Visible = true;
            }
            else
            {
                textBoxAmountDay.Visible = false;
                textBoxSalary.Visible = false;
                textBoxRate.Visible = false;
                amountDayLabel.Visible = false;
                salaryLabel.Visible = false;
                rateLabel.Visible = false;
            }
        }

        /// <summary>
        /// Отображение необходимых для заполнения полей для
        /// класса HourlyRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButtonHourly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHourly.Checked)
            {
                textBoxPaidPerHour.Location = new System.Drawing.Point(112, 49);
                textBoxHourAmount.Location = new System.Drawing.Point(112, 75);
                paidPerHourLabel.Location = new System.Drawing.Point(14, 52);
                hourAmountLabel.Location = new System.Drawing.Point(14, 78);
                textBoxPaidPerHour.Visible = true;
                textBoxHourAmount.Visible = true;
                paidPerHourLabel.Visible = true;
                hourAmountLabel.Visible = true;

            }
            else
            {
                textBoxPaidPerHour.Visible = false;
                textBoxHourAmount.Visible = false;
                paidPerHourLabel.Visible = false;
                hourAmountLabel.Visible = false;
            }
        }
        
        /// <summary>
        /// Закрытие формы при нажатии buttonCancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Заполнение случайными данными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomData_Click(object sender, EventArgs e)
        {
            RandomDataCreator randomPerson = new RandomDataCreator();
            textBoxPersonName.Text = randomPerson.RandomName();
            textBoxPersonSurname.Text = randomPerson.RandomSurname();
            Random keyRand = new Random();
            int key = keyRand.Next(3);
            switch (key)
            {
                case 0:
                    radioButtonFixed.Checked = true;
                    radioButtonHourly.Checked = false;
                    radioButtonVariable.Checked = false;
                    textBoxSalary.Text = randomPerson.Salary();
                    textBoxAmountDay.Text = randomPerson.AmountDay();
                    break;

                case 1:
                    radioButtonFixed.Checked = false;
                    radioButtonHourly.Checked = true;
                    radioButtonVariable.Checked = false;                    
                    textBoxPaidPerHour.Text = randomPerson.PaidPH();
                    textBoxHourAmount.Text = randomPerson.HourAmount();
                    break;

                case 2:
                    radioButtonFixed.Checked = false;
                    radioButtonHourly.Checked = false;
                    radioButtonVariable.Checked = true;
                    textBoxSalary.Text = randomPerson.Salary();
                    textBoxAmountDay.Text = randomPerson.AmountDay();
                    textBoxRate.Text = "0." + randomPerson.Rate();
                    break;
            }
        }
        
        /// <summary>
        /// Метод валидации данных
        /// </summary>
        /// <param name="regex">Регулярное выражение</param>
        /// <param name="text">Проверяемая строка</param>
        /// <param name="e"></param>
        private void CheckData(Regex regex, string text, CancelEventArgs e)
        {
            if ((regex.IsMatch(text) != true) && (text != "")
                && (!buttonCancel.Focused) && (!buttonRandomData.Focused))
            {
                MessageBox.Show("Invalid data. Please, try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                text = "";
            }
        }

        private void textBoxPersonSurname_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("(^[A-Z]{1}[a-z]{0,14}$)");
            CheckData(regex, textBoxPersonSurname.Text, e);
        }

        private void textBoxPersonName_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("(^[A-Z]{1}[a-z]{0,14}$)");
            CheckData(regex, textBoxPersonName.Text, e);
        }

        private void textBoxSalary_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-9]{1}[0-9]{4}[0-9]{0,2}$");
            CheckData(regex, textBoxSalary.Text, e);
        }

        private void textBoxAmountDay_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^[1-3]{1}[0-6]{0,1}[0-9]{0,1}$");
            CheckData(regex, textBoxAmountDay.Text, e);
        }

        private void textBoxRate_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("^0{1}\\.[1-9]{1}5{0,1}$");
            CheckData(regex, textBoxRate.Text, e);
        }

        private void textBoxPaidPerHour_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("[1-9]{1}[0-9]{2,3}");
            CheckData(regex, textBoxPaidPerHour.Text, e);
        }

        private void textBoxHourAmount_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("1{0,1}[1-9]{1}[0-9]{0,1}");
            CheckData(regex, textBoxHourAmount.Text, e);
            
        }

    }
}
