using System;
using Global;
using System.Windows.Forms;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс, где рассчитывается сумма зарплаты по окладу
    /// </summary>
    public class FixedRate : Employee
    {
        public FixedRate()
        {

        }
        /// <summary>
        /// Параметризированный конструктор класса
        /// </summary>
        /// <param name="list">Список входных параметров</param>
        public FixedRate(params Parameter[] list)
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
        /// Метод возвращает сумму зарплаты по окладу
        /// </summary>
        public override double GetSummOfPay()
        {
            try
            {
                return Parameters[1].Value / 20 * Parameters[0].Value;
            }
            catch
            {
                return 0;
            }
        }
        
    }
}
