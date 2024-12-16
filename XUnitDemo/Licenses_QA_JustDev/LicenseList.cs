using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace XUnitDemo.Licenses_QA_JustDev
{
    public class LicenseList : IClassFixture<WebDriverFixture>
    {
            private readonly WebDriverFixture webDriverFixture;
            private readonly ITestOutputHelper testOutputHelper;

            public LicenseList(WebDriverFixture webDriverFixture, ITestOutputHelper testOutputHelper)
            {
                this.webDriverFixture = webDriverFixture;
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public void ClassQaJustLicenseList()
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
                driver.FindElement(By.XPath("//span[contains(text(),'الرخصة')]/preceding-sibling::i")).Click();

                // Add
                Thread.Sleep(15000);
                driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > div.row > div.col-md-2.spaceBetweenButton > button.e-control.e-btn.e-lib.btn.btn-add.btn-md.m-2")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[17]/button[2]")).Click();
                Thread.Sleep(5000);

                // fill in on fields data >>

                // dropdown list Client Number one>>
                IWebElement dropdownClient = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(1) > div"));
                dropdownClient.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);

                var script = "var elem = document.getElementById('dropdownlist-e1e99aec-7b03-42c9-86d3-fc571305d4d4_0'); if(elem) { elem.style.display = 'block'; }";
                ((IJavaScriptExecutor)driver).ExecuteScript(script);


                Thread.Sleep(5000);

                // Select hidden option
                IList<IWebElement> hiddenOptionsClient = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

                Random ran = new Random();
                int numListClient = ran.Next(0, hiddenOptionsClient.Count);
                hiddenOptionsClient[numListClient].Click();

                // dropdown list Contract Number Two>>
                IWebElement dropdownContract = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(2) > div"));
                dropdownContract.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                
                IWebElement hiddenOptionsContract = driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]"));
                
                if (hiddenOptionsContract == driver.FindElement(By.XPath("//li[contains(@class,'e-list-item')]")) && hiddenOptionsContract != driver.FindElement(By.XPath("//div[@id='no_record']")))
                {
                    int value = int.Parse(hiddenOptionsContract.Text);
               

                    if (value > 0)
                    {
                        hiddenOptionsContract.Click();
                    }

                    string textNoRecord = driver.FindElement(By.XPath("//div[@id='no_record']")).Text;

                    if (textNoRecord == "لا توجد سجلات")
                        {
                            driver.Quit();
                            hiddenOptionsContract.SendKeys(Keys.Tab);
                        }
                }

                // dropdown list VersionCopy Number Three>>
                IWebElement dropdownVersionCopy = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(3) > div"));
                dropdownVersionCopy.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                IList<IWebElement> hiddenOptionsVersionCopy = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));
                
                Random ranVerCopy = new Random();
                int numVerCopy = ranVerCopy.Next(1, hiddenOptionsVersionCopy.Count);
                hiddenOptionsVersionCopy[numVerCopy].Click();

                // dropdown list StateLic Number Four>>
                IWebElement dropdownStateLic = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(4) > div"));
                dropdownStateLic.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                IList<IWebElement> hiddenOptionsStateLic = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

                Random ranStateLic = new Random();
                int numListStateLic = ran.Next(1, hiddenOptionsStateLic.Count);
                hiddenOptionsStateLic[numListStateLic].Click();

                // dropdown list TypeLic Number Five>>
                IWebElement dropdownTypeLic = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(5) > div"));
                dropdownTypeLic.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                IList<IWebElement> hiddenOptionsTypeLic = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

                Random ranTypeLic = new Random();
                int numListTypeLic = ran.Next(1, hiddenOptionsTypeLic.Count);
                hiddenOptionsTypeLic[numListTypeLic].Click();

                driver.FindElement(By.XPath("//input[@id='CPUINFO']")).SendKeys("Test");

                driver.FindElement(By.XPath("//input[@id='MACADDRESS']")).SendKeys("Test");

                // number company on count
                IWebElement fillonCountcompany = driver.FindElement(By.XPath("//input[@id='COMPANIESNUM']"));
                int numcompany = 3;
                fillonCountcompany.SendKeys(numcompany.ToString());
                
                // dropdown list TypeUser Number Six>>
                IWebElement dropdownTypeUser = driver.FindElement(By.CssSelector("body > div.row.sidebar-row > div.col-md-10 > div > form > div > div > div:nth-child(12) > div"));
                dropdownTypeUser.Click(); // assuming you have to click the "dropdown" to open it

                Thread.Sleep(3000);
                // Select hidden option
                IList<IWebElement> hiddenOptionsTypeUser = driver.FindElements(By.XPath("//li[contains(@class,'e-list-item')]"));

                Random ranTypeUser = new Random();
                int numListTypeUser = ran.Next(1, hiddenOptionsTypeUser.Count);
                hiddenOptionsTypeUser[numListTypeUser].Click();

                Thread.Sleep(3000);

                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[17]/button[2]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//input[@id='MACADDRESS']")).Clear();
                driver.FindElement(By.XPath("//input[@id='MACADDRESS']")).SendKeys("Test One");
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[17]/button[1]")).Click();

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
                IWebElement fillonCountPage = driver.FindElement(By.XPath("//input[@id='NUMBEROFGALLARY']"));
                int numPage = 5;
                fillonCountPage.SendKeys(numPage.ToString());
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[19]/button[2]")).Click();
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[19]/button[1]")).Click();
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
                IWebElement fillonCountPage1 = driver.FindElement(By.XPath("//input[@id='NUMBEROFGALLARY']"));
                int numPage1 = 3;
                fillonCountPage1.SendKeys(numPage1.ToString());
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[19]/button[2]")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/form/div/div/div[19]/button[1]")).Click();
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