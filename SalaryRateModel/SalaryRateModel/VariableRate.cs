using System;
using Global;
using System.Windows.Forms;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по ставке
    /// </summary>
    public class VariableRate : Employee
    {
        public VariableRate()
        {

        }

        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public VariableRate(params Parameter[] list)
        {
            DataController.Validator control = new DataController.Validator();
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
        /// Метод возвращает сумму зарплаты по ставке
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return Parameters[2].Value / 20 * Parameters[0].Value * Parameters[1].Value;
            }
            catch
            {
                return 0;
            }
        }
    }
}
