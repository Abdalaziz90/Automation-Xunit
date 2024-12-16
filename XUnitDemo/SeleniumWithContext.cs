using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace XUnitDemo
{
    public class SeleniumWithContext : IClassFixture<WebDriverFixture>
    {
        private readonly WebDriverFixture webDriverFixture;
        private readonly ITestOutputHelper testOutputHelper;

        public SeleniumWithContext(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
        {
            this.webDriverFixture = webDriverFixture;
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ClassFixtureTestNavigate()
        {
            Console.WriteLine("First test");
            webDriverFixture.ChromeDriver.Navigate().GoToUrl("http://172.20.1.141:9292/");
        }

        [Fact]
        public void ClassFixtureTestFillData()
        {
            var driver = webDriverFixture.ChromeDriver;
            Console.WriteLine("First test");
            //driver.Navigate().GoToUrl("https://qa.justdevelopmentjo.com/");
            driver.Navigate().GoToUrl("http://172.20.1.141:9292/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id=\"system\"]/li[6]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@id='Submodule1']/preceding-sibling::a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"Submodule1\"]/ul/li[1]/a")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list >>
            //String searchText = "0 - الحالة الاجتماعية";
            IWebElement dropdown = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div.form-Lookup > div > div:nth-child(1) > div"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(15000);
            // Select hidden option
            IWebElement hiddenOption = driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]"));
            hiddenOption.Click();


            //Thread.Sleep(15000);
            //driver.FindElement(By.XPath("//ul[contains(@class,'e-list-parent')]"));
            //Thread.Sleep(15000);
            //IList<IWebElement> lookupList = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')//]"));

            //foreach (IWebElement e in lookupList)
            //{
            //    Console.WriteLine(e.Text);
            //}

            //Random ran = new Random();
            //int nums = ran.Next(0, 256);
            //Ilist<IWebElement> options = dropdown.FindElements(By.XPath($"//li[@class='e-list-item'][{nums}]"));

            //IWebElement options = dropdown.FindElement(By.XPath($"//li[@class='e-list-item'][{nums}]"));

            //Random random = new Random();
            //int num = random.Next(0, options.Count);
            //options[num].Click();

            //options.Click();

            //foreach (IWebElement option in options)
            //{
            //    if (option.Text.Equals(searchText))
            //    {
            //        option.Click(); // click the desired option
            //        break;
            //    }
            //}

            driver.FindElement(By.XPath("//*[@id=\"arName\"]")).SendKeys("main test");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();

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
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("قصير");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
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
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("قصير");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

        }



        [Fact]
        public void ClassAppBinaryTestFromLookup()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://app.binarydigitsit.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Abdulaziz");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("Ahmad@2024");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[4]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(), 'تهيئة')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.CssSelector("#Submodule1 > ul > li:nth-child(7) > a")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list >>
            //String searchText = "0 - الحالة الاجتماعية";
            IWebElement dropdown = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div.form-Lookup > div > div:nth-child(1) > div"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(15000);
            // Select hidden option
            IWebElement hiddenOption = driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]"));
            hiddenOption.Click();

            driver.FindElement(By.XPath("//*[@id=\"arName\"]")).SendKeys("main test");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();

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
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("Test");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
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
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("قصير");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

        }


        [Fact]
        public void ClassAppJUSTTestFromLookup()
        {
            var driver = webDriverFixture.ChromeDriver;
            driver.Navigate().GoToUrl("https://app.justdevelopmentjo.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(15000);
            driver.FindElement(By.Name("checkuserdto.USERNAME")).SendKeys("Admin");
            driver.FindElement(By.Name("checkuserdto.PASSWORD")).SendKeys("JustDev@2018");
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-progress-btn btn btn-login  e-spin-right']")).Click();
            Thread.Sleep(15000);
            driver.FindElement(By.XPath("//*[@id='system']/li[9]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(), 'تهيئة')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'رموز النظام')]")).Click();

            // Add
            Thread.Sleep(15000);
            driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);

            // fill in on fields data >>
            // dropdown list >>
            IWebElement dropdown = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div.form-Lookup > div > div:nth-child(1) > div"));
            dropdown.Click(); // assuming you have to click the "dropdown" to open it

            Thread.Sleep(5000);

            var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
            ((IJavaScriptExecutor)driver).ExecuteScript(script);


            Thread.Sleep(15000);
            // Select hidden option
            IWebElement hiddenOption = driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]"));
            hiddenOption.Click();

            driver.FindElement(By.XPath("//*[@id=\"arName\"]")).SendKeys("main test");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();

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

            //// when selected on any records and then not appear button edit but I have to click on system admin > setup > lookup :

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='system']/li[9]/a")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(), 'تهيئة')]")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.XPath("//span[contains(text(),'رموز النظام')]")).Click();


            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@id='edit']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("Test");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
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
            driver.FindElement(By.XPath("//input[@id='SHORTDESC']")).SendKeys("قصير");
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div[2]/button[1]")).Click();
            Thread.Sleep(5000);

            // Delete 
            driver.FindElement(By.XPath("//*[@class='e-row e-altrow'][1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/div[2]/button[1]")).Click();
            // message OK >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib e-flat e-confirm-dialog e-confirm-dialog e-primary']")).Click();

        }
    }
}
