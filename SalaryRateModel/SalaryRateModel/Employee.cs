using System.Xml.Serialization;
using System.Collections.Generic;

namespace SalaryRateModel
{
    /// <summary>
    /// Сущность для описания абстракного сотрудника
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// Абстрактный метод для расчета зарплаты сотрудника
        /// </summary>
        /// <returns></returns>
        public abstract double GetSummOfPay();

        /// <summary>
        /// Данные для расчета зарплаты сотрудника
        /// </summary>
        public Parameter[] Parameters { get; set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string Surname { get; set; }
    }
}
