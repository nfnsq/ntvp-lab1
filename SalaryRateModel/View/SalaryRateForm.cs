using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using SalaryRateModel;

namespace View
{
    public partial class SalaryRateForm : Form
    {
        /// <summary>
        /// Создается таблица, которая является DataSource 
        /// для DataGridViewObject
        /// </summary>
        public static DataTable dt = new DataTable();
        public static DataTable ListTable = new DataTable();
        public static List<Employee> list = new List<Employee>();
        /// <summary>
        /// Создается объект кэша данных
        /// </summary>
        private DataSet ds = new DataSet();

        /// <summary>
        /// Формирование DataSet
        /// </summary>
        private void SetDS()
        {
            ds.Tables.Add(dt);
        }

        /// <summary>
        /// Формирование таблицы Employee
        /// </summary>
        private void SetDT()
        {
            ListTable.TableName = "Object";
            ListTable.Columns.Add("Name");
            ListTable.Columns.Add("Surname");
            ListTable.Columns.Add(Global.Properties.Resources.Rate);
            ListTable.Columns.Add(Global.Properties.Resources.Salary);
            ListTable.Columns.Add(Global.Properties.Resources.HourAmount);
            ListTable.Columns.Add(Global.Properties.Resources.PaidPerHour);
            ListTable.Columns.Add(Global.Properties.Resources.DayAmount);


            dt.TableName = "Employee";
            dt.Columns.Add("Surname");
            dt.Columns.Add("Name");
            dt.Columns.Add("Pay amount");

        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SalaryRateForm()
        {
            InitializeComponent();
            dataGridViewObject.DataSource = dt;
            SetDT();
            SetDS();
        }

        /// <summary>
        /// Создание объекта, и добавление в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            AddObjectForm addObjectForm = new AddObjectForm();
            addObjectForm.ShowDialog();
        }

        /// <summary>
        /// Удаление выбранного объекта из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemovePerson_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryRateForm.dt.Rows.RemoveAt(dataGridViewObject.SelectedCells[0].RowIndex);
                SalaryRateForm.list.RemoveAt(dataGridViewObject.SelectedCells[0].RowIndex);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Rows is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Rows is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    ds.WriteXml(path);
                    MessageBox.Show("XML file has been succesfully saved.", "Done.");
                }
            }
            catch
            {
                MessageBox.Show("Unable to save file.", "Error.");
            }
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet(); 
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    ds.ReadXml(path); 
                }
                foreach (DataRow item in ds.Tables["Employee"].Rows)
                {
                    RowToTableIncreaser.DoAdd(item, dt);
                }
            }
            catch
            {
                MessageBox.Show("Unable to read file.", "Error.");
            }
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewObject.Update();
            SearcherForm searchForm = new SearcherForm();
            searchForm.ShowDialog();
        }

        private void dataGridViewObject_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Employee employee = null;
                int index = dataGridViewObject.SelectedCells[0].RowIndex;
                employee = SalaryRateForm.list[index];
                objectControlView.Object = employee;
            }
            catch
            {

            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewObject.SelectedCells[0].RowIndex;
                AddObjectForm modifyForm = new AddObjectForm(index);
                modifyForm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
