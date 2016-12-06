using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions;

namespace View
{
    public partial class SearcherForm : Form
    {
        private DataTable searchResult = new DataTable();
        
        private void setSearchResults()
        {
            searchResult.TableName = "Result";
            searchResult.Columns.Add("Surname");
            searchResult.Columns.Add("Name");
            searchResult.Columns.Add("Pay amount");
        }
        
        public SearcherForm()
        {
            InitializeComponent();
//            groupBoxObject.Visible = false;
//            menuStrip1.Visible = false;
            setSearchResults();
            dataGridViewResult.DataSource = searchResult;
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
                       
            if (textBoxSearchData != null)
            {
                //Regex regex = new Regex(textBoxSearchData.Text);
                foreach (DataRow r in SalaryRateForm.t.Rows)
                {
                    foreach (string str in r.ItemArray)
                    {
                        if (textBoxSearchData.Text == str)
                        {
                            searchResult.Rows.Add(r["Surname"], r["Name"], r["Pay amount"]);
                            // break;
                        }
                    }
                }
            }
       }
    }
}
