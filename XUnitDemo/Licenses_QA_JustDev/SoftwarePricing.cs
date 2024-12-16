using OpenQA.Selenium;
using Xunit.Abstractions;

namespace XUnitDemo.Licenses_QA_JustDev
{
    public class SoftwarePricing : IClassFixture<WebDriverFixture>
    {

        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public SoftwarePricing(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassQaJustSoftwarePricing()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://qa.justdevelopmentjo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[6]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"system\"]/a//following-sibling::span[contains(text(), 'رخص')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'تسعيرة البرنامج')]")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list >>
            IWebElement dropdown = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div.form-SOFTWAREPRICING > div > div:nth-child(1) > div"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(15000);
            // Select hidden option
            IList<IWebElement> hiddenOptions = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran = new Random();
            int numList = ran.Next(0, hiddenOptions.Count);
            hiddenOptions[numList].Click();

            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();

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
            // page simple on count
            IWebElement fillonCountPage = driver.FindElement(By.XPath("//input[@id='SIMPLEPAGENUMBER']"));
            int numPage = 5;
            fillonCountPage.SendKeys(numPage.ToString());
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[1]")).Click();
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
            // page simple on count
            IWebElement fillonCountPage1 = driver.FindElement(By.XPath("//input[@id='SIMPLEPAGENUMBER']"));
            int numPage1 = 3;
            fillonCountPage1.SendKeys(numPage1.ToString());
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
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