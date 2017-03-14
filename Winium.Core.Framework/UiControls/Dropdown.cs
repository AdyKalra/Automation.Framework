﻿using OpenQA.Selenium.Support.UI;
using Winium.Core.Framework.Driver;
using Winium.Core.Framework.Utilities;

namespace Winium.Core.Framework.UiControls
{
    public class Dropdown : Element
    {
        public Dropdown(UiDriver driver, How findBy, string findByValue) :
            base(driver, findBy, findByValue)
        {

        }

        public Dropdown()
        {

        }

        public void SelectByIndex(int index)
        {
            var element = _driver.FindElement(_findBy, _findByValue);
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }

        public void SelectByText(string text)
        {
            var element = _driver.FindElement(_findBy, _findByValue);
            SelectElement select = new SelectElement(element);
            select.SelectByText(text);
        }

        public void SelectByValue(string value)
        {
            var element = _driver.FindElement(_findBy, _findByValue);
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }
    }
}
