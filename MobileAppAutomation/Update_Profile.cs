using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileAppAutomation
{
    class Update_Profile
    {
        AppiumDriver<IWebElement> driver;
        public Update_Profile(AppiumDriver<IWebElement> Param_driver)
        {
            driver = Param_driver;
        }
        string result = string.Empty;

        public void Update_profile()
        {
            try
            {

                // click on corner icon 
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(5000);
                // click on profile button
                driver.FindElement(By.XPath("//*[@text='Profile']")).Click();
                Thread.Sleep(5000);
                // Add first Name in profile
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[9]")).Clear();
                Thread.Sleep(5000);

                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[9]")).SendKeys("ABC");
                Thread.Sleep(5000);
                // Add last Name in profile
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).Clear();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).SendKeys("PQR");
                Thread.Sleep(5000);
                // Add email_id in profile
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[12]")).Clear();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[12]")).SendKeys("abc@gmail.com");
                Thread.Sleep(5000);
                // Add mobile number in profile
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[13]")).Clear();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[13]")).SendKeys("2132424423");
                Thread.Sleep(5000);
                // click on Save button in profile
                driver.FindElement(By.XPath("//*[@text='Save']")).Click();
            }

            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //return result;

        }
        public void Change_Password()
        {
            try
            {
                // click on corner icon 
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(5000);
                // click on change password  button
                driver.FindElement(By.XPath("//*[@text='Change Password']")).Click();
                Thread.Sleep(5000);
                // Entered current password  
                driver.FindElement(By.XPath("(//*[@index='4'])[7]")).SendKeys("Admin@1234");
                Thread.Sleep(5000);
                // Entered  New password  
                driver.FindElement(By.XPath("(//*[@index='7'])[4]")).SendKeys("Admin@123");
                Thread.Sleep(5000);
                // Entered  New conform  password  
                driver.FindElement(By.XPath("//*[@index='10']")).SendKeys("Admin@123");
                Thread.Sleep(5000);
                //  click on save button 
                driver.FindElement(By.XPath("//*[@text='Save']")).Click();
                Thread.Sleep(5000);
                //  click on Ok  button  on window popup
                driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                Thread.Sleep(5000);

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }
    }
}
