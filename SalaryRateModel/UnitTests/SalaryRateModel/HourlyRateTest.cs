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
        [TestCase(1, 1, 1, TestName = "Тест при значениях параметров равных 1")]
        [TestCase(double.MinValue, double.MinValue, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных MinValue")]
        [TestCase(double.MinValue - 1, double.MinValue - 1, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных MinValue - 1")]
        [TestCase(double.MaxValue, double.MaxValue, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных MaxValue")]
        [TestCase(double.MaxValue + 1, double.MaxValue + 1, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных MaxValue + 1")]
        [TestCase(0, 0, 0, TestName = "Тест при значениях параметров равных 0")]
        [TestCase(double.NaN, double.NaN, double.NaN, TestName = "Тест при значениях параметров равных NaN")]
        [TestCase(double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных NegativeInfinity")]
        [TestCase(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
            TestName = "Тест при значениях параметров равных PositiveInfinity")]
        public void HourlyRate(double paidPerHour, double hourAmount, double res)
        {
            Global.Parameter _paidPerHour = new Global.Parameter();
            Global.Parameter _hourAmount = new Global.Parameter();
            _paidPerHour.Value = paidPerHour;
            _paidPerHour.Description = Global.Properties.Resources.PaidPerHour;
            _hourAmount.Value = hourAmount;
            _hourAmount.Description = Global.Properties.Resources.HourAmount;

            HourlyRate pay = new HourlyRate(_paidPerHour, _hourAmount);

            double result = pay.GetSummOfPay();

            Assert.AreEqual(result, res);
        }
    }
}
