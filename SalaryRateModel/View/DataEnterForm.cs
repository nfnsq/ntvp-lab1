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
        private int _index;
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
        public DataEnterForm(int index)
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
                    }
                }
                else
                {
                    if (employee != null)
                    {
                        SalaryRateForm.list.Collection.RemoveAt(_index);
                        SalaryRateForm.list.Collection.Insert(_index, employee);
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
