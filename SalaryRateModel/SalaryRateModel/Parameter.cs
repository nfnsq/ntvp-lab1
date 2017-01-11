namespace SalaryRateModel
{
    /// <summary>
    /// Сущность для описания параметров 
    /// для вычисления суммы зарплаты сотрудника
    /// </summary>
    public struct Parameter
    {
        /// <summary>
        /// Значение параметра
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Описание параметра
        /// </summary>
        public string Description { get; set; }
    }
}
