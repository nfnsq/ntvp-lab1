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
           for (int i = 0; i < list.Length; i++)
           {
               if (list[i].Description == Global.Properties.Resources.Salary)
               {
                   if (!Check(list[i].Value, 10000, 999999))
                   {
                       return false;
                   }
               }
               if (list[i].Description == Global.Properties.Resources.Rate)
               {
                   if (!Check(list[i].Value, 0, 1))
                   {
                       return false;
                   }
               }
               if (list[i].Description == Global.Properties.Resources.PaidPerHour)
               {
                   if (!Check(list[i].Value, 100, 9999))
                   {
                       return false;
                   }
               }
               if (list[i].Description == Global.Properties.Resources.HourAmount)
               {
                   if (!Check(list[i].Value, 1, 199))
                   {
                       return false;
                   }
               }
               if (list[i].Description == Global.Properties.Resources.DayAmount)
               {
                   if (!Check(list[i].Value, 1, 369))
                   {
                       return false;
                   }
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
