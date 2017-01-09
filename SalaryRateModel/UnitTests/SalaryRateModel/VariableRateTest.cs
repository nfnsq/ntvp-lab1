using NUnit.Framework;
using SalaryRateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.SalaryRateModel
{
    [TestFixture]
    class VariableRateTest
    {
        [TestCase(10001, 1, 0.5, 250.025, TestName = "Тест при параметрах 10001, 1 и 0.5")]
        [TestCase(1, 1, 1, 0, TestName = "Тест при параметрах равных 1")]
        [TestCase(double.MinValue, double.MinValue, double.MinValue, 0,
            TestName = "Тест при параметрах равных MinValue")]
        [TestCase(double.MinValue - 1, double.MinValue - 1, double.MinValue - 1, 0,
            TestName = "Тест при параметрах равных MinValue - 1")]
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue, 0,
            TestName = "Тест при параметрах равных MaxValue")]
        [TestCase(double.MaxValue + 1, double.MaxValue + 1, double.MaxValue + 1, 0,
            TestName = "Тест при параметрах равных MaxValue + 1")]
        [TestCase(0, 0, 0, 0, TestName = "Тест при параметрах равных 0")]
        [TestCase(double.NaN, double.NaN, double.NaN, 0, TestName = "Тест при ставке равном NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, 0,
            TestName = "Тест при параметрах равных NegativeInfinity")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, 0,
            TestName = "Тест при параметрах равных PositiveInfinity")]
        public void VariableRate(double salary, double amountDay, double rate, double res)
        {
            Global.Parameter _salary = new Global.Parameter();
            Global.Parameter _amountDay = new Global.Parameter();
            Global.Parameter _rate = new Global.Parameter();
            _salary.Value = salary;
            _salary.Description = Global.Properties.Resources.Salary;
            _amountDay.Value = amountDay;
            _amountDay.Description = Global.Properties.Resources.DayAmount;
            _rate.Value = rate;
            _rate.Description = Global.Properties.Resources.Rate;
            
            VariableRate pay = new VariableRate(_salary, _amountDay, _rate);

            double result = pay.GetSummOfPay();

            Assert.AreEqual(res, result);
        }
    }
}
