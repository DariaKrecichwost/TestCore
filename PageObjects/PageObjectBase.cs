using Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace PageObjects
{
    public abstract class PageObjectBase: Base
    {
        public WebDriverWait WebDriverWait { get; }

        public void CheckCurrentUrl(IWebDriver Driver)
        {
            string currentURL = Driver.Url;
        }

        public PageObjectBase(IWebDriver webDriver)
        {
            Driver = webDriver;
            WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(webDriver, this);
        }
        public void PressTab(IWebDriver driver)
        {
            driver.FindElement(By.Id("body")).SendKeys(Keys.Tab);
        }
        public virtual void WaitForSaveToAppear()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            WebDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("button[type='submit']")));
            WebDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("button[type='submit']")));
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }
        public virtual void WaitForModalHidden()
        {
            try
            {
                WebDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(By.CssSelector("div.modal-body")));
              
            }
            catch (NoSuchElementException)
            {

                throw;
            }
        }
        public virtual void WaitForElementClickable(IWebElement element)
        {
            WebDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }
    }
}

