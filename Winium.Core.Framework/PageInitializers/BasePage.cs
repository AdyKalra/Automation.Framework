using Winium.Core.Framework.Driver;

namespace Winium.Core.Framework.PageInitializers
{
    public class BasePage
    {
        public BasePage(UiDriver driver)
        {
            PageInitializer.Initialize(this, driver);
        }
    }
}
