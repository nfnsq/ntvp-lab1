using System;
using Global;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по почасовой оплате
    /// </summary>
    public class HourlyRate : Employee
    {
        private Parameter[] _list = new Parameter[0];

        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public HourlyRate(params Parameter[] list)
        {
            DataController.Validator control = new DataController.Validator();
            if (control.Validating(list))
            {
                for (int i = 0; i < list.Length; i++)
                {
                    Array.Resize<Parameter>(ref _list, i + 1);
                    this._list[i] = list[i];
                }
            }
            else
            {
                #if !DEBUG
                MessageBox.Show("Invalid data. Please, try again.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                #endif
            }
        }

        /// <summary>
        /// Метод возвращает сумму зарплаты по почасовой оплате
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return _list[0].Value * _list[1].Value;
            }
            catch
            {
                return 0;
            }
        }
        public override Parameter[] Parameters
        {
            get
            {
                return _list;
            }
        }
    }
}
