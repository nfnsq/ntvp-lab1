using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryRateModel
{
    /// <summary>
    /// 
    /// </summary>
    public class VariableRate : IPay
    {
        private double _salary;
        private double _amountDay;
        private double _rate;
        /// <summary>
        /// Определение параметризированного конструктора класса для инициализации объекта
        /// </summary>
        /// <param name="salary">Оклад</param>
        /// <param name="amountDay">Количество проработанных дней</param>
        /// <param name="rate">Ставка</param>
        public VariableRate(double salary, double amountDay, double rate)
        {
            this._salary = salary;
            this._amountDay = amountDay;
            this._rate = rate;
        }

        /// <summary>
        /// Реализация метода интерфейса ISalary
        /// </summary>
        /// <returns>Сумма заработной платы</returns>
        public double GetSumm()
        {
            return _salary / 20 * _amountDay * _rate;
        }

    }
}
