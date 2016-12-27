using System;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по
    /// ставке
    /// </summary>
    public class VariableRate : Employee
    {
        private double[] _list = new double[0];

        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public VariableRate(params double[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Array.Resize<double>(ref _list, i + 1);
                this._list[i] = list[i];
            }
        }

        /// <summary>
        /// Метод возвращает сумму зарплаты по ставке
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return _list[2] / 20 * _list[0] * _list[1];
            }
            catch
            {
                return 0;
            }
        }
    }
}
