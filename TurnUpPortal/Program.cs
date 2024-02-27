


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open Web Browser - Chrome
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Launch TurnUpPortal and navigate to the login Page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/");

// User idenitifies Username Textbox and enters valid username
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

// User identifies Password Textbox and enters valid password
IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

// User identifies and clicks on Login Button
IWebElement logingbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
logingbutton.Click();

// Check if user has login successfully
IWebElement user = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (user.Text == "Hello hari!")
{
    Console.WriteLine("User is logged in successfully");
}
else
{
    Console.WriteLine("User is not logged in");
}
