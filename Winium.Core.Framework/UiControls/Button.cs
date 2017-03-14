using Winium.Core.Framework.Driver;
using Winium.Core.Framework.Utilities;

namespace Winium.Core.Framework.UiControls
{
    public class Button : Element
    {
        public Button(UiDriver driver, How findBy, string findByValue) : 
            base(driver, findBy, findByValue)
        {
        }

        public Button()
        {

        }

        public void Submit()
        {
            _driver.Submit(_findBy, _findByValue);
        }

        public string GetButtonText()
        {
            return GetTextAttribute();
        }
    }
}
