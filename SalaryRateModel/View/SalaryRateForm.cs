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
using System.IO;

namespace View
{
    public partial class SalaryRateForm : Form
    {
        /// <summary>
        /// г*внокодеры созают глобальные переменные!
        /// Создается таблица, которая является DataSource 
        /// для DataGridViewObject
        /// </summary>
        public static DataTable dt = new DataTable();
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
            dataGridViewObject.DataSource = dt;
            SetDT();
            SetDS();
        }

        /// <summary>
        /// Создание объекта, и добавление в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            AddObjectForm addObjectForm = new AddObjectForm();
            addObjectForm.ShowDialog();
        }

        /// <summary>
        /// Удаление выбранного объекта из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemovePerson_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewObject.Rows.RemoveAt(dataGridViewObject.SelectedCells[0].RowIndex);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Rows is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Сериализация данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewObject.Rows.Count > 0) //если в таблице больше нуля строк
            {
                MessageBox.Show("Please drop data from DataGrid before" + 
                    " downloading new file.", "Error.");
            }
            else
            {
                try
                {
                    DataSet ds = new DataSet(); // создаем новый пустой кэш данных
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string path = ofd.FileName;
                        ds.ReadXml(path); // записываем в кэш XML-данные из файла
                    }
                    foreach (DataRow item in ds.Tables["Employee"].Rows)
                    {
                        dt.Rows.Add(item["Surname"], item["Name"], item["Pay amount"]);
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to read file.", "Error.");
                }
            }
        }
        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewObject.Update();
            SearcherForm searchForm = new SearcherForm();
            searchForm.ShowDialog();
        }
    }
}
