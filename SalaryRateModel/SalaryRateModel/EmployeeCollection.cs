using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SalaryRateModel
{
    public class EmployeeCollection
    {
        private List<Employee> _collection;
        [XmlArray("Collection"), 
        XmlArrayItem("Fixed", typeof(FixedRate)),
        XmlArrayItem("Hourly", typeof(HourlyRate)),
        XmlArrayItem("Variable", typeof(VariableRate))]
        public List<Employee> Collection
        { 
            get 
            {
                return _collection;
            } 
        }

        public EmployeeCollection()
        {
            _collection = new List<Employee>();
        }
    }
}
