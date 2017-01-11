namespace SalaryRateModel
{
    /// <summary>
    /// Сущность для описания параметров 
    /// для вычисления суммы зарплаты сотрудника
    /// </summary>
    public struct Parameter
    {
        private double _value;
        /// <summary>
        /// Значение параметра
        /// </summary>
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        private string _description;
        /// <summary>
        /// Описание параметра
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
