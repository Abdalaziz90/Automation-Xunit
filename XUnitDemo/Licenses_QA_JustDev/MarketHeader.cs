using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit.Abstractions;

namespace XUnitDemo.Licenses_QA_JustDev
{
    public class MarketHeader : IClassFixture<WebDriverFixture>
    {
        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public MarketHeader(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassQaJustMarketHeader()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://qa.justdevelopmentjo.com/");
            driver.Manage().Window.Maximize();
            // convert to arabic
            Thread.Sleep(15000);
            string textLang = driver.FindElement(By.XPath("/html/body/main/form/div/div[1]/div[1]/button")).Text;
            if (textLang == "Arabic" && textLang != "English")
            {
                driver.FindElement(By.XPath("/html/body/main/form/div/div[1]/div[1]/button")).Click();
            }
            Thread.Sleep(11000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[12]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//*[@id=\"system\"]/a//following-sibling::span[contains(text(), 'رخص')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'خطة التسويق')]")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>

            // dropdown list ClassPlan Number one>>                                      
            IWebElement dropdownClassPlan = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div > form > div > div.row.gy-2 > div:nth-child(1) > div.e-ddl.e-lib"));
            dropdownClassPlan.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);

            Thread.Sleep(5000);

            // Select hidden option
            IList<IWebElement> hiddenOptionsClassPlan = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ran = new Random();
            int numListClassPlan = ran.Next(1, hiddenOptionsClassPlan.Count);
            hiddenOptionsClassPlan[numListClassPlan].Click();

            // Name plan market >>
            driver.FindElement(By.XPath("//input[@id='ARNAME']")).SendKeys("Test");

            // dropdown list TypeLic Number Two>>
            IWebElement dropdownTypeLic = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div > form > div > div.row.gy-2 > div:nth-child(4) > div.e-ddl.e-lib"));
            dropdownTypeLic.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);
            // Select hidden option
            IList<IWebElement> hiddenOptionsTypeLic = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranTypeLic = new Random();
            int numListTypeLic = ran.Next(1, hiddenOptionsTypeLic.Count);
            hiddenOptionsTypeLic[numListTypeLic].Click();

            // dropdown list TypeUser Number Three>>
            IWebElement dropdownTypeUser = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div > form > div > div.row.gy-2 > div:nth-child(8) > div.e-ddl.e-lib"));
            dropdownTypeUser.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);
            // Select hidden option
            IList<IWebElement> hiddenOptionsTypeUser = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranTypeUser = new Random();
            int numListTypeUser = ran.Next(1, hiddenOptionsTypeUser.Count);
            hiddenOptionsTypeUser[numListTypeUser].Click();

            driver.FindElement(By.XPath("//textarea[@id='ARDESCRIPTION']")).SendKeys("Test One");
            driver.FindElement(By.XPath("//textarea[@id='ENDESCRIPTION']")).SendKeys("Test Two");


            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            if (driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]")).Text == "عدد المستخدمين")
            {
                // Period Months for user type == عدد المستخدمين>>
                IWebElement dropdownPeriodMonths = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div > form > div > div.row.gy-2 > div:nth-child(10) > div.e-ddl.e-lib"));
                dropdownPeriodMonths.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                IList<IWebElement> hiddenOptionsPeriodMonths = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

                Random ranPeriodMonths = new Random();
                int numListPeriodMonths = ran.Next(1, hiddenOptionsPeriodMonths.Count);
                hiddenOptionsPeriodMonths[numListPeriodMonths].Click();
            }

            // Period Months for users type others >>
            IWebElement dropdownPeriodMonths1 = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div > form > div > div.row.gy-2 > div:nth-child(9) > div.e-ddl.e-lib"));
            dropdownPeriodMonths1.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(3000);
            // Select hidden option
            IList<IWebElement> hiddenOptionsPeriodMonths1 = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

            Random ranPeriodMonths1 = new Random();
            int numListPeriodMonths1 = ran.Next(1, hiddenOptionsPeriodMonths1.Count);
            hiddenOptionsPeriodMonths1[numListPeriodMonths1].Click();


            // Save button
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[1]")).Click();

            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[2]")).Click();

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
            driver.FindElement(By.XPath("//textarea[@id='ARDESCRIPTION']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='ARDESCRIPTION']")).SendKeys("Test One New");
            driver.FindElement(By.XPath("//textarea[@id='ENDESCRIPTION']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='ENDESCRIPTION']")).SendKeys("Test Two New");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[2]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[1]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // explicit wait of invisibility condition
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            // invisibilityOfElementLocated condition
            w.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//div[@class='e-toast-content']")));
            Thread.Sleep(5000);

            Assert.Equal("(هذا السجل مدقق,لا يمكن تعديله او حذفه)", driver.FindElement(By.XPath("//div[@class='e-toast-content']")).Text);
                          
            Thread.Sleep(5000);

            // UNPOST 
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[1]/div[2]/button[3]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

            // EDIT
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//textarea[@id='ARDESCRIPTION']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='ARDESCRIPTION']")).SendKeys("Test");
            driver.FindElement(By.XPath("//textarea[@id='ENDESCRIPTION']")).Clear();
            driver.FindElement(By.XPath("//textarea[@id='ENDESCRIPTION']")).SendKeys("Test New");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/form/div/div[2]/button[2]")).Click();
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