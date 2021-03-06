﻿using NUnit.Framework;
using OpenQA.Selenium;

namespace PrimeiroTesteAutomatizado.Atividade1
{
    [TestFixture]
    public class TestValidaTextoJsPromptOk : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            AbreUrl("http://the-internet.herokuapp.com/javascript_alerts");
            IWebElement botaoJsPrompt = driver.FindElement(By.CssSelector("button[onclick='jsPrompt()']"));
            botaoJsPrompt.Click();
            IAlert result = driver.SwitchTo().Alert();
            Assert.AreEqual("I am a JS prompt", result.Text);
            result.SendKeys("Alucinado");
            result.Accept();
            IWebElement mensagemConfirmacao = driver.FindElement(By.CssSelector("#result"));
            Assert.AreEqual("You entered: Alucinado", mensagemConfirmacao.Text);
        }
    }
}
