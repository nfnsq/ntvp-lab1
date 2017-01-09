using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global;


namespace DataController
{
    public class Validator
    {
        public bool Validating(Parameter[] list)
        {
            var tuple = new Dictionary<string,Tuple<int, int>>();
            tuple.Add(Global.Properties.Resources.Salary, new Tuple<int,int> (10000, 999999));
            tuple.Add(Global.Properties.Resources.Rate, new Tuple<int, int>(0, 1));
            tuple.Add(Global.Properties.Resources.PaidPerHour, new Tuple<int, int>(100, 9999));
            tuple.Add(Global.Properties.Resources.HourAmount, new Tuple<int, int>(0, 199));
            tuple.Add(Global.Properties.Resources.DayAmount, new Tuple<int, int>(0, 369));

            for (int i = 0; i < list.Length; i++)
            {
                var tmp = tuple[list[i].Description];

                if (!Check(list[i].Value, tmp.Item1, tmp.Item2))
                {
                    return false;
                }
            }
           return true;
        }

        private bool Check(double value, double min, double max)
        {
            if ((value < min) || (value > max))
            {
                return false;
            }
            else if (double.IsNaN(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
