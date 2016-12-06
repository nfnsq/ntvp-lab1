using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryRateModel;

namespace View
{
    public partial class AddObjectForm : Form
    {
        /// <summary>
        /// Массив Имен и Фамилий
        /// </summary>
        string[] PersonNames = { "Alice", "Bob", "Cara", "Dean", "Bruce" };
        string[] PersonSurnames = { "Wayne", "Hunter", "Bee", "Tatch", "Sean" };
        private IEmployee employee = null;
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
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ///
            ///Меняется значение интерфейса employee
            ///который был объявлен в главной форме
            ///в зависимости от выбора типа оплаты
            ///
            try
            {
                if (radioButtonFixed.Checked)
                {
                    double salary = double.Parse(maskedTextBoxSalary.Text);
                    double amountDay = double.Parse(maskedTextBoxAmountDay.Text);
                    employee = new FixedRate(salary, amountDay);
                }
                if (radioButtonHourly.Checked)
                {
                    double paidPerHour = double.Parse(maskedTextBoxPaidPerHour.Text);
                    double hourAmount = double.Parse(maskedTextBoxHourAmount.Text);
                    employee = new HourlyRate(paidPerHour, hourAmount);
                }
                if (radioButtonVariable.Checked)
                {
                    double salary = double.Parse(maskedTextBoxSalary.Text);
                    double amountDay = double.Parse(maskedTextBoxAmountDay.Text);
                    double rate = double.Parse(maskedTextBoxRate.Text);
                    employee = new VariableRate(salary, amountDay, rate);
                }
                if (employee != null)
                {
                    SalaryRateForm.dt.Rows.Add(maskedTextBoxPersonSurname.Text, 
                        maskedTextBoxPersonName.Text, employee.GetSummOfPay());
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
        private void radioButtonFixed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFixed.Checked)
            {
                maskedTextBoxSalary.Visible = true;
                maskedTextBoxAmountDay.Visible = true;
            }
            else
            {
                maskedTextBoxSalary.Visible = false;
                maskedTextBoxAmountDay.Visible = false;
            }
        }

        /// <summary>
        /// Отображение необходимых для заполнения полей для
        /// класса VariableRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVariable.Checked)
            {
                maskedTextBoxSalary.Visible = true;
                maskedTextBoxAmountDay.Visible = true;
                maskedTextBoxRate.Visible = true;
            }
            else
            {
                maskedTextBoxSalary.Visible = false;
                maskedTextBoxAmountDay.Visible = false;
                maskedTextBoxRate.Visible = false;
            }
        }
        /// <summary>
        /// Отображение необходимых для заполнения полей для
        /// класса HourlyRate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonHourly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHourly.Checked)
            {
                maskedTextBoxPaidPerHour.Location = new System.Drawing.Point(112, 120);
                maskedTextBoxHourAmount.Location = new System.Drawing.Point(112, 146);
                maskedTextBoxPaidPerHour.Visible = true;
                maskedTextBoxHourAmount.Visible = true;
            }
            else
            {
                maskedTextBoxPaidPerHour.Visible = false;
                maskedTextBoxHourAmount.Visible = false;
            }
        }
        /// <summary>
        /// Закрытие формы при нажатии buttonCancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            employee = null;
            Close();
        }

        /// <summary>
        /// Заполнение случайными данными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandomData_Click(object sender, EventArgs e)
        {

            Random RandomName = new Random();
            maskedTextBoxPersonName.Text = PersonNames[RandomName.Next(PersonNames.Length)];

            Random RandomSurname = new Random();
            maskedTextBoxPersonSurname.Text = PersonSurnames[RandomSurname.Next(PersonSurnames.Length)];

            if (radioButtonFixed.Checked)
            {
                Random salaryRandom = new Random();
                maskedTextBoxSalary.Text = Convert.ToString(salaryRandom.Next(9999));
                Random amountDayRandom = new Random();
                maskedTextBoxAmountDay.Text = Convert.ToString(amountDayRandom.Next(9999));
            }
            if (radioButtonHourly.Checked)
            {
                Random paidPerHourRandom = new Random();
                maskedTextBoxPaidPerHour.Text = Convert.ToString(paidPerHourRandom.Next(9999));
                Random hourAmountRandom = new Random();
                maskedTextBoxHourAmount.Text = Convert.ToString(hourAmountRandom.Next(9999));
            }
            if (radioButtonVariable.Checked)
            {
                Random salaryRandom = new Random();
                maskedTextBoxSalary.Text = Convert.ToString(salaryRandom.Next(9999));
                Random amountDayRandom = new Random();
                maskedTextBoxAmountDay.Text = Convert.ToString(amountDayRandom.Next(9999));
                Random rateRandom = new Random();
                maskedTextBoxRate.Text = Convert.ToString(rateRandom.Next(9999));
            }
        }
    }
}
