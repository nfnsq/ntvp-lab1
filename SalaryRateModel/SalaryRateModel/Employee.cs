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

        private Parameter[] _parameters;
        /// <summary>
        /// Данные для расчета зарплаты сотрудника
        /// </summary>
        public Parameter[] Parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }
        
        private string _name;
        /// <summary>
        /// Имя сотрудника
        /// </summary>
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
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
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
