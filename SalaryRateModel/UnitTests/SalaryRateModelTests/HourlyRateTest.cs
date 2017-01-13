using NUnit.Framework;
using SalaryRateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.SalaryRateModelTests
{
    [TestFixture]
    class HourlyRateTest
    {
        [TestCase(101, 1, 101, TestName = "Тест при значениях параметров 101 и 1")]
        [TestCase(1, 1, 0, TestName = "Тест при значениях параметров равных 1")]
        [TestCase(double.MinValue, double.MinValue, 0,
            TestName = "Тест при значениях параметров равных MinValue")]
        [TestCase(double.MinValue - 1, double.MinValue - 1, 0,
            TestName = "Тест при значениях параметров равных MinValue - 1")]
        [TestCase(double.MaxValue, double.MaxValue, 0,
            TestName = "Тест при значениях параметров равных MaxValue")]
        [TestCase(double.MaxValue + 1, double.MaxValue + 1, 0,
            TestName = "Тест при значениях параметров равных MaxValue + 1")]
        [TestCase(0, 0, 0, TestName = "Тест при значениях параметров равных 0")]
        [TestCase(double.NaN, double.NaN, 0, TestName = "Тест при значениях параметров равных NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, 0,
            TestName = "Тест при значениях параметров равных NegativeInfinity")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, 0,
            TestName = "Тест при значениях параметров равных PositiveInfinity")]
        public void HourlyRate(double paidPerHour, double hourAmount, double res)
        {
            Parameter _paidPerHour = new Parameter();
            Parameter _hourAmount = new Parameter();
            _paidPerHour.Value = paidPerHour;
            _paidPerHour.Description = SalaryRateModel.Properties.Resources.PaidPerHour;
            _hourAmount.Value = hourAmount;
            _hourAmount.Description = SalaryRateModel.Properties.Resources.HourAmount;

            HourlyRate pay = new HourlyRate(_paidPerHour, _hourAmount);

            double result = pay.GetSummOfPay();

            Assert.AreEqual(res, result);
        }
    }
}
