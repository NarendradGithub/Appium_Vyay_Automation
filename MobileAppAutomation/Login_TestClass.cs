using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileAppAutomation
{
    class Login_TestClass
    {
        AppiumDriver<IWebElement> driver;
        public static int firstlogin = 0;
        public Login_TestClass(AppiumDriver<IWebElement> Param_driver)
        {
            driver = Param_driver;
        }


        public string Login(string Role)
        {
            string result = string.Empty;
            try
            {

                // login page
                if (firstlogin == 0)
                {
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//*[@text='Skip']")).Click();
                }
                //  Thread.Sleep(5000);
                //driver.FindElement(By.XPath("//*[@text='Skip']")).Click();
                Thread.Sleep(2000);

                firstlogin = 1;

                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[1]")).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText[2]")).Clear();
                Thread.Sleep(2000);


                // Login
                string Username = string.Empty;
                string Password = string.Empty;

                switch (Role)
                {


                    case "Employee":
                        Username = ConfigurationManager.AppSettings["Employee_Username"].ToString();
                        driver.FindElement(By.XPath("//*[@text='User Name']")).SendKeys(Username);
                        Thread.Sleep(2000);
                        Password = ConfigurationManager.AppSettings["Employee_Password"].ToString();
                        driver.FindElement(By.XPath("//*[@text='Password']")).SendKeys(Password);
                        break;

                    case "Manager":
                        Username = ConfigurationManager.AppSettings["Manager_Username"].ToString();
                        driver.FindElement(By.XPath("//*[@text='User Name']")).SendKeys(Username);
                        Thread.Sleep(2000);
                        Password = ConfigurationManager.AppSettings["Manager_Password"].ToString();
                        driver.FindElement(By.XPath("//*[@text='Password']")).SendKeys(Password);

                        break;

                    case "Finance":
                        Username = ConfigurationManager.AppSettings["Finance_Username"].ToString();
                        driver.FindElement(By.XPath("//*[@text='User Name']")).SendKeys(Username);
                        Thread.Sleep(2000);
                        Password = ConfigurationManager.AppSettings["Finance_Password"].ToString();
                        driver.FindElement(By.XPath("//*[@text='Password']")).SendKeys(Password);
                        break;



                    default:
                        break;
                }


                //driver.FindElement(By.XPath("//android.widget.TextView[@text='Sign In']")).Click();
                driver.FindElement(By.XPath("(//*[@text='Sign In'])[2]")).Click();
                Thread.Sleep(2000);
                // Entered OTP
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[3]")).SendKeys("12345");
                //Thread.Sleep(10000);
                //driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[25]")).Click();
                Thread.Sleep(2000);

                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;

            }

            return result;

        }
    }
}
