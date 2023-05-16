using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        IWebDriver driver;
       
        [Given(@"OrangeCRM Login url")]
        public void OrangeCRMLoginUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        [When(@"User entered credentials")]
        public void UserCredentials()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.Name("password")).SendKeys("admin123");
        }

        [Then(@"User clicks on Login button")]
        public void userClicksOnLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
        }

        [Then(@"User sucessfully login the application")]
        public void userLoginSucessfully()
        {
            Console.WriteLine(driver.Title);
            String expectedTitle = "OrangeHRM";
            String actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            driver.Quit();
        }
    }
}