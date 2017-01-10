using System;
using SalaryRateModel;

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
        private string RandomName()
        {
            Random RandomName = new Random();
            return _personNames[RandomName.Next(_personNames.Length)];
        }

        /// <summary>
        /// Генерация случайной фамилии
        /// </summary>
        /// <returns></returns>
        private string RandomSurname()
        {
            Random RandomSurname = new Random();
            return _personSurnames[RandomSurname.Next(_personSurnames.Length)];
        }

        /// <summary>
        /// Генерация случайного оклада
        /// </summary>
        /// <returns></returns>
        private string Salary()
        {
            Random salaryRandom = new Random();
            return Convert.ToString(salaryRandom.Next(10000, 999999));
            
        }

        /// <summary>
        /// Генерация случайного количества дня
        /// </summary>
        /// <returns></returns>
        private string AmountDay()
        {
            Random amountDayRandom = new Random();
            return Convert.ToString(amountDayRandom.Next(1, 369));

        }

        /// <summary>
        /// Генерация случайного тарифа
        /// </summary>
        /// <returns></returns>
        private string PaidPH()
        {            
            Random paidPerHourRandom = new Random();
            return Convert.ToString(paidPerHourRandom.Next(100, 9999));
        }

        /// <summary>
        /// Генерация случайного количества отработанного часа
        /// </summary>
        /// <returns></returns>
        private string HourAmount()
        {

            Random hourAmountRandom = new Random();
            return Convert.ToString(hourAmountRandom.Next(1, 199));

        }

        /// <summary>
        /// Генерация случайной ставки
        /// </summary>
        /// <returns></returns>
        private string Rate()
        {
            Random rateRandom = new Random();
            return ((double)rateRandom.Next(1, 9) / 10).ToString();
        }
        
        public Employee GetRandomPerson()
        {
            Random keyRand = new Random();
            int key = keyRand.Next(3);

            Employee random = null;
            int size = 0;
            SalaryRateModel.Parameter[] paramters = new SalaryRateModel.Parameter[size];
            switch(key)
            {
                case 0:
                    size = 2;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(Salary());
                    paramters[1].Value = double.Parse(AmountDay());
                    paramters[0].Description = SalaryRateModel.Properties.Resources.Salary;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.DayAmount;

                    random = new FixedRate(paramters);
                    random.Surname = RandomSurname();
                    random.Name = RandomName();
                    return random;
                case 1:
                    size = 3;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(Salary());
                    paramters[1].Value = double.Parse(AmountDay());
                    paramters[2].Value = double.Parse(Rate());

                    paramters[0].Description = SalaryRateModel.Properties.Resources.Salary;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.DayAmount;
                    paramters[2].Description = SalaryRateModel.Properties.Resources.Rate;

                    random = new VariableRate(paramters);
                    random.Surname = RandomSurname();
                    random.Name = RandomName();
                    return random;
                case 2:
                    size = 2;
                    Array.Resize<SalaryRateModel.Parameter>(ref paramters, size);
                    paramters[0].Value = double.Parse(HourAmount());
                    paramters[1].Value = double.Parse(PaidPH());
                    paramters[0].Description = SalaryRateModel.Properties.Resources.HourAmount;
                    paramters[1].Description = SalaryRateModel.Properties.Resources.PaidPerHour;

                    random = new HourlyRate(paramters);
                    random.Surname = RandomSurname();
                    random.Name = RandomName();
                    return random;
            }
            return null;
        }
    }
}
