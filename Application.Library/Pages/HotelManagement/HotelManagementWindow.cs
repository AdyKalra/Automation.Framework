using Selenium.Core.Framework.PageInitializers;
using Selenium.Core.Framework.Driver;
using Selenium.Core.Framework.UiControls;
using Selenium.Core.Framework.Utilities;

namespace Application.Library.Pages.HotelManagement
{
    public class HotelManagementWindow : BasePage
    {
        public HotelManagementWindow(UiDriver driver) : base(driver)
        {
        }

        [FindsBy]
        private Button CustomersTab;

        public void ClickCustomersTab()
        {
            CustomersTab.WaitTillClickable(120);
            CustomersTab.Click();
        }
    }
}
