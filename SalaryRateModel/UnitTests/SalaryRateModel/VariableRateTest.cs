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
        [TestCase(1, 1, 1, TestName="Тест при параметрах равных 1")]
        [TestCase(double.MinValue, double.MinValue, double.MinValue,
            TestName = "Тест при параметрах равных MinValue")]
        [TestCase(double.MinValue - 1, double.MinValue - 1, double.MinValue - 1,
            TestName = "Тест при параметрах равных MinValue - 1")]
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue,
            TestName = "Тест при параметрах равных MaxValue")]
        [TestCase(double.MaxValue + 1, double.MaxValue + 1, double.MaxValue + 1,
            TestName = "Тест при параметрах равных MaxValue + 1")]
        [TestCase(0, 0, 0, TestName = "Тест при параметрах равных 0")]
        [TestCase(double.NaN, double.NaN, double.NaN, TestName = "Тест при ставке равном NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
            TestName = "Тест при параметрах равных NegativeInfinity")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            TestName = "Тест при параметрах равных PositiveInfinity")]
        public void VariableRate(double salary, double amountDay, double rate)
        {
            VariableRate pay = new VariableRate(salary, amountDay, rate);

            double result = pay.GetSummOfPay();

            var res = salary / 20 * amountDay * rate;

            Assert.AreEqual(result, res);
        }
    }
}
