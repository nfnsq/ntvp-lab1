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

        public SalaryRateForm()
        {
            InitializeComponent();
        }

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
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            dt.Columns.Add("Surname");
            dt.Columns.Add("Name");
            dt.Columns.Add("Pay amount");
            
            for (int i = 0; i < dataGridViewObject.Rows.Count; i++)
            {
                dt.Rows.Add(dataGridViewObject.Rows[i].Cells[0].Value, 
                    dataGridViewObject.Rows[i].Cells[1].Value, 
                    dataGridViewObject.Rows[i].Cells[2].Value);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                var writer = new System.Xml.Serialization.XmlSerializer(typeof(DataSet));
                using (var file = System.IO.File.Create(path))
                {
                    writer.Serialize(file, ds);
                    file.Close();
                }
            } 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                var reader = new System.Xml.Serialization.XmlSerializer(typeof(DataTable));
                var file = new System.IO.StreamReader(path);
                dt = (DataTable)reader.Deserialize(file);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridViewObject.Rows.Add(dt.Rows[i].Field<string>(0),
                    dt.Rows[i].Field<string>(1),
                    dt.Rows[i].Field<string>(2));
            }
        }
    }
}
