using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace XUnitDemo.Licenses_QA_JustDev
{
    public class RequestLicenseKey : IClassFixture<WebDriverFixture>
    {
        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public RequestLicenseKey(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassQaJustRequestKey()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://qa.justdevelopmentjo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[12]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"system\"]/a//following-sibling::span[contains(text(), 'رخص')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'طلب تسجيل')]/preceding-sibling::i")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list Contract >>

            IWebElement dropdownContract = driver.FindElement(By.XPath("//div[@class=' col-12 col-sm-6 col-md-4 col-lg-6']/div"));
            dropdownContract.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(3000);

            // Select hidden option Licensce
            IList<IWebElement> hiddenOptionsContract = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran = new Random();
            int numListContract = ran.Next(0, hiddenOptionsContract.Count);
            hiddenOptionsContract[numListContract].Click();

            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(), 'خروج')]")).Click();

            // Post, Edit , Delete , Unpost , Edit , Delete >>

            // select on record >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            // POST
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[2]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // EDIT

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);

            // dropdown list Contract >>

            IWebElement dropdownContract1 = driver.FindElement(By.XPath("//div[@class=' col-12 col-sm-6 col-md-4 col-lg-6']/div"));
            dropdownContract1.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            // Select hidden option Licensce
            IList<IWebElement> hiddenOptionsContract1 = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran1 = new Random();
            int numListContract1 = ran.Next(0, hiddenOptionsContract1.Count);
            hiddenOptionsContract1[numListContract1].Click();

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(), 'خروج')]")).Click();
            Thread.Sleep(5000);

            // Delete 
            //driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-delete btn-md m-2']")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // UNPOST 
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[3]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // EDIT

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);
            // dropdown list Contract >>

            IWebElement dropdownContract13 = driver.FindElement(By.XPath("//div[@class=' col-12 col-sm-6 col-md-4 col-lg-6']/div"));
            dropdownContract13.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            // Select hidden option Licensce
            IList<IWebElement> hiddenOptionsContract13 = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran13 = new Random();
            int numListContract13 = ran.Next(0, hiddenOptionsContract13.Count);
            hiddenOptionsContract13[numListContract13].Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(), 'خروج')]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[1]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();
        }
    }
}
