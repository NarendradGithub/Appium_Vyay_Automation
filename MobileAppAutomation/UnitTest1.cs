using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;

namespace MobileAppAutomation
{
    [TestClass]
    public class UnitTest1
    {

        public string result;
        public string Element1;
        AppiumDriver<IWebElement> driver;

        public AppiumDriver<IWebElement> Initialize_App()
        {
            AppiumDriver<IWebElement> Init_driver;
            AppiumOptions capp = new AppiumOptions();

            //cap = new DesiredCapabilities();
            capp.AddAdditionalCapability("platformName", "Android");
            capp.AddAdditionalCapability("deviceName", "emulator-5554");
            capp.AddAdditionalCapability("appPackage", "com.botmatic.vyay");
            capp.AddAdditionalCapability("appActivity", "com.botmatic.vyay.MainActivity");
            //capp.AddAdditionalCapability("automationName", "UiAutomator1");

            // capp.AddAdditionalCapability("platformVersion", "7.1.2");



            Init_driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capp);

            return Init_driver;


        }


        [TestMethod]
        public void finance_Approve_genral_request_with_invoice()
        {
            driver = Initialize_App();

            {



                // login page 
                Login_TestClass LoginClassObj = new Login_TestClass(driver);

                result = LoginClassObj.Login("Employee");

                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }
                // create request with invoice 

                Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                Element1 = Create_Requests_TestClassobj.Create_General_Request_With_Invoice();


                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }

                // logout logic 

                Logout l = new Logout(driver);
                l.signoff_only_for_genral();

                // manager login

                Login_TestClass LoginClassObj1 = new Login_TestClass(driver);

