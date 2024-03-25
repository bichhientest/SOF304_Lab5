using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF304_Lab5._2
{
	public class FirefoxSearch
	{
		IWebDriver driver;
		string url = "http://firefox.com";
		[SetUp]
		public void SetUp()
		{
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
		}
		[Test]
		public void Search()
		{
			driver.Navigate().GoToUrl(url);
			driver.FindElement(By.Name("q")).SendKeys("Fpt Polytechnic Đà Nẵng");
		}
		[TearDown]
		public void TearDown()
		{
			Thread.Sleep(5000);
			driver.Quit();
		}
	}
}
