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
    class HourlyRateTest
    {
        [TestCase(1, 1, TestName = "Тест при значениях параметров равных 1")]
        [TestCase(double.MinValue, double.MinValue,
            TestName = "Тест при значениях параметров равных MinValue")]
        [TestCase(double.MinValue - 1, double.MinValue - 1,
            TestName = "Тест при значениях параметров равных MinValue - 1")]
        [TestCase(double.MaxValue, double.MaxValue,
            TestName = "Тест при значениях параметров равных MaxValue")]
        [TestCase(double.MaxValue + 1, double.MaxValue + 1,
            TestName = "Тест при значениях параметров равных MaxValue + 1")]
        [TestCase(0, 0, TestName = "Тест при значениях параметров равных 0")]
        [TestCase(double.NaN, double.NaN, TestName = "Тест при значениях параметров равных NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity,
            TestName = "Тест при значениях параметров равных NegativeInfinity")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных PositiveInfinity")]
        public void HourlyRate(double paidPerHour, double hourAmount)
        {
            HourlyRate pay = new HourlyRate(paidPerHour, hourAmount);

            double result = pay.GetSummOfPay();

            var res = paidPerHour * hourAmount;

            Assert.AreEqual(result, res);
        }
    }
}
