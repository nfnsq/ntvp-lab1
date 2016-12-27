using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryRateModel;

namespace View
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }
        private Employee _employee;

        public Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                _employee = value;
            }
        }
        public bool ReadOnly
        {
            get
            {
                return ReadOnly;
            }
            set
            {
                if (value == true)
                {
                    foreach (ObjectControl textbox in this.Controls)
                        textbox.ReadOnly = true;
                }
                else
                {
                    foreach (ObjectControl textbox in this.Controls)
                        textbox.ReadOnly = false;
                }
            }
        }
    }
}
