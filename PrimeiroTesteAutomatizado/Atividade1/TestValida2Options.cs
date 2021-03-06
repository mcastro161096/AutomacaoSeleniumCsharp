﻿using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace PrimeiroTesteAutomatizado.Atividade1
{
    [TestFixture]
    public class TestValida2Options : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            AbreUrl(" http://the-internet.herokuapp.com/dropdown");
            IWebElement dropdown = driver.FindElement(By.CssSelector("select[id = 'dropdown']"));
            dropdown.Click();
            IWebElement option2 = driver.FindElement(By.XPath("//select/option[3]"));
            option2.Click();
            bool check = driver.FindElement(By.CssSelector("select>option[value='2']")).Selected;

            Thread.Sleep(5000);
        }
    }
}
