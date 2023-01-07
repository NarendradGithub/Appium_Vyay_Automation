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
    class Create_Requests_TestClass
    {
        AppiumDriver<IWebElement> driver;

        public Create_Requests_TestClass(AppiumDriver<IWebElement> Param_driver)
        {
            driver = Param_driver;
        }
        string result = string.Empty;
        string Element1 = string.Empty;

        // create request with invoice 

        // WebDriverWait w = new WebDriverWait(driver,20);
        public string Create_General_Request_With_Invoice()
        {
            string Element1 = string.Empty;
            string result = string.Empty;


            try
            {

                //click on Request Icon
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                Thread.Sleep(3000);

                // click on Genral Expense  Request
                driver.FindElement(By.XPath("//*[@text='General Expense Request']")).Click();
                Thread.Sleep(3000);
                // Enter Expense heading
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("Genral Expenses");
                Thread.Sleep(3000);
                // click on Expense type tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).Click();
                Thread.Sleep(2000);
                // click on  Select Expense type
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='search']")).SendKeys("Food");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@text='Food'])[2]")).Click();
                Thread.Sleep(3000);
                // Click on camera first icon
                driver.FindElement(By.XPath("(//*[@index='7'])[4]")).Click();
                Thread.Sleep(3000);
                //Click on camera second icon
               driver.FindElement(By.XPath("//*[@text='']")).Click();
                Thread.Sleep(2000);
                // click on allow button
                driver.FindElement(By.XPath("//*[@text='ALLOW']")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[19]")).Click();
                Thread.Sleep(3000);
                // click on right  button
                driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[18]")).Click();
                Thread.Sleep(3000);
                // click on Next   button
                driver.FindElement(By.XPath("//*[@index='11']")).Click();
                // Thread.Sleep(2000);
                // invioce date allready fill(so, not enterd code)
                Thread.Sleep(3000);
                // Add vender name   button
                //* driver.FindElement(By.XPath("(//*[@index='5'])[8]")).SendKeys("S K traders");
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[11]")).SendKeys("S K traders");

                Thread.Sleep(2000);
                // Add  invoice nubmer   button
                driver.FindElement(By.XPath("(//*[@index='8'])[3]")).SendKeys("12345");
                Thread.Sleep(2000);
                // Add total invoice Amount
                driver.FindElement(By.XPath("//*[@index='12']")).SendKeys("600");
                Thread.Sleep(2000);
                // click on next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                // 3rd page
                //click on project code field
                Thread.Sleep(2000);
                //* driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[22]")).Click();
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.EditText")).Click();
                Thread.Sleep(2000);
                // click on project code
                driver.FindElement(By.XPath("//*[@text='PRJ-002']")).Click();
                Thread.Sleep(2000);
                // click on submit buutton
                driver.FindElement(By.XPath("(//*[@text='Submit'])")).Click();

                //  Thread.Sleep(50000);
                // get request id 


                Element1 = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")).Text;
                //  Element1 = Element1.Substring(Element1.IndexOf("EX"), 8);
                // Element1 = Element1.Substring(Element1.LastIndexOf("5"), 2);
                Element1 = Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' });

                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(3000);



                // * change if single request final submited*/
                // click on final submit button
                //  driver.FindElement(By.XPath("(//*[@text='Submit'])[2]")).Click();
                //    Thread.Sleep(3000);
                // click on ok button on popup  window
                //   driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                //   Thread.Sleep(3000);
                //   result = "Success";






                // /*add expense by virtual assistant*/
                // click on back button for virtual assiastant After creating request
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on icon 
                driver.FindElement(By.XPath("(//*[@text='󰐕'])[2]")).Click();
                Thread.Sleep(3000);
                // click on Express request button 
                driver.FindElement(By.XPath("//*[@text='Express Request']")).Click();
                Thread.Sleep(2000);
                // click on  genral requesst 
                driver.FindElement(By.XPath("(//*[@text='General Request'])[1]")).Click();
                Thread.Sleep(2000);
                // click on  take a picture icon 
                driver.FindElement(By.XPath("(//*[@text=''])")).Click();
                Thread.Sleep(2000);
                // click on  allow button 
                driver.FindElement(By.XPath("(//*[@text='ALLOW'])")).Click();
                Thread.Sleep(2000);
                // click on  camera 
                driver.FindElement(By.XPath("//*[@content-desc='Shutter']")).Click();
                Thread.Sleep(2000);
                // click on right button 
                driver.FindElement(By.XPath("//*[@content-desc='Done']")).Click();
                Thread.Sleep(2000);
                //add vendor name in popup
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("Anil kumar");
                Thread.Sleep(2000);
                // add amount in popup 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("1000");

                Thread.Sleep(2000);
                // click on submit button 
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok button 
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click ob back button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup")).Click();
                // click on inprogress  button
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@text='Inprogress'])[1]")).Click();
                // click on edited request  
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[17]")).Click();
                // click on edit button  
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                // click on select expense type field 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).Click();
                // click on food 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Food']")).Click();
                // click on Next button 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@text='Next'])[1]")).Click();
                // click on invoice Number
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[12]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("2000");
                // click on Next button 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@text='Next'])[4]")).Click();
                //3rd page 
                // click on project code field
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.EditText")).Click();
                Thread.Sleep(2000);
                // click on project code
                driver.FindElement(By.XPath("//*[@text='PRJ-002']")).Click();
                Thread.Sleep(2000);
                // click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[4]")).Click();
                Thread.Sleep(2000);
                // click on ok popup button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);


           /*     // if Delated expense(first expense)
                // click on first Expense
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[12]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).Click();
                Thread.Sleep(2000);
                // click on Delete  button
                driver.FindElement(By.XPath("(//*[@text='Delete'])[1]")).Click();
                Thread.Sleep(2000);
                // click on  first ok button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on  second ok button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on final submit  button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[2]")).Click();
                Thread.Sleep(2000);
                // click on ok   button on window popup
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
           */


                // click on final submit  button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[5]")).Click();
                Thread.Sleep(2000);
                // click on ok   button on window popup
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);

                result = "Success";





            }
            catch (Exception ex)
            {

                result = "Fail : " + ex.Message;
            }

            return Element1;

        }

        public string Create_General_Request_Without_Invoice()
        {
            string result = string.Empty;
            string Element1 = string.Empty;


            try
            {
                //click on Request Icon
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                //Thread.Sleep(2000);


                // click on Genral Expense  Request
                driver.FindElement(By.XPath("//*[@text='General Expense Request']")).Click();
                Thread.Sleep(2000);
                // Enter Expense heading
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("Genral Expenses");
                Thread.Sleep(2000);
                // click on Expense type tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).Click();
                //Thread.Sleep(2000);
                // click on  Select Expense type
                Thread.Sleep(2000);
                //  driver.FindElement(By.XPath("//*[@text='search']")).SendKeys("Food");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Food']")).Click();



                // click on image missing 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.CheckBox")).Click();

                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                Thread.Sleep(2000);
                // Enterd Vendor Name
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("OM Sai Traders");
                Thread.Sleep(2000);
                // Enter Total invoice Amount
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("500");
                Thread.Sleep(2000);
                // Click on next button 
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                Thread.Sleep(2000);
                // clicck on  project code tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[14]")).Click();
                Thread.Sleep(2000);
                // click on any one project code
                driver.FindElement(By.XPath("//*[@text='PRJ-001']")).Click();
                Thread.Sleep(2000);
                // click on submit button
                //driver.FindElement(By.XPath("(//*[@index='8'])[4]")).Click();
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);

                // to get request id number
                Element1 = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")).Text;

                //Element1 = Element1.Substring(Element1.IndexOf("EX"), 8);
                //  Element1 = Element1.Substring(Element1.LastIndexOf("5"), 2);
                Element1 = Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' });



                // click on ok Button on popup window
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(4000);

                // /* change if final submit the request*/

                // click on final submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[2]")).Click();
                Thread.Sleep(4000);
                // click on ok Button on popup window(Last)
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();



                // *add Expense with invoice*
                /*    //click on Add Expense with invoice
                     driver.FindElement(By.XPath("//*[@text='Add Expense']")).Click();
                     Thread.Sleep(2000);
                     // click on Select Expense type field
                     driver.FindElement(By.XPath("(//*[@index='3'])[2]")).Click();
                     Thread.Sleep(2000);
                     // click on Select  any one  Expense type
                     driver.FindElement(By.XPath("//*[@text='Food']")).Click();
                     Thread.Sleep(2000);
                     // click on camera icon
                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup[1]")).Click();
                     Thread.Sleep(2000);
                     // click on take a picture
                     driver.FindElement(By.XPath("(//*[@text=''])")).Click();
                     Thread.Sleep(2000);
                     // click on allow button
                     driver.FindElement(By.XPath("//*[@text='ALLOW']")).Click();
                     Thread.Sleep(2000);
                     // click on camera to click a image
                     driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[19]")).Click();
                     Thread.Sleep(2000);
                     // click on right symbol
                     driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[18]")).Click();
                     Thread.Sleep(2000);

                     // click on Next   button
                     driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                     // Thread.Sleep(2000);
                     // invioce date allready fill(so, not enterd code)
                     Thread.Sleep(3000);
                    // driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[14]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).Clear();
                    // Add vender name   button
                    //   driver.FindElement(By.XPath("(//*[@index='5'])[8]")).SendKeys("S Kkkk traders");
                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("OM traders sai ram");

                     Thread.Sleep(2000);
                       // add invoice number

                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("123");
                     // Add total invoice Amount
                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[3]")).SendKeys("1000");
                     Thread.Sleep(2000);
                     // click on next button
                     driver.FindElement(By.XPath("(//*[@text='Next'])[4]")).Click();
                     // 3rd page
                     //click on project code field
                     Thread.Sleep(2000);
              //       driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup")).Click();
                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.EditText")).Click();
                     Thread.Sleep(2000);
                     // click on project code
                     driver.FindElement(By.XPath("//*[@text='PRJ-002']")).Click();
                     Thread.Sleep(2000);
                     // click on submit buutton
                     driver.FindElement(By.XPath("(//*[@text='Submit'])[1]")).Click();
                     Thread.Sleep(2000);
                     // click on ok button on popup window 
                     driver.FindElement(By.XPath("//*[@text='Ok']")).Click();

                     // *click on expense for edit*

                       Thread.Sleep(2000);
                      driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[17]")).Click();
                     // *click on edit button
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                     // *click on slect other expense tab button
                     driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[10]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup")).Click();
                     Thread.Sleep(2000);

                     // click on wifi(Other Expense type rather than privious)

                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("//*[@text='Wifi']")).Click();


                     // click on next button
                      Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[251]")).Click();
                     // clear privious amount
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@text='1000.00'])[2]")).Clear();

                     // Add new Advance Amount
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@index='11'])[8]")).SendKeys("2000");
                     //  click on next button
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@text='Next'])[4]")).Click();
                     //  click on submit button button
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@text='Submit'])[2]")).Click();
                     //  click on Ok popup button
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                     //click on final submit button
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[233]")).Click();
                     //click on Ok button on popup window
                     Thread.Sleep(2000);
                     driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                     Thread.Sleep(2000);
                     result = "Success";

                     */

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            return Element1;





        }

        public string create_Request_Domestic()
        {
            string result = string.Empty;
            // string Requestidnumber = string.Empty;


            try
            {
                //click on Request Icon
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                // Thread.Sleep(2000);
                //    WebDriverWait w = new WebDriverWait(driver,20);
                //  w.until(ExpectedConditions.visibilityOfElementLocated(By.XPath("//*[@text='Travel Request']")));


                // click on Travel Request
                driver.FindElement(By.XPath("//*[@text='Travel Request']")).Click();
                Thread.Sleep(2000);
                // Add Expense heading
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText")).SendKeys("Exp[ense heading");

                //driver.FindElement(By.XPath("(//*[@index='4'])[8]")).SendKeys("Travel Expenses");
                Thread.Sleep(2000);
                // click on  Travel type tab
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup")).Click();


                //driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[102]")).Click();
                Thread.Sleep(2000);
                // Select Domestic
                driver.FindElement(By.XPath("//*[@text='Domestic']")).Click();
                Thread.Sleep(2000);
                //Click on travel from tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[11]")).Click();
                Thread.Sleep(2000);
                //Click on City  
                driver.FindElement(By.XPath("//*[@text='Ahmadnagar']")).Click();
                Thread.Sleep(2000);
                //Click on travel To tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[12]")).Click();
                Thread.Sleep(2000);
                //Click on City  
                driver.FindElement(By.XPath("//*[@text='Akola']")).Click();
                // Thread.Sleep(2000);
                // click on start date Calender
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[7]/android.widget.ImageView")).Click();
                // driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[109]")).Click();
                Thread.Sleep(2000);
                // click on current Date Ok button
                driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                Thread.Sleep(2000);

                // click on end date Calender
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[8]/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // clkick on Date 31 Dec 
                driver.FindElement(By.XPath("//android.view.View[@content-desc='31 January 2023']")).Click();
                Thread.Sleep(2000);
                // click on ok Button
                driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                Thread.Sleep(2000);


                //     Thread.Sleep(9000);
                // click on  next button
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();


                // Project Detail
                // click on project detail tab
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[14]")).Click();
                Thread.Sleep(2000);

                // select project code any one
                driver.FindElement(By.XPath("//*[@text='PRJ-002']")).Click();
                Thread.Sleep(2000);
                // click on next button
                driver.FindElement(By.XPath("(//*[@index='9'])[5]")).Click();
                Thread.Sleep(2000);

                //  Expenses Detail
                // click on argency scale tab
                // driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[163]")).Click();
                // Thread.Sleep(5000);
                // argency scale
                //Thread.Sleep(5000);
                // driver.FindElement(By.XPath("//*[@text='Medium']")).Click();
                Thread.Sleep(2000);
                // Estmated amount
                driver.FindElement(By.XPath("(//*[@index='7'])[9]")).SendKeys("500");
                Thread.Sleep(2000);
                //Advance amount
                driver.FindElement(By.XPath("(//*[@index='8'])[7]")).SendKeys("200");
                Thread.Sleep(2000);
                // Reason
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[21]")).SendKeys("i Want money for for office work");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // to get request id number
                Element1 = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")).Text;

                //Element1 = "EX000504 Successfully";
                //Element1 = Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' });

                Element1 = (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).Substring(0, (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).IndexOf(" "));

                //  Element1 = Element1.Substring(Element1.IndexOf("EX"), 8);
                //  Element1 = Element1.Substring(Element1.LastIndexOf("1"), 2);
                // Element1 = Element1.Substring(Element1.IndexOf, 2);
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);

                // signout
                //click on ok sign out corner button 
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                //click on ok sign out  button 
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                Thread.Sleep(2000);

                result = "Success";


            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            return Element1;
        }

        // create request international

        public string create_Request_with_international()
        {
            string result = string.Empty;


            // create request international

            try
            {
                //click on Request Icon
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                Thread.Sleep(2000);

                // click on Travel Request
                driver.FindElement(By.XPath("//*[@text='Travel Request']")).Click();
                Thread.Sleep(2000);
                // Add Expense heading
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText")).SendKeys("Travel Expenses");
                //driver.FindElement(By.XPath("(//*[@index='4'])[8]")).SendKeys("Travel Expenses");
                Thread.Sleep(2000);
                // click on  Travel type tab

                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup")).Click();
                // driver.FindElement(By.XPath("(//*[@index='6'])[5]")).Click();


                Thread.Sleep(2000);
                // Select International
                driver.FindElement(By.XPath("//*[@text='International']")).Click();
                // driver.FindElement(By.XPath("(//*[@index='1'])[1]")).Click();

                Thread.Sleep(2000);
                // click on Travel from country tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[11]")).Click();
                Thread.Sleep(2000);
                // select Travel from country
                driver.FindElement(By.XPath("//*[@text='Afghanistan']")).Click();
                Thread.Sleep(2000);
                // click on Travel To country tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[12]")).Click();
                Thread.Sleep(2000);
                // select Travel To country
                driver.FindElement(By.XPath("//*[@text='Australia']")).Click();
                Thread.Sleep(2000);
                // click on Travel from city tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[13]")).Click();
                Thread.Sleep(2000);
                //select Travel from city
                driver.FindElement(By.XPath("//*[@text='Bazarak']")).Click();
                Thread.Sleep(2000);
                // click on Travel To city tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[14]")).Click();
                Thread.Sleep(2000);
                //select Travel To city
                driver.FindElement(By.XPath("//*[@text='Albury']")).Click();
                Thread.Sleep(2000);
                // click on camera icon for passport
                driver.FindElement(By.XPath("//*[@index='16']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='']")).Click();
                Thread.Sleep(2000);
                // click on allow or deny
                driver.FindElement(By.XPath("//*[@text='ALLOW']")).Click();
                Thread.Sleep(2000);
                // click on image
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[2]")).Click();
                Thread.Sleep(2000);
                //  click on final right  symbol
                driver.FindElement(By.XPath("//*[@content-desc='Done']")).Click();
                Thread.Sleep(2000);

                // click on camera icon for passport
                driver.FindElement(By.XPath("(//*[@text=''])[2]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@content-desc='Shutter']")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@content-desc='Done']")).Click();
                Thread.Sleep(2000);

                try
                {

                    IWebElement element1 = driver.FindElement(MobileBy.AndroidUIAutomator(
                    "new UiScrollable(new UiSelector().scrollable(true))" + ".scrollIntoView(new UiSelector().text(\"//*[@text='End Date']\"))"));

                }
                catch (Exception)
                {

                    // throw;
                }
                // click on start date tab
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[9]/android.widget.ImageView")).Click();
                //      driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[115]")).Click();
                Thread.Sleep(2000);
                // click on OK Button
               driver.FindElement(By.XPath("//*[@text='OK']")).Click();

                // click on end Date tab
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[10]/android.widget.ImageView")).Click();
                Thread.Sleep(2000);
                // click on end date
                driver.FindElement(By.XPath("//*[@text='31']")).Click();
                Thread.Sleep(2000);
                // click on Ok button
                driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//*[@text='Next']")).Click();

                // driver.FindElement(By.XPath("//*[@index='25']")).Click();
                Thread.Sleep(2000);
                // click on project code field 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.widget.EditText")).Click();
                Thread.Sleep(2000);
                // click on  any one project code 
                driver.FindElement(By.XPath("//*[@text='PRJ-001']")).Click();
                Thread.Sleep(2000);
                // click on next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                // click on argency scale tab
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.EditText")).Click();
                // clickselect any  one argency scale 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Low']")).Click();
                // enter estimated amount 
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("500");
                Thread.Sleep(2000);
                // enter Advance amount
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("200");
                Thread.Sleep(2000);
                //Enter region
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[5]/android.widget.EditText")).SendKeys("office work");
                Thread.Sleep(2000);
                // click on submit  button
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();

                // to get request id number
                Element1 = driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.TextView")).Text;
                Element1 = (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).Substring(0, (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).IndexOf(" "));
                // Element1 = (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).Substring(0, (Element1.Substring(Element1.IndexOf("X") + 1).TrimStart(new char[] { '0' })).IndexOf(" "));
                // Element1 = Element1.Substring(Element1.LastIndexOf("1")+1);
                //Element1 = Element1.Substring(Element1
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // signout
                // click on ok sign out corner button 
                driver.FindElement(By.XPath("(//*[@class='android.widget.ImageView'])[4]")).Click();
                Thread.Sleep(2000);
                // click on ok sign out  button 
                driver.FindElement(By.XPath("//*[@text='Sign Out']")).Click();
                Thread.Sleep(2000);

                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            return Element1;
        }


        // create request with invoice (With Additional Detail)

        public string create_Request_With_invoice_With_Additional_Details()
        {
            string result = string.Empty;
            // string Requestidnumber = string.Empty;
            try
            {
                //click on Request Icon
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                Thread.Sleep(2000);

                // click on Genral Expense  Request
                driver.FindElement(By.XPath("//*[@text='General Expense Request']")).Click();
                Thread.Sleep(2000);
                // Enter Expense heading
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("Genral Expenses");
                Thread.Sleep(2000);
                // click on Expense type tab
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[10]")).Click();
                Thread.Sleep(2000);
                // click on  Select Expense type
                //Thread.Sleep(2000);
                // driver.FindElement(By.XPath("//*[@text='search']")).SendKeys("Food");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Food']")).Click();
                Thread.Sleep(2000);
                // click on camera first icon
                driver.FindElement(By.XPath("(//*[@index='7'])[4]")).Click();
                Thread.Sleep(2000);
                // click on camera second icon
                driver.FindElement(By.XPath("//*[@text='']")).Click();
                Thread.Sleep(2000);
                // click on allow button
                driver.FindElement(By.XPath("//*[@text='ALLOW']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[19]")).Click();
                Thread.Sleep(2000);
                // click on right  button
                driver.FindElement(By.XPath("(//*[@package='com.android.camera2'])[18]")).Click();
                Thread.Sleep(2000);
                // click on Next   button
                driver.FindElement(By.XPath("//*[@index='11']")).Click();
                Thread.Sleep(2000);
                // invioce date allready fill(so, not enterd code)
                //Thread.Sleep(2000);
                // Add vender name   button
                //* driver.FindElement(By.XPath("(//*[@index='5'])[8]")).SendKeys("S K traders");
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[11]")).SendKeys("S K traders");

                Thread.Sleep(2000);
                // Add  invoice nubmer   button
                driver.FindElement(By.XPath("(//*[@index='8'])[3]")).SendKeys("12345");
                Thread.Sleep(2000);
                //  click on additional details   button
                driver.FindElement(By.XPath("//*[@text='Additional Details']")).Click();
                Thread.Sleep(2000);
                //   Add purchase order number
                driver.FindElement(By.XPath("//*[@index='12']")).SendKeys("98765");
                Thread.Sleep(2000);
                // scroll the page


                //       IWebElement element = driver.FindElement(MobileBy.AndroidUIAutomator(
                //             "new UiScrollable(new UiSelector().scrollable(true))" + ".scrollIntoView(new UiSelector().text(\"Puechase Order Number\"))"));

                try
                {

                    IWebElement element1 = driver.FindElement(MobileBy.AndroidUIAutomator(
                    "new UiScrollable(new UiSelector().scrollable(true))" + ".scrollIntoView(new UiSelector().text(\"//*[@index='24']\"))"));


                }
                catch (Exception)
                {

                    // throw;
                }
                Thread.Sleep(2000);

                //   Add  HSN Code number
                driver.FindElement(By.XPath("//*[@index='14']")).SendKeys("64747889");
                // driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[3]")).SendKeys("123");
                Thread.Sleep(2000);
                //   Add  place of supply number
                driver.FindElement(By.XPath("//*[@index='16']")).SendKeys("647475");
                Thread.Sleep(2000);
                //   Add  GSTIN number 
                driver.FindElement(By.XPath("//*[@index='18']")).SendKeys("27AAHCB8978N1ZO");
                Thread.Sleep(2000);


                //   Add  CGST number 
                // driver.FindElement(By.XPath("//*[@index='22']")).SendKeys("50");
                Thread.Sleep(2000);

                // Add IGST number
                driver.FindElement(By.XPath("//*[@index='24']")).SendKeys("25");

                Thread.Sleep(2000);
                //   Add Total invoice Amount 
                // driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[20]")).SendKeys("1000");
                // IWebElement e = driver.FindElement(By.XPath("//*[@index='28']"));
                // e.SendKeys("1000");


                driver.FindElement(By.XPath("//*[@index='28']")).SendKeys("1000");


                //  driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[10]")).SendKeys("1000");

                // click on next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                // 3rd page
                //click on project code field
                Thread.Sleep(2000);
                //* driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[22]")).Click();
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[6]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.widget.EditText")).Click();
                Thread.Sleep(2000);
                // click on project code
                driver.FindElement(By.XPath("//*[@text='PRJ-002']")).Click();
                Thread.Sleep(2000);
                // click on submit buutton
                driver.FindElement(By.XPath("(//*[@text='Submit'])")).Click();
                // get request id 
                //*[@text='Expense added successfully in EX000011']
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on final submit button
                driver.FindElement(By.XPath("(//*[@index='5'])[9]")).Click();
                Thread.Sleep(2000);
                // click on ok button on popup  window
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);



                /*  // add next expense(without invoice)
                  //click on Add Expense with invoice
                  driver.FindElement(By.XPath("//*[@text='Add Expense']")).Click();
                  Thread.Sleep(5000);
                  //click on select expense type field
                  driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]")).Click();
                  Thread.Sleep(5000);
                  //click on select expense type  "food"
                  driver.FindElement(By.XPath("//*[@text='Food']")).Click();
                  Thread.Sleep(5000);
                  //click on missing reciept icon                                 
                  driver.FindElement(By.XPath("(//*[@index='9'])[5]")).Click();
                  Thread.Sleep(5000);

                   //click on Next button                                
                  driver.FindElement(By.XPath("(//*[@text='500'])[1]")).Click();
                  Thread.Sleep(5000);
              */


                result = "Success";

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }
            return Element1;
        }


        public void Express_request_and_add_Expense_in__Domestic_travel_request()
        {


            try
            {
                // virtual express in Travel
                // first login Employee page then
                // click on icon 
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                Thread.Sleep(3000);
                // click on Express request button 
                driver.FindElement(By.XPath("//*[@text='Express Request']")).Click();
                Thread.Sleep(2000);

                // Enter request id mannualy
                driver.FindElement(By.XPath("(//*[@text='Search here'])[2]")).SendKeys("1");
                // click on  genral requesst 
                driver.FindElement(By.XPath("(//*[@text='Travel Request'])[1]")).Click();
                Thread.Sleep(2000);
                // click on  take a picture icon 
                driver.FindElement(By.XPath("(//*[@text=''])")).Click();
                Thread.Sleep(2000);
                // click on  allow button 
                driver.FindElement(By.XPath("(//*[@text='ALLOW'])")).Click();
                Thread.Sleep(2000);
                // click on  camera 
                driver.FindElement(By.XPath("//*[@content-desc='Shutter']")).Click();
                Thread.Sleep(2000);
                // click on right button 
                driver.FindElement(By.XPath("//*[@content-desc='Done']")).Click();
                Thread.Sleep(2000);
                //add vendor name in popup
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("Rahul");
                Thread.Sleep(2000);
                // add amount in popup 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("1000");

                Thread.Sleep(2000);
                // click on submit button 
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok button 
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on Back  button 
                driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[16]")).Click();
                Thread.Sleep(2000);
                // Enter request id in search box
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("1");
                Thread.Sleep(2000);
                // click on complited button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[3]")).Click();
                Thread.Sleep(2000);
                // click on view Expense list button 
                driver.FindElement(By.XPath("//*[@text='View Expense List']")).Click();
                Thread.Sleep(2000);
                // click on  Expense
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[2]")).Click();
                Thread.Sleep(2000);
                // click on Edit  button 
                driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                Thread.Sleep(2000);
                // Add Expense Description
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("Expenses");

                Thread.Sleep(2000);
                // click on select expense field
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.EditText")).Click();
                // click on any one expense  
                driver.FindElement(By.XPath("//*[@text='Dinner']")).Click();
                Thread.Sleep(2000);
                // click on Next biutton
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                Thread.Sleep(2000);
                // Add invoice number
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[8]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("1222");
                Thread.Sleep(2000);
                // click on Next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                Thread.Sleep(2000);
                //Add igst
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("10");
                Thread.Sleep(2000);
                // click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[3]")).Click();

                Thread.Sleep(2000);
                // click on ok button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);


                // /* add  another Expense  and also edit */
                // click on  Add Expense button
                driver.FindElement(By.XPath("(//*[@text='Add Expense'])[2]")).Click();
                Thread.Sleep(2000);
                //   Add  Expense Description
                // driver.FindElement(By.XPath("(//*[@index='3'])[14]")).Click();
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("heading");
                Thread.Sleep(2000);
                //  click on Expense Type tab
                // driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[8]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.EditText")).Click();
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.EditText")).Click();
                //    click on any one Expense type
                driver.FindElement(By.XPath("//*[@text='Dinner']")).Click();
                Thread.Sleep(2000);
                //    click on missing reciept
                driver.FindElement(By.XPath("(//*[@index='9'])[4]")).Click();
                Thread.Sleep(2000);
                //    click on Next button
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                Thread.Sleep(2000);
                //    Enter vendor Name
                driver.FindElement(By.XPath("(//*[@index='5'])[11]")).SendKeys("Avi");
                Thread.Sleep(2000);
                //    Enter Amount
                driver.FindElement(By.XPath("(//*[@index='7'])[10]")).SendKeys("500");
                Thread.Sleep(2000);
                //    click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[5]")).Click();
                Thread.Sleep(2000);
                //    click on Ok  button on popup
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);

                //  *edit same Expense*

                //  click on Expense for Edit
                driver.FindElement(By.XPath("(//*[@text='Expense Type:'])[4]")).Click();
                Thread.Sleep(5000);
                //  click on  Edit button
                driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                Thread.Sleep(5000);
                //  click on Expense Type 
                driver.FindElement(By.XPath("(//*[@index='12'])[2]")).Click();
                Thread.Sleep(5000);
                //  change Expense Type 
                driver.FindElement(By.XPath("//*[@text='Lunch']")).Click();
                Thread.Sleep(5000);
                //  click on next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                Thread.Sleep(5000);
                //  clear privouus amount
                driver.FindElement(By.XPath("(//*[@index='7'])[15]")).Clear();
                Thread.Sleep(5000);
                //  enter new Amount 
                driver.FindElement(By.XPath("(//*[@index='7'])[15]")).SendKeys("1000");
                Thread.Sleep(2000);
                //   Click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[7]")).Click();
                Thread.Sleep(2000);
                //   Click on Ok button
                driver.FindElement(By.XPath("(//*[@text='Ok'])")).Click();
                Thread.Sleep(2000);

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }




        }

        public void Express_request_and_add_Expense_in__international_travel_request()
        {


            try
            {
                // virtual express in Travel
                // first login Employee page then
                // click on icon 
                driver.FindElement(By.XPath("//*[@text='󰐕']")).Click();
                Thread.Sleep(3000);
                // click on Express request button 
                driver.FindElement(By.XPath("//*[@text='Express Request']")).Click();
                Thread.Sleep(2000);

                // Enter request id mannualy
                driver.FindElement(By.XPath("(//*[@text='Search here'])[2]")).SendKeys("24");
                // click on  genral requesst 
                driver.FindElement(By.XPath("(//*[@text='Travel Request'])[1]")).Click();
                Thread.Sleep(2000);
                // click on  take a picture icon 
                driver.FindElement(By.XPath("(//*[@text=''])")).Click();
                Thread.Sleep(2000);
                // click on  allow button 
                driver.FindElement(By.XPath("//*[@text='ALLOW']")).Click();
                Thread.Sleep(2000);
                // click on  camera 
                driver.FindElement(By.XPath("//*[@content-desc='Shutter']")).Click();
                Thread.Sleep(2000);
                // click on right button 
                driver.FindElement(By.XPath("//*[@content-desc='Done']")).Click();
                Thread.Sleep(2000);
                //add vendor name in popup
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("Rahul kumar");
                Thread.Sleep(2000);
                // add amount in popup 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("2000");

                Thread.Sleep(2000);
                // click on submit button 
                driver.FindElement(By.XPath("//*[@text='Submit']")).Click();
                Thread.Sleep(2000);
                // click on ok button 
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);
                // click on Back  button 
                driver.FindElement(By.XPath("(//*[@class='android.view.ViewGroup'])[16]")).Click();
                Thread.Sleep(2000);
                // Enter request id in search box
                driver.FindElement(By.XPath("//*[@text='Search here']")).SendKeys("24");
                Thread.Sleep(2000);
                // click on complited button
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[4]/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[3]")).Click();
                Thread.Sleep(2000);
                // click on view Expense list button 
                driver.FindElement(By.XPath("//*[@text='View Expense List']")).Click();
                Thread.Sleep(2000);
                // click on  Expense
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[5]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup[2]")).Click();
                Thread.Sleep(2000);
                // click on Edit  button 
                driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                Thread.Sleep(2000);
                // Add Expense Description
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.EditText")).SendKeys("food Expenses");

                Thread.Sleep(2000);
                // click on select expense field
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[7]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.EditText")).Click();
                // click on any one expense  
                driver.FindElement(By.XPath("//*[@text='Dinner']")).Click();
                Thread.Sleep(2000);
                // click on Next biutton
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                Thread.Sleep(2000);
                // Add invoice number
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[8]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("1222");
                Thread.Sleep(2000);
                // click on Next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                Thread.Sleep(2000);
                //Add igst
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("10");
                Thread.Sleep(2000);
                // click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[3]")).Click();

                Thread.Sleep(2000);
                // click on ok button
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(2000);


                // /* add  another Expense  and also edit */
                // click on  Add Expense button
                driver.FindElement(By.XPath("(//*[@text='Add Expense'])[2]")).Click();
                Thread.Sleep(2000);
                //   Add  Expense Description
                // driver.FindElement(By.XPath("(//*[@index='3'])[14]")).Click();
                driver.FindElement(By.XPath("(//*[@class='android.widget.EditText'])[22]")).SendKeys("heading");
                Thread.Sleep(2000);
                //  click on Expense Type tab
                // driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[8]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[3]/android.view.ViewGroup/android.widget.EditText")).Click();
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[9]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).Click();
                //    click on any one Expense type
                driver.FindElement(By.XPath("//*[@text='Dinner']")).Click();
                Thread.Sleep(2000);
                //    click on camera
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[11]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.TextView")).Click();
                Thread.Sleep(2000);
                //    click on a second camera
                driver.FindElement(By.XPath("//*[@text='']")).Click();
                Thread.Sleep(2000);
                //    click on   first gallary (Image)
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.widget.RelativeLayout/android.view.View")).Click();
                Thread.Sleep(2000);
                //    select a image 
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.widget.RelativeLayout/android.view.View")).Click();
                Thread.Sleep(2000);


                //    click on Next button
                driver.FindElement(By.XPath("//*[@text='Next']")).Click();
                Thread.Sleep(2000);
                //    enter invoice number
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[13]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[1]")).SendKeys("1229");
                Thread.Sleep(2000);



                //    Enter vendor Name
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[13]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).SendKeys("Avi kumar");
                Thread.Sleep(2000);

                //    click on  additional detail
                driver.FindElement(By.XPath("(//*[@text='Additional Details'])[1]")).Click();
                Thread.Sleep(2000);
                //    add hsn code
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[13]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[3]")).Click();
                Thread.Sleep(2000);
                //    add palce of suplay
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[13]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[4]")).Click();
                Thread.Sleep(2000);




                //    Enter Amount
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[13]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[6]")).SendKeys("500");
                Thread.Sleep(5000);

                try
                {

                    IWebElement element1 = driver.FindElement(MobileBy.AndroidUIAutomator(
                    "new UiScrollable(new UiSelector().scrollable(true))" + ".scrollIntoView(new UiSelector().text(\"(//*[@text='Reported Receipt Amount'])[2]\"))"));

                }
                catch (Exception)
                {

                    // throw;
                }



                //    click on next  button
                driver.FindElement(By.XPath("(//*[@text='Next'])[4]")).Click();
                Thread.Sleep(5000);
                //    add cgst
                driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[14]/android.view.ViewGroup/android.view.ViewGroup/android.widget.ScrollView/android.view.ViewGroup/android.widget.EditText[2]")).Click();
                Thread.Sleep(5000);
                //    click on submit  button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[3]")).Click();
                Thread.Sleep(5000);

                //    click on Ok  button on popup
                driver.FindElement(By.XPath("//*[@text='Ok']")).Click();
                Thread.Sleep(5000);
                // reamining for wiret test cases
                //  *edit same Expense*

                //  click on Expense for Edit
                driver.FindElement(By.XPath("(//*[@text='Expense Type:'])[4]")).Click();
                Thread.Sleep(5000);
                //  click on  Edit button
                driver.FindElement(By.XPath("//*[@text='Edit']")).Click();
                Thread.Sleep(5000);
                //  click on Expense Type 
                driver.FindElement(By.XPath("(//*[@index='12'])[2]")).Click();
                Thread.Sleep(5000);
                //  change Expense Type 
                driver.FindElement(By.XPath("//*[@text='Lunch']")).Click();
                Thread.Sleep(5000);
                //  click on next button
                driver.FindElement(By.XPath("(//*[@text='Next'])[2]")).Click();
                Thread.Sleep(5000);
                //  clear privouus amount
                driver.FindElement(By.XPath("(//*[@index='7'])[15]")).Clear();
                Thread.Sleep(5000);
                //  enter new Amount 
                driver.FindElement(By.XPath("(//*[@index='7'])[15]")).SendKeys("1000");
                Thread.Sleep(2000);
                //   Click on submit button
                driver.FindElement(By.XPath("(//*[@text='Submit'])[7]")).Click();
                Thread.Sleep(2000);
                //   Click on Ok button
                driver.FindElement(By.XPath("(//*[@text='Ok'])")).Click();
                Thread.Sleep(2000);

            }
            catch (Exception ex)
            {
                result = "Fail : " + ex.Message;
            }




        }













    }
}
