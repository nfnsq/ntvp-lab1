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
        /// Объявление "глобальной переменной"
        /// Создается объект интерфейса Iemployee,
        /// который является свойством SalaryRateForm 
        /// с правами общего доступа
        /// </summary>
        public static IEmployee employee = null;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SalaryRateForm()
        {
            InitializeComponent();
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

            //После закрытия AddObjectForm
            if (employee != null)
            {
                dataGridViewObject.Rows.Add(' ',' ',employee.GetSummOfPay());
            }
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
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                dt.TableName = "Employee";
                dt.Columns.Add("Surname");
                dt.Columns.Add("Name");
                dt.Columns.Add("Pay amount");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dataGridViewObject.Rows)
                {
                    DataRow row = ds.Tables["Employee"].NewRow();
                    row["Surname"] = r.Cells[0].Value;
                    row["Name"] = r.Cells[1].Value;
                    row["Pay amount"] = r.Cells[2].Value;
                    ds.Tables["Employee"].Rows.Add(row);
                }

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
                        int n = dataGridViewObject.Rows.Add();
                        dataGridViewObject.Rows[n].Cells[0].Value = item["Surname"];
                        dataGridViewObject.Rows[n].Cells[1].Value = item["Name"];
                        dataGridViewObject.Rows[n].Cells[2].Value = item["Pay amount"];
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to read file.", "Error.");
                }
            }
        }
    }
}
