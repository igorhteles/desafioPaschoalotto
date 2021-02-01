using desafioPaschoalotto.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace desafioPaschoalotto.Steps
{
    [Binding]
     class BuscaDeProdutosSteps : sitePage
    {
        string descProduto;

        public IWebDriver driver;

        [Given(@"que acesse o site da loja")]
        public void DadoQueAcesseOSiteDaLoja()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://magazineluiza.com.br");
        }
        
        [When(@"pesquisar pelo '(.*)'")]
        public void QuandoPesquisarPelo(string produto)
        {
            descProduto = produto;

            driver.FindElement(By.Id(inputBuscar)).SendKeys(descProduto);
            driver.FindElement(By.Id(buttonBuscar)).Click();
        }

        [Then(@"o produto pesquisado deve estar visível")]
        public void EntaoOProdutoPesquisadoDeveEstarVisivel()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            string texto = driver.FindElement(By.XPath(headerSearch)).Text;
            Assert.AreEqual(descProduto, texto);
            driver.Quit();
        }
    }
}
