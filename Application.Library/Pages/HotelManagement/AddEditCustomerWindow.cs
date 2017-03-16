using Selenium.Core.Framework.PageInitializers;
using Selenium.Core.Framework.Driver;
using Selenium.Core.Framework.UiControls;
using Selenium.Core.Framework.Utilities;

namespace Application.Library.Pages.HotelManagement
{
    public class AddEditCustomerWindow : BasePage
    {
        public AddEditCustomerWindow(UiDriver driver) : base(driver)
        {
        }

        [FindsBy]
        private TextField NameandSurnameTextbox;

        [FindsBy]
        private TextField AddressTextBox;

        [FindsBy]
        private TextField PhoneTextBox;

        [FindsBy]
        private Button SaveButton;

        [FindsBy]
        private Button AlertYes;

        public void SetNameAndSurname(string value)
        {
            NameandSurnameTextbox.SetText(value);
        }

        public void SetAddress(string value)
        {
            AddressTextBox.SetText(value);
        }

        public void SetPhoneNumber(string value)
        {
            PhoneTextBox.SetText(value);
        }

        public void ClickSaveButton()
        {
            SaveButton.Click();
        }

        public void ClickYes()
        {
            AlertYes.Click();
        }
    }
}
