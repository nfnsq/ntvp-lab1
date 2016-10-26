using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryRateModel
{
    public class FixedRate : IPay
    {
        private double _salary;
        private double _amountDay;
        /// <summary>
        /// Определение параметризированного конструктора класса для инициализации объекта
        /// </summary>
        /// <param name="salary">Оклад</param>
        /// <param name="amountDay">Количество проработанных дней</param>
        public FixedRate(double salary, double amountDay)
        {
            this._salary = salary;
            this._amountDay = amountDay;
        }

        /// <summary>
        /// Реализация метода интерфейса ISalary
        /// </summary>
        /// <returns>Сумма заработной платы</returns>
        public double GetSumm()
        {
            return _salary / 20 * _amountDay;
        }

    }
}
