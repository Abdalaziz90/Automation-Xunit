using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;

namespace XUnitDemo.Setup_QA_JustDev
{
    public class Localization : IClassFixture<WebDriverFixture>
    {
        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public Localization(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassQAJustLocalization()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://qa.justdevelopmentjo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[3]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(), 'تهيئة')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'ترجمة الصفحات')]/preceding-sibling::i")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حفظ')]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list >>

            IWebElement dropdown = driver.FindElement(By.XPath("//span[@class='e-input-group-icon e-ddl-icon e-icons e-ddl-disable-icon']"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(15000);
            // Select hidden option
            IList<IWebElement> hiddenOptions = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));
            Random ran = new Random();
            int num = ran.Next(0, hiddenOptions.Count);
            hiddenOptions[num].Click();

            driver.FindElement(By.XPath("//textarea[@id='RESOURCENAME']")).SendKeys("Test");
            driver.FindElement(By.XPath("//textarea[@id='RESOURCEVALUE']")).SendKeys("Test");
            driver.FindElement(By.XPath("//button[contains(text(),'حفظ')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'خروج')]")).Click();

            // Post, Edit , Delete , Unpost , Edit , Delete >>

            // select on record >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            // POST
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-delete btn-md m-2']/following-sibling::button[@class='e-control e-btn e-lib btn btn-report btn-md m-2']")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // EDIT

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//textarea[@id='RESOURCENAME']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='RESOURCENAME']")).SendKeys("Test One");
            driver.FindElement(By.XPath("//button[contains(text(),'حفظ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'خروج')]")).Click();
            Thread.Sleep(5000);

            // Delete 
            //driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),' ')]/preceding-sibling::button[2]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // UNPOST 
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[3]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // EDIT
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//textarea[@id='RESOURCENAME']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='RESOURCENAME']")).SendKeys("Test One");
            driver.FindElement(By.XPath("//button[contains(text(),'حفظ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'خروج')]")).Click();
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
