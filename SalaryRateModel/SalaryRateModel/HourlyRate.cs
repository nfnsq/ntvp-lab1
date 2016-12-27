﻿using System;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по почасовой оплате
    /// </summary>
    public class HourlyRate : Employee
    {
        private double[] _list = new double[0];

        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public HourlyRate(params double[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Array.Resize<double>(ref _list, i + 1);
                this._list[i] = list[i];
            }
        }

        /// <summary>
        /// Метод возвращает сумму зарплаты по почасовой оплате
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return _list[0] * _list[1];
            }
            catch
            {
                return 0;
            }
        }
    }
}
