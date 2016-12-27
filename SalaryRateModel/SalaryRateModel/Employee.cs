namespace SalaryRateModel
{
    /// <summary>
    /// Интерфейс Сотрудник
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Метод возвращает сумму зарплаты для
        /// интерфейса Сотрудник
        /// </summary>
        /// <returns></returns>
        public abstract double GetSummOfPay();

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
