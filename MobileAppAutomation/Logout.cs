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
    class Logout
    {

        AppiumDriver<IWebElement> driver;
        public Logout(AppiumDriver<IWebElement> Param_driver)
        {
            driver = Param_driver;
        }
        string result = string.Empty;
        public void signoff_only_for_genral()
        {
            // click on Back button
            driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
            Thread.Sleep(2000);
            // click on ok sign out corner button 
            driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
            Thread.Sleep(2000);
            // click on ok sign out  button 
            driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
            Thread.Sleep(2000);

        }

    }
}
