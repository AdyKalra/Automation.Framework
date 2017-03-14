﻿using OpenQA.Selenium;
using Winium.Core.Framework.Driver;
using Winium.Core.Framework.UiControls;
using Winium.Core.Framework.Utilities;

namespace Winium.Core.Framework.UiControls
{
    public class TextField : Element
    {
        public TextField(UiDriver driver, How findBy, string findByValue) : base(driver, findBy, findByValue)
        {
        }

        public void SetText(string value)
        {
            _driver.SetText(_findBy, _findByValue, value);
        }

        public void ClearText()
        {
            _driver.Clear(_findBy, _findByValue);
        }

        public void KeyEnter()
        {
            _driver.SetText(_findBy, _findByValue, Keys.Enter);
        }

        public void KeyTab()
        {
            _driver.SetText(_findBy, _findByValue, Keys.Tab);
        }
    }
}
