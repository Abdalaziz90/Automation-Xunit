using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Xunit.Abstractions;

namespace XUnitDemo.Licenses_QA_JustDev
{
    public class SystemLicense : IClassFixture<WebDriverFixture>
    {
        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public SystemLicense(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassQaJustLicenseSystem()
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
            driver.FindElement(By.XPath("//span[contains(text(),'رخصة النظام')]/preceding-sibling::i")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list Licensce >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(".//*[@class='e-ddl e-lib e-input-group e-control-container e-control-wrapper e-rtl e-float-input e-icon-anim valid']")).Click();

            //IWebElement dropdownLicensce = driver.FindElement(By.XPath(".//*[@class='e-ddl e-lib e-input-group e-control-container e-control-wrapper e-rtl e-float-input e-icon-anim valid']"));

            //dropdownLicensce.Click();  // assuming you have to click the "dropdown" to open it
            //dropdownLicensce.SendKeys(Keys.Down); 

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(3000);

            // Select hidden option Licensce
            IList<IWebElement> hiddenOptionsLicensce = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran = new Random();
            int numListLicensce = ran.Next(0, hiddenOptionsLicensce.Count);
            hiddenOptionsLicensce[numListLicensce].Click();

            // dropdown list System >>

            IWebElement dropdownSystem = driver.FindElement(By.CssSelector("#dropdownlist-56070eef-7ed4-4df7-9257-01646fe4db0f"));
            dropdownSystem.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            // Select hidden option System
            IList<IWebElement> hiddenOptionsSystem = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranSys = new Random();
            int numListSystem = ran.Next(0, hiddenOptionsSystem.Count);
            hiddenOptionsSystem[numListSystem].Click();

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
            // dropdown list System >>

            IWebElement dropdownSystem1 = driver.FindElement(By.CssSelector("#dialog-a4ff2fe1-be3f-4ad5-8f28-1923c7014d03_dialog-content > form > div.form-SYSTEMLICENSE > div > div:nth-child(2) > div.e-ddl.e-lib.e-error.e-input-group.e-control-container.e-control-wrapper.e-rtl.e-float-input.e-icon-anim.invalid"));
            dropdownSystem1.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            // Select hidden option System
            IList<IWebElement> hiddenOptionsSystem1 = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranSys1 = new Random();
            int numListSystem1 = ran.Next(0, hiddenOptionsSystem1.Count);
            hiddenOptionsSystem1[numListSystem1].Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//button[contains(text(), 'حفظ')]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(), 'خروج')]")).Click();
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
            // dropdown list System >>

            IWebElement dropdownSystemNew = driver.FindElement(By.CssSelector("#dialog-a4ff2fe1-be3f-4ad5-8f28-1923c7014d03_dialog-content > form > div.form-SYSTEMLICENSE > div > div:nth-child(2) > div.e-ddl.e-lib.e-error.e-input-group.e-control-container.e-control-wrapper.e-rtl.e-float-input.e-icon-anim.invalid"));
            dropdownSystemNew.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            // Select hidden option System
            IList<IWebElement> hiddenOptionsSystemNew = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranSysNew = new Random();
            int numListSystemNew = ran.Next(0, hiddenOptionsSystemNew.Count);
            hiddenOptionsSystemNew[numListSystemNew].Click();
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