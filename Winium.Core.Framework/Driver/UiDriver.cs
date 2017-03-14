using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winium.Core.Framework.Utilities;
using Winium.Elements.Desktop;

namespace Winium.Core.Framework.Driver
{
    public class UiDriver
    {
        static IWebDriver _nativedriver;

        static UiDriver()
        {
            _nativedriver = NativeDriver.Instance.NativeWiniumDriver;
        }

        #region Find Element Methods

        internal By GetByLocator(How findBy, string findByValue)
        {
            switch (findBy)
            {
                case How.Id:
                    return By.Id(findByValue);

                case How.TagName:
                    return By.TagName(findByValue);

                case How.Name:
                    return By.Name(findByValue);

                case How.ClassName:
                    return By.ClassName(findByValue);

                case How.Xpath:
                    return By.XPath(findByValue);

                case How.CssSelector:
                    return By.CssSelector(findByValue);

                case How.LinkText:
                    return By.LinkText(findByValue);

                case How.PartialLinkText:
                    return By.PartialLinkText(findByValue);

                default:
                    throw new Exception("Not a valid Locator type: " + findBy);
            }
        }

        internal IWebElement FindElement(How findBy, string findByvalue)
        {
            try
            {
                var bylocator = GetByLocator(findBy, findByvalue);
                var webElement = _nativedriver.FindElement(bylocator);
                return webElement;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal IReadOnlyCollection<IWebElement> FindElements(How findBy, string findByvalue)
        {
            try
            {
                var bylocator = GetByLocator(findBy, findByvalue);
                var elements = _nativedriver.FindElements(bylocator);
                return elements;
            }

            catch (Exception ex)
            {               
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Element Actions
        internal void Click(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            webElement.Click();
        }

        public string GetAttributeValue(How findBy, string findByValue, string attributeName)
        {
            var webElement = FindElement(findBy, findByValue);
            return webElement.GetAttribute(attributeName);
        }

        public string GetTextAttribute(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            return webElement.Text;
        }

        public string GetCssValue(How findBy, string findByValue, string propertyName)
        {
            var webElement = FindElement(findBy, findByValue);
            return webElement.GetCssValue(propertyName);
        }

        public bool IsDisplayed(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            return webElement.Displayed;
        }

        public bool IsEnabled(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            return webElement.Enabled;
        }

        public void Submit(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            webElement.Submit();
        }

        public void SetText(How findBy, string findByValue, string value)
        {
            var webElement = FindElement(findBy, findByValue);
            webElement.SendKeys(value);
        }

        public void Clear(How findBy, string findByValue)
        {
            var webElement = FindElement(findBy, findByValue);
            webElement.Clear();
        }
        #endregion

        #region Wait Methods
        internal void WaitTillElementisVisible(How findBy, string findByValue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementIsVisible(GetByLocator(findBy, findByValue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal void WaitTillElementExists(How findBy, string findByValue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementExists(GetByLocator(findBy, findByValue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal void WaitTillElementToBeClickable(How findBy, string findByValue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementToBeClickable(GetByLocator(findBy, findByValue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal void WaitTillElementToBeSelected(How findBy, string findByValue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.ElementToBeSelected(GetByLocator(findBy, findByValue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal void WaitTillElementisInvisible(How findBy, string findByValue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(GetByLocator(findBy, findByValue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void WaitTillTextToBePresent(How findBy, string findByValue, string text, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.TextToBePresentInElement(FindElement(findBy, findByValue), text));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void WaitTillTitleContains(string title, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.TitleContains(title));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void WaitTillTitleIs(string title, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.TitleIs(title));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void WaitTillUrlContains(string url, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.UrlContains(url));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void WaitTillUrlToBe(string url, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.UrlToBe(url));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal void WaitTillElementsArePresent(How findBy, string findByvalue, int seconds = 60)
        {
            try
            {
                var wait = new WebDriverWait(_nativedriver, TimeSpan.FromSeconds(seconds));
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(GetByLocator(findBy, findByvalue)));
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
