using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace View
{
    public partial class SearcherForm : Form
    {
        /// <summary>
        /// Таблица для результатов поиска
        /// </summary>
        private DataTable _searchResult = new DataTable();

        /// <summary>
        /// Формирование талбицы
        /// </summary>
        private void SetSearchResults()
        {
            _searchResult.TableName = "Result";
            _searchResult.Columns.Add("Surname");
            _searchResult.Columns.Add("Name");
            _searchResult.Columns.Add("Pay amount");
        }

        /// <summary>
        /// Инициализация формы для поиска
        /// </summary>
        public SearcherForm()
        {
            InitializeComponent();
            SetSearchResults();
            dataGridViewResult.DataSource = _searchResult;

        }

        /// <summary>
        /// Реализация поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            _searchResult.Clear();
            string pattern = textBoxSearchData.Text;
            if (textBoxSearchData != null)
            {
                try
                {
                    foreach (DataRow r in SalaryRateForm.dt.Rows)
                    {
                        foreach (string str in r.ItemArray)
                        {
                            if (Regex.IsMatch(str, pattern))
                            {
                                _searchResult.Rows.Add(r["Surname"], r["Name"], r["Pay amount"]);
                                break;
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
