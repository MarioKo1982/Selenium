using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WorkshopsEnterToSpecFlow.Tests.TestsCases
{
	class SeleniumLesson1
	{
		private ChromeDriver driver;
		private string testUrl = "https://suvroc.github.io/selenium-mail-course/01/example.html";

		[SetUp]
		public void Setup()
		{
			driver = new ChromeDriver();

		}

		[Test]
		public void FirstTest()
		{
			var driver = new ChromeDriver();
			driver.Navigate().GoToUrl(testUrl);

			var element = driver.FindElement(By.Name("elementWithName"));

			Assert.IsNotNull(element);
			Assert.AreEqual(element.GetAttribute("value"), "Name test data");

			driver.Quit();

		}


	}
}
