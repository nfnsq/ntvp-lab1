using System;
using System.Windows.Forms;

namespace SalaryRateModel
{
    /// <summary>
    /// Сущность для описания сотрудника с типом 
    /// начисления зарплаты по почасовой оплате
    /// </summary>
    public class HourlyRate : Employee
    {
        public HourlyRate()
        {

        }
        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public HourlyRate(params Parameter[] list)
        {
            Validator control = new Validator();
            if (control.Validating(list))
            {
                Parameters = list;
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
        /// Реализация абстрактного метода базового класса,
        /// в котором расчитывается сумма заплаты по типу начисления
        /// - почасовая оплата
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return Parameters[0].Value * Parameters[1].Value;
            }
            catch
            {
                return 0;
            }
        }
    }
}
