using System;
using System.ComponentModel;
using System.Windows.Forms;
using SalaryRateModel;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data;

namespace View
{
    /// <summary>
    /// Форма для добавления и редактирования данных сотрудников 
    /// </summary>
    public partial class DataEnterForm : Form
    {
        private bool _add;
        private Employee _employee;
        /// <summary>
        /// Конструктор для создания формы 
        /// добавления нового объекта
        /// </summary>
        public DataEnterForm()
        {
            this._add = true;
            InitializeComponent();
            #if !DEBUG
            buttonRandomData.Visible = false;         
            #endif

        }
        /// <summary>
        /// Конструктор для создания формы 
        /// редактирования выбранного объекта
        /// </summary>
        /// <param name="index"></param>
        public DataEnterForm(Employee employee)
        {
            this._add = false;
            this._employee = employee;
            InitializeComponent();
            #if !DEBUG
            buttonRandomData.Visible = false;         
            #endif
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
                int index = SalaryRateForm.list.Collection.IndexOf(_employee);
                if (_add)
                {
                    if (employee != null)
                    {
                        SalaryRateForm.list.Collection.Add(employee);
                    }
                }
                else
                {
                    if (employee != null)
                    {
                        SalaryRateForm.list.Collection.RemoveAt(index);
                        SalaryRateForm.list.Collection.Insert(index, employee);
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
    }
}
