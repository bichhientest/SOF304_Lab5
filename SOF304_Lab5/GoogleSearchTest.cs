using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab5
{
	[TestFixture]
	public class GoogleSearchTest
	{
		IWebDriver driver;
		string url = "http://google.com";
		[SetUp] public void SetUp() {
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}
		[Test]
		public void Search()
		{
			driver.Navigate().GoToUrl(url);
			driver.FindElement(By.Name("q")).SendKeys("Fpt Polytechnic Đà Nẵng");
			driver.FindElements(By.Name("btnk"))[1].Click();
		}
		[TearDown] public void TearDown() {
		Thread.Sleep(5000);
			driver.Quit();
		}

	}
}
