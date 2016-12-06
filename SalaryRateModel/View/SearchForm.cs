using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class SearcherForm : Form
    {
        /// <summary>
        /// Таблица для результатов поиска
        /// </summary>
        private DataTable searchResult = new DataTable();
        /// <summary>
        /// Формирование талбицы
        /// </summary>
        private void setSearchResults()
        {
            searchResult.TableName = "Result";
            searchResult.Columns.Add("Surname");
            searchResult.Columns.Add("Name");
            searchResult.Columns.Add("Pay amount");
        }
        /// <summary>
        /// Инициализация формы для поиска
        /// </summary>
        public SearcherForm()
        {
            InitializeComponent();
            setSearchResults();
            dataGridViewResult.DataSource = searchResult;

        }
        /// <summary>
        /// Реализация поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            if (textBoxSearchData != null)
            {
                try
                {
                    foreach (DataRow r in SalaryRateForm.dt.Rows)
                    {
                        foreach (string str in r.ItemArray)
                        {
                            if (textBoxSearchData.Text == str)
                            {
                                searchResult.Rows.Add(r["Surname"], r["Name"], r["Pay amount"]);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Oops! Something don't work. Please, again with correct data.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
