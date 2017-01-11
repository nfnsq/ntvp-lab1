using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using SalaryRateModel;
using System.Xml.Serialization;
using System.IO;

namespace View
{
    /// <summary>
    /// Главное окно программы
    /// </summary>
    public partial class SalaryRateForm : Form
    {
        public static EmployeeCollection list = new EmployeeCollection();
        
        /// <summary>
        /// Создается объект кэша данных
        /// </summary>
        private DataSet _dataSet = new DataSet();

        /// <summary>
        /// Создается таблица, которая является DataSource 
        /// для DataGridViewObject
        /// </summary>
        private DataTable _dataSourceTable = new DataTable();
        
        /// <summary>
        /// Формирование DataSet
        /// </summary>
        private void SetDS()
        {
            _dataSet.Tables.Add(_dataSourceTable);
        }

        /// <summary>
        /// Формирование таблицы Employee
        /// </summary>
        private void SetDT()
        {
            _dataSourceTable.TableName = "Employee";
            _dataSourceTable.Columns.Add("Surname");
            _dataSourceTable.Columns.Add("Name");
            _dataSourceTable.Columns.Add("Pay amount");
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SalaryRateForm()
        {
            InitializeComponent();
            objectControlView.ReadOnly = true;
            dataGridViewObject.DataSource = _dataSourceTable;
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
            DataEnterForm addObjectForm = new DataEnterForm();
            addObjectForm.ShowDialog();
            UpdateTable(); 
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
                int count = dataGridViewObject.SelectedRows.Count;
                if (count == 0) throw new ArgumentOutOfRangeException();
                for (int i = 0; i < count; i++)
                {
                    int index = dataGridViewObject.SelectedCells[0].RowIndex;
                    SalaryRateForm.list.Collection.RemoveAt(index);
                    _dataSourceTable.Rows.RemoveAt(index);
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
                EmployeeCollection deserialized;
                var deserializer = new XmlSerializer(typeof(EmployeeCollection));
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        deserialized = (EmployeeCollection)deserializer.Deserialize(reader);
                        reader.Close();
                    }
                    foreach (Employee employee in deserialized.Collection)
                    {
                        list.Collection.Add(employee);
                        _dataSourceTable.Rows.Add(employee.Surname,
                                employee.Name, employee.GetSummOfPay());
                    }
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

        /// <summary>
        /// Метод для обработки события
        /// - изменение выделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод для создания новой формы редактирования данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewObject.SelectedCells[0].RowIndex;
                DataEnterForm modifyForm = new DataEnterForm(list.Collection[index]);
                modifyForm.ShowDialog();
                UpdateTable();
            }
            catch
            {

            }
        }

        /// <summary>
        /// Метод для синхронизации таблицы со списком
        /// </summary>
        private void UpdateTable()
        {
            _dataSourceTable.Clear();
            foreach (Employee tmpEmployee in list.Collection)
            {
                _dataSourceTable.Rows.Add(tmpEmployee.Surname,
                    tmpEmployee.Name, tmpEmployee.GetSummOfPay());
            }
        }
    }
}