                result = LoginClassObj1.Login("Manager");

                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }


                // manager Approve general request
                User_Approve User_Approveob = new User_Approve(driver);
                User_Approveob.manager_Approval_General_request_with_invoice(Element1);
                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }

                //   Logout l = new Logout(driver);
                //  l.signoff();

                Login_TestClass LoginClassObj2 = new Login_TestClass(driver);

                result = LoginClassObj2.Login("Finance");

                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }

                //User_Approve User_Approveob = new User_Approve(driver);
                User_Approveob.finance_Approval_General_request_with_invoice(Element1);
                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }
            }

        }


           [TestMethod]
             public void finance_Approve_general_request_without_invoice()
             {
                 driver = Initialize_App();

                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);

                     result = LoginClassObjw1.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.Create_General_Request_Without_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout lw = new Logout(driver);
                     lw.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager Approve general request
                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_General_request_without_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Login_TestClass LoginClassObjw3 = new Login_TestClass(driver);

                     result = LoginClassObjw3.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.finance_Approval_General_request_without_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                 }
             }


               [TestMethod]
             public void finance_Approve_domestic_request()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_Domestic();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_domestic_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Login_TestClass LoginClassObjw3 = new Login_TestClass(driver);

                     result = LoginClassObjw3.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.finance_Approval_in_domestic_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }


             [TestMethod]
             public void finance_Approve_international_request()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_with_international();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_International_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Login_TestClass LoginClassObjw3 = new Login_TestClass(driver);

                     result = LoginClassObjw3.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.finance_Approval_in_international_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }

                     [TestMethod]
             public void Express_req_and_add_Expense_in_domestic__travel_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     Create_Requests_TestClassobj.Express_request_and_add_Expense_in__Domestic_travel_request();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }

        [TestMethod]
        public void Express_req_and_add_Expense_in_international__travel_request()
        {
            driver = Initialize_App();
            {
                // login page 
                Login_TestClass LoginClassObj = new Login_TestClass(driver);

                result = LoginClassObj.Login("Employee");

                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }


                Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                Create_Requests_TestClassobj.Express_request_and_add_Expense_in__international_travel_request();


                if (result.ToLower().Contains("success"))
                {
                    Console.WriteLine(" Test case Passed " + result);
                }
                else
                {
                    Console.WriteLine(" Test case failed " + result);
                }
            }
        }



        [TestMethod]
             public void create_request_with_invoice()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //   create request with invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     result = Create_Requests_TestClassobj.Create_General_Request_With_Invoice();

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                 }
             }

             [TestMethod]
             public void manager_approve_general_request_with_invoice()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     // create request with invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobj.Create_General_Request_With_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout l = new Logout(driver);
                     l.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObj1 = new Login_TestClass(driver);

                     result = LoginClassObj1.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     // manager Approve general request with invoice
                     User_Approve User_Approveob = new User_Approve(driver);
                     User_Approveob.manager_Approval_General_request_with_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }


             [TestMethod]
             public void create_request_without_invoice()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     //   create request without invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                           result = Create_Requests_TestClassobj.Create_General_Request_Without_Invoice();

                               if (result.ToLower().Contains("success"))
                               {
                                   Console.WriteLine(" Test case Passed " + result);
                               }
                               else
                               {
                                   Console.WriteLine(" Test case failed " + result);
                               }

                     }
                     }


             [TestMethod]
             public void manager_approve_general_request_without_invoice()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     // create request without invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobj.Create_General_Request_Without_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout l = new Logout(driver);
                     l.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObj1 = new Login_TestClass(driver);

                     result = LoginClassObj1.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     User_Approve User_Approveob = new User_Approve(driver);
                     User_Approveob.manager_Approval_General_request_without_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }

             [TestMethod]
             public void create_domestic_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //   create request with Domestic 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     result = Create_Requests_TestClassobj.create_Request_Domestic();

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }




             [TestMethod]
             public void manager_approve_in_pre_domestic_request()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_Domestic();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_domestic_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }

                     [TestMethod]
             public void create_international_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //   create request with international

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     result = Create_Requests_TestClassobj.create_Request_with_international();

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                 }
             }

             [TestMethod]
             public void manager_Approve_in_pre_international_request()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_with_international();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_International_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                 }
             }
             [TestMethod]
             public void manager_approve_in_post_domestic_travel_request()
             {
                 driver = Initialize_App();
                 {
                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Approve_in_post_domestic_travel_request();
                 }
             }
             [TestMethod]
             public void manager_approve_in_post_international_travel_request()
             {
                 driver = Initialize_App();
                 {
                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Approve_in_post_international_travel_request();
                 }
             }


             [TestMethod]
             public void upadate__profile()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // update profile
                     Update_Profile up = new Update_Profile(driver);
                     up.Update_profile();
                 }
             }
             [TestMethod]
             public void change__password()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // change password
                     Update_Profile up = new Update_Profile(driver);
                       up.Change_Password();
                 } 
             }

             [TestMethod]
             public void manager_reject_general_request_with_invoice()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);

                     result = LoginClassObjw1.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.Create_General_Request_With_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout lw = new Logout(driver);
                     lw.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                      //  Manager Reject Genaral request with invoice
                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_General_request_with_invoice(result);
                 }
             }

             [TestMethod]
             public void manager_reject_general_request_without_invoice()
             {
                 driver = Initialize_App();
                 {

                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);

                     result = LoginClassObjw1.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.Create_General_Request_Without_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout lw = new Logout(driver);
                     lw.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     //  Manager Reject Genaral request without invoice
                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_General_request_without_invoice(result);
                 }
             }


             [TestMethod]
             public void finance_reject_general_request_without_invoice()
             {
                 driver = Initialize_App();
                 {
                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     // create request without invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobj.Create_General_Request_Without_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout l = new Logout(driver);
                     l.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObj1 = new Login_TestClass(driver);

                     result = LoginClassObj1.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager Approve general request without invoice
                     User_Approve User_Approveob = new User_Approve(driver);
                     User_Approveob.manager_Approval_General_request_without_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //   Logout l = new Logout(driver);
                     //  l.signoff();

                     Login_TestClass LoginClassObj2 = new Login_TestClass(driver);

                     result = LoginClassObj2.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // Finance Reject genral request without invoice
                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.finance_Reject_General_request_without_invoice(result);
                 }
             }

             [TestMethod]
             public void finance_reject_general_request_with_invoice()
             {
                 driver = Initialize_App();
                 {

                     Login_TestClass LoginClassObj = new Login_TestClass(driver);

                     result = LoginClassObj.Login("Employee");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     // create request with invoice 

                     Create_Requests_TestClass Create_Requests_TestClassobj = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobj.Create_General_Request_With_Invoice();


                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // logout logic 

                     Logout l = new Logout(driver);
                     l.signoff_only_for_genral();

                     // manager login

                     Login_TestClass LoginClassObj1 = new Login_TestClass(driver);

                     result = LoginClassObj1.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager Approve general request with invoice
                     User_Approve User_Approveob = new User_Approve(driver);
                     User_Approveob.manager_Approval_General_request_with_invoice(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     //   Logout l = new Logout(driver);
                     //  l.signoff();

                     Login_TestClass LoginClassObj2 = new Login_TestClass(driver);

                     result = LoginClassObj2.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // Finance Reject with genral request with invoice
                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.finance_Reject_General_request_with_invoice(result);
                 }
             }

             [TestMethod]
             public void manager_reject_in_pre_domestic_travel_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_Domestic();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_in_pre_Domestic_travel_request(result);
                 }
             }


             [TestMethod]
             public void manager_reject_in_pre_international_travel_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_with_international();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_in_pre_international_travel_request(result);
                 }
             }

             [TestMethod]
             public void Finance_reject_domestic_travel_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_Domestic();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_domestic_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Login_TestClass LoginClassObjw3 = new Login_TestClass(driver);

                     result = LoginClassObjw3.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     // finance Reject  with   domestic travel request
                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.finance_Reject_domestic_travel_request(result);
                 }
             }

             [TestMethod]
             public void Finance_reject_international_travel_request()
             {
                 driver = Initialize_App();
                 {
                     // login page 
                     Login_TestClass LoginClassObjw1 = new Login_TestClass(driver);
                     result = LoginClassObjw1.Login("Employee");
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }
                     Create_Requests_TestClass Create_Requests_TestClassobjw = new Create_Requests_TestClass(driver);
                     Element1 = Create_Requests_TestClassobjw.create_Request_with_international();
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     // manager login

                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobw = new User_Approve(driver);
                     User_Approveobw.manager_Approval_in_pre_International_Travel_request(Element1);
                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     Login_TestClass LoginClassObjw3 = new Login_TestClass(driver);

                     result = LoginClassObjw3.Login("Finance");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }



                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.finance_Reject_international_travel_request(result);
                 }
             }

             [TestMethod]
             public void manager_reject_post_domestic_travel_request()
             {
                 driver = Initialize_App();
                 {
                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }


                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_in_post_domestic_travel_request();
                 }
             }

             [TestMethod]
             public void manager_reject_post_international_travel_request()
             {
                 driver = Initialize_App();
                 {
                     Login_TestClass LoginClassObjw2 = new Login_TestClass(driver);

                     result = LoginClassObjw2.Login("Manager");

                     if (result.ToLower().Contains("success"))
                     {
                         Console.WriteLine(" Test case Passed " + result);
                     }
                     else
                     {
                         Console.WriteLine(" Test case failed " + result);
                     }

                     User_Approve User_Approveobj = new User_Approve(driver);
                     User_Approveobj.manager_Reject_in_post_international_travel_request();
                 }
             }
           


    }
}