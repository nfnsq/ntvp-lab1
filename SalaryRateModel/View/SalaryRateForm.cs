using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using SalaryRateModel;
using System.Xml.Serialization;
using System.IO;

namespace View
{
    public partial class SalaryRateForm : Form
    {
        /// <summary>
        /// Создается таблица, которая является DataSource 
        /// для DataGridViewObject
        /// </summary>
        public static DataTable dt = new DataTable();
        public static EmployeeCollection list = new EmployeeCollection();
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
            objectControlView.ReadOnly = true;
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
                int count = dataGridViewObject.SelectedCells.Count;
                if (count == 0) throw new ArgumentOutOfRangeException();
                for (int i = 0; i < count; i++)
                {
                    int index = dataGridViewObject.SelectedCells[0].RowIndex;
                    SalaryRateForm.list.Collection.RemoveAt(index);
                    SalaryRateForm.dt.Rows.RemoveAt(index);
                }
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
                XmlSerializer serializer = new XmlSerializer(typeof(EmployeeCollection));
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        serializer.Serialize(writer, list);
                        writer.Close();
                    }
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
                var deserializer = new XmlSerializer(typeof(EmployeeCollection));
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        list = (EmployeeCollection)deserializer.Deserialize(reader);
                        reader.Close();
                    }
                }
                foreach (Employee employee in list.Collection)
                {
                    SalaryRateForm.dt.Rows.Add(employee.Surname,
                            employee.Name, employee.GetSummOfPay());
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
                if (dataGridViewObject.SelectedCells.Count == 0)
                {
                    objectControlView.Clear();
                }
                else
                {
                    Employee employee = null;
                    int index = dataGridViewObject.SelectedCells[0].RowIndex;
                    employee = SalaryRateForm.list.Collection[index];
                    objectControlView.Object = employee;
                }
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
