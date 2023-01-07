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
    class User_Approve
    {


        AppiumDriver<IWebElement> driver;
        public User_Approve(AppiumDriver<IWebElement> Param_driver)
        {
            driver = Param_driver;
        }

        string result = string.Empty;

        public void manager_Approval_General_request_with_invoice(string Element1)
        {
            //string result = string.Empty;
            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);



                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='2'])[7]")).Click();
                Thread.Sleep(2000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                //click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();

                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }

        public void manager_Approval_General_request_without_invoice(string Element1)
        {
            //string result = string.Empty;
            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);



                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='2'])[7]")).Click();
                Thread.Sleep(2000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                //click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();

                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }



        // Approve manager with International in pre  Travel request
        public void manager_Approval_in_pre_International_Travel_request(string Element1)
        {

            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                //click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                Thread.Sleep(2000);
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }

            // return result;



        }

        // Approve manager with Domestic in pre  Travel request
        public void manager_Approval_in_pre_domestic_Travel_request(string Element1)
        {

            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                //click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                Thread.Sleep(2000);
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }

            // return result;



        }



        // finance Approve  genral request with invoice
        public void finance_Approval_General_request_with_invoice(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);

                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='1'])[8]")).Click();
                Thread.Sleep(2000);
                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")).Click();
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();

                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }

        public void finance_Approval_General_request_without_invoice(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);

                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='1'])[8]")).Click();
                Thread.Sleep(2000);
                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ImageView")).Click();
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();

                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }


        // finance Approve with  Domestic travel request
        public void finance_Approval_in_domestic_Travel_request(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                //click on check box  to edit Advance Amount
                driver.FindElement(By.XPath("//*[@class='android.widget.CheckBox']")).Click();
                Thread.Sleep(2000);
                //put  edit Advance Amount
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@index='9']")).SendKeys("50");
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                // click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;

        }
        // finance Approve with international travel request
        public void finance_Approval_in_international_Travel_request(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(2000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(2000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(2000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(2000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(2000);
                //click on check box  to edit Advance Amount
                driver.FindElement(By.XPath("//*[@class='android.widget.CheckBox']")).Click();
                Thread.Sleep(2000);
                //put  edit Advance Amount
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@index='9']")).SendKeys("50");
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                // click on back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
                // click on corner
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on signout button
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;

        }


        //   manager Reject with genral request

        public void manager_Reject_General_request_with_invoice(string Element1)
        {

            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);



                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='2'])[7]")).Click();
                Thread.Sleep(5000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(5000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;
        }

        //   manager Reject without genral request

        public void manager_Reject_General_request_without_invoice(string Element1)
        {

            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);



                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='2'])[7]")).Click();
                Thread.Sleep(5000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(5000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();

                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            // return result;
        }

        //   Finance Reject with genral request

        public void finance_Reject_General_request_with_invoice(string Element1)
        {


            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='1'])[8]")).Click();
                Thread.Sleep(5000);
                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(4000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            // return result;

        }
        public void finance_Reject_General_request_without_invoice(string Element1)
        {


            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on General tab
                driver.FindElement(By.XPath("(//*[@index='1'])[8]")).Click();
                Thread.Sleep(5000);
                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(4000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //   return result;

        }
        //  manager  Reject with  Travel request

        public void manager_Reject_in_pre_Domestic_travel_request(string Element1)
        {
            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(5000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            // return result;

        }

        public void manager_Reject_in_pre_international_travel_request(string Element1)
        {
            try
            {

                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);


                // click on search icon  and put request id
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(5000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";
            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;

        }
        // finance reject domestic travels request
        public void finance_Reject_domestic_travel_request(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(4000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;

        }

        // finance reject international travels request
        public void finance_Reject_international_travel_request(string Element1)
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys(Element1);
                Thread.Sleep(4000);
                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Inprogress']")).Click();
                Thread.Sleep(5000);
                // click on Reject button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //return result;

        }
        // manager Approve in post travel request

        public void manager_Approve_in_post_domestic_travel_request()
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("8");
                Thread.Sleep(4000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath(" //*[@text='Post Travel']")).Click();
                Thread.Sleep(4000);



                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();


            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //    return result;

        }

        public void manager_Approve_in_post_international_travel_request()
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("8");
                Thread.Sleep(4000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath(" //*[@text='Post Travel']")).Click();
                Thread.Sleep(4000);



                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Approve']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Approve");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            // return result;

        }

        // manager Reject  in post domestic travel request

        public void manager_Reject_in_post_domestic_travel_request()
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("8");
                Thread.Sleep(4000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath(" //*[@text='Post Travel']")).Click();
                Thread.Sleep(4000);



                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            //  return result;

        }

        // manager Reject  in post international travel request

        public void manager_Reject_in_post_international_travel_request()
        {

            try
            {
                // click on My approval
                driver.FindElement(By.XPath("//*[@text='My Approvals']")).Click();
                Thread.Sleep(5000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("8");
                Thread.Sleep(4000);

                // click on search button and put request id in search box 
                driver.FindElement(By.XPath(" //*[@text='Post Travel']")).Click();
                Thread.Sleep(4000);



                // click on pending button
                driver.FindElement(By.XPath("//*[@text='Pending']")).Click();
                Thread.Sleep(5000);
                // click on Approve button
                driver.FindElement(By.XPath("//*[@text='Reject']")).Click();
                Thread.Sleep(5000);
                // Enter Comment button
                driver.FindElement(By.XPath("//*[@class='android.widget.EditText']")).SendKeys("Reject");
                Thread.Sleep(5000);

                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(5000);
                // click on ok on popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            // return result;

        }
    }
}
