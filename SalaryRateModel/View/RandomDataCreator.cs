using System;

namespace View
{
    /// <summary>
    /// Класс для создания случайных значений
    /// </summary>
    class RandomDataCreator
    {
        /// <summary>
        /// Массив из Имен и Фамилий
        /// </summary>
        private string[] _personNames = { "Alice", "Bob", "Cara", "Dean", "Bruce" };
        private string[] _personSurnames = { "Wayne", "Hunter", "Bee", "Tatch", "Sean" };

        /// <summary>
        /// Генерация случайного имени 
        /// </summary>
        /// <returns></returns>
        public string RandomName()
        {
            Random RandomName = new Random();
            return _personNames[RandomName.Next(_personNames.Length)];
        }

        /// <summary>
        /// Генерация случайной фамилии
        /// </summary>
        /// <returns></returns>
        public string RandomSurname()
        {
            Random RandomSurname = new Random();
            return _personSurnames[RandomSurname.Next(_personSurnames.Length)];
        }

        /// <summary>
        /// Генерация случайного оклада
        /// </summary>
        /// <returns></returns>
        public string Salary()
        {
            Random salaryRandom = new Random();
            return Convert.ToString(salaryRandom.Next(10000, 999999));
            
        }

        /// <summary>
        /// Генерация случайного количества дня
        /// </summary>
        /// <returns></returns>
        public string AmountDay()
        {
            Random amountDayRandom = new Random();
            return Convert.ToString(amountDayRandom.Next(1, 369));

        }

        /// <summary>
        /// Генерация случайного тарифа
        /// </summary>
        /// <returns></returns>
        public string PaidPH()
        {            
            Random paidPerHourRandom = new Random();
            return Convert.ToString(paidPerHourRandom.Next(100, 9999));
        }

        /// <summary>
        /// Генерация случайного количества отработанного часа
        /// </summary>
        /// <returns></returns>
        public string HourAmount()
        {

            Random hourAmountRandom = new Random();
            return Convert.ToString(hourAmountRandom.Next(1, 199));

        }

        /// <summary>
        /// Генерация случайной ставки
        /// </summary>
        /// <returns></returns>
        public string Rate()
        {
            Random rateRandom = new Random();
            return Convert.ToString(rateRandom.Next(1, 9));
        }
        
    }
}
