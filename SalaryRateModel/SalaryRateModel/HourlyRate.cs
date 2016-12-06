using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по почасовой оплате
    /// </summary>
    public class HourlyRate : IEmployee
    {
        private double _paidPerHour;    //тариф за час
        private double _hourAmount;     //количество проработанных часов
        private string _personName;
        private string _personSurname;

        /// <summary>
        /// Определение параметризированного конструктора класса для инициализации объекта
        /// </summary>
        /// <param name="paidPerHour">Тариф</param>
        /// <param name="hourAmount">Количество проработанных часов</param>
        public HourlyRate(double paidPerHour, double hourAmount)
        {
            this._paidPerHour = paidPerHour;
            this._hourAmount = hourAmount;
        }
        /// <summary>
        /// Реализация метода интерфейса ISalary
        /// </summary>
        /// <returns>Сумма заработной платы</returns>
        public double GetSummOfPay()
        {
            return _paidPerHour * _hourAmount;
        }
    }
}
