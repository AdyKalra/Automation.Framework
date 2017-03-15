using Selenium.Core.Framework.PageInitializers;
using Selenium.Core.Framework.Driver;
using Selenium.Core.Framework.UiControls;
using Selenium.Core.Framework.Utilities;

namespace Application.Library.Pages.HotelManagement
{
    public class CustomersWindow : BasePage
    {
        public CustomersWindow(UiDriver driver) : base(driver)
        {
        }

        [FindsBy]
        private Button AddanewCustomerButton;

        [FindsBy]
        private Button RemoveaSelectedCustomerButton;

        public void ClickAddNewCustomerButton()
        {
            AddanewCustomerButton.Click();
        }

        public void ClickRemoveSelectedCustomer()
        {
            RemoveaSelectedCustomerButton.Click();
        }
    }
}
