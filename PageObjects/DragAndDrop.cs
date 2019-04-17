using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace PageObjects
{
    public class DragAndDrop
    {
        private IWebDriver driver;

        public DragAndDrop(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AssignRoomType(IWebDriver driver, int number,int position)
        {
            
            string[] roomtypes =
            {
             //    "First Label" 
             "/p-picklist/div/div[1]/ul/li[1]",
             //    "Clean rinsing room",
             "/p-picklist/div/div[1]/ul/li[2]",
             //    "Second Label",
             "p-picklist/div/div[1]/ul/li[3]",
             //    "Medication room",
            "/p-picklist/div/div[1]/ul/li[4]",
             //    "Third Label",
             "/p-picklist/div/div[1]/ul/li[5]",
             //    "Office",
             "/p-picklist/div/div[1]/ul/li[6]",
             //    "Fourth Label",
            "//p-picklist/div/div[1]/ul/li[7]",
             //    "Patient room",
             "/p-picklist/div/div[1]/ul/li[8]",
             //    "Fifh Label",
             "//p-picklist/div/div[1]/ul/li[9]",
             //    "Staff toilet"
            "/p-picklist/div/div[1]/ul/li[10]"
            };


            IWebElement RoomTypes = driver.FindElement(By.CssSelector("#ui-tabpanel-1-label"));
            var actions = new Actions(driver);
            RoomTypes.Click();

            IWebElement[] elements =
            {
                driver.FindElement(By.XPath(roomtypes[1])),
                driver.FindElement(By.XPath(roomtypes[2])),
                driver.FindElement(By.XPath(roomtypes[3])),
                driver.FindElement(By.XPath(roomtypes[6])),
                driver.FindElement(By.XPath(roomtypes[7])),
                driver.FindElement(By.XPath(roomtypes[8])),
                driver.FindElement(By.XPath(roomtypes[9])),
                driver.FindElement(By.XPath(roomtypes[10]))
            };
            actions.MoveToElement(elements[number]).Build().Perform();
            actions.ClickAndHold(elements[number]).MoveToElement(elements[position]).Release().Build().Perform();

        }
    }
}
