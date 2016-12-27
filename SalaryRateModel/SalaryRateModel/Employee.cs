using Global;

namespace SalaryRateModel
{
    /// <summary>
    /// Класс Сотрудник
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Метод возвращает сумму зарплаты для
        /// абстрактного класса Сотрудник
        /// </summary>
        /// <returns></returns>
        public abstract double GetSummOfPay();
        public abstract Parameter[] Parameters{ get; }
        
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _surname;
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
    }
}
