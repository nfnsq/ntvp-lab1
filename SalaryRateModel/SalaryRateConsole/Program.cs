using System;
using SalaryRateModel;

namespace SalaryRateConsole
{
    class Program
    {
        /// <summary>
        /// Метод для проверки вводимых данных
        /// </summary>
        /// <returns></returns>
        static double ReadData()
        {
            double data = 0;
            try
            {
                data = double.Parse(Console.ReadLine());
                if (data <= 0 || data > 10000000)
                    throw new Exception();
            }
            catch(FormatException)
            {
                Console.WriteLine("Match Format Exception! \nEnter correct data:");
                data = ReadData();
            }
            catch(Exception)
            {
                Console.WriteLine("Match Exception!\n" +
                    "This value should be more than 0 and less than 1000000\n" +
                    "Enter correct data:");
                data = ReadData();
            }
            return data;
        }
        /// <summary>
        /// В методе main вычисляется сумма заработной платы в зависимости
        /// от типа начисления
        /// </summary>
        static void Main()
        {
            IEmployee payAmount = null;
            int way = 0;
            Console.WriteLine("Select type of rate:");
            while (way != 1 && way != 2 && way != 3 && way != 4)
            {
                Console.WriteLine("1 - Fixed Rate\n" +
                    "2 - Variable Rate\n" +
                    "3 - Hourly Rate\n" +
                    "4 - Exit");
                try 
                {
                    way = int.Parse(Console.ReadLine());
                    if (way != 1 && way != 2 && way != 3 && way != 4)
                        throw new Exception();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Get Format Exception. Enter correct data!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Get Exception. Enter Correct data!");
                }
            }
            switch (way)
            {
                case 1:
                    //вводд данных
                    Console.WriteLine("Enter salary:");
                    double salary = ReadData();
                    Console.WriteLine("Enter amount worked day:");
                    double amountDay = ReadData();
                    //создание экземпляра класса Fixed Rate
                    payAmount = new FixedRate(salary, amountDay);
                    break;
                case 2:
                    //ввод данных
                    Console.WriteLine("Enter salary:");
                    double salary1 = ReadData();
                    Console.WriteLine("Enter amount worked day:");
                    double amountDay1 = ReadData();
                    Console.WriteLine("Enter coeficient of rate:");
                    double rate = ReadData();
                    //создание экземпляра класса Variable Rate
                    payAmount = new VariableRate(salary1, amountDay1, rate);
                    break;
                case 3:
                    //ввод данных
                    Console.WriteLine("Enter paid per hour:");
                    double paidPerHour = ReadData();
                    Console.WriteLine("Enter amount of worked hour:");
                    double hourAmount = ReadData();
                    //создание экземпляра класса Hourly Rate
                    payAmount = new HourlyRate(paidPerHour, hourAmount);
                    break;
                case 4:
                    break;
            }
            if (payAmount != null)
            {
                Console.WriteLine("Paid amount of salary:" + payAmount.GetSummOfPay());
                Console.ReadLine();
            }
        }
    }
}
