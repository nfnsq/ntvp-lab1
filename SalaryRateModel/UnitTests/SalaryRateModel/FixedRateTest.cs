﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryRateModel;

namespace UnitTests.SalaryRateModel
{
    [TestFixture]
    class FixedRateTest
    {
        [TestCase(1, 1, 0.05,TestName = "Тест при значениях параметров равных 1")]
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
        public void FixedRate(double salary, double amountDay, double res)
        {
            Global.Parameter _salary = new Global.Parameter();
            Global.Parameter _amountDay = new Global.Parameter();
            _salary.Value = salary;
            _salary.Description = Global.Properties.Resources.Salary;
            _amountDay.Value = amountDay;
            _amountDay.Description = Global.Properties.Resources.DayAmount;

            FixedRate pay = new FixedRate(_salary, _amountDay);
            
            double result = pay.GetSummOfPay();

            Assert.AreEqual(result, res);
        }
    }
}
