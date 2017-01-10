using System;
using System.ComponentModel;
using System.Windows.Forms;
using SalaryRateModel;
using System.Text.RegularExpressions;
using System.Globalization;
using SalaryRateModel;
using System.Data;

namespace View
{
    public partial class AddObjectForm : Form
    {
        private bool _add;
        private int _index;
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddObjectForm()
        {
            this._add = true;
            InitializeComponent();
            #if !DEBUG
            buttonRandomData.Visible = false;         
            #endif

        }
        public AddObjectForm(int index)
        {
            this._index = index;
            this._add = false;
            InitializeComponent();
            #if !DEBUG
            buttonRandomData.Visible = false;         
            #endif
            Employee employee = null;
            employee = SalaryRateForm.list.Collection[index];
            objectControl.Object = employee;

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
                Employee employee = null;
                employee = objectControl.Object;
                if (_add)
                {
                    if (employee != null)
                    {
                        SalaryRateForm.list.Collection.Add(employee);
                        SalaryRateForm.dt.Rows.Add(employee.Surname,
                            employee.Name, employee.GetSummOfPay());
                    }
                }
                else
                {
                    if (employee != null)
                    {
                        SalaryRateForm.list.Collection.RemoveAt(_index);
                        SalaryRateForm.list.Collection.Insert(_index, employee);
                        SalaryRateForm.dt.Rows.RemoveAt(_index);
                        DataRow row = SalaryRateForm.dt.NewRow();
                        row["Name"] = employee.Name;
                        row["Surname"] = employee.Surname;
                        row["Pay amount"] = employee.GetSummOfPay();
                        SalaryRateForm.dt.Rows.InsertAt(row, _index);
                    }
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
        /// Заполнение случайными данными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandomData_Click(object sender, EventArgs e)
        {
            RandomDataCreator randomPerson = new RandomDataCreator();
            objectControl.Object = randomPerson.GetRandomPerson(); 
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

        private void AddObjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
