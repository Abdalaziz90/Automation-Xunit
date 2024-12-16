using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit.Abstractions;

namespace XUnitDemo
{
    public class SeleniumWithOutContext
    {
        private readonly ITestOutputHelper outputHelper;
        private readonly ChromeDriver chromeDriver;

        public SeleniumWithOutContext(ITestOutputHelper testOutputHepler) 
        {
            this.outputHelper = testOutputHepler;
            // WebDriverManager
            var driver = new DriverManager().SetUpDriver(new ChromeConfig());
            chromeDriver = new ChromeDriver();


        }


        [Fact]
        public void Test1()
        {
            Console.WriteLine("First test");
            chromeDriver.Navigate().GoToUrl("http://172.20.1.141:9292/");
        }
    }
}