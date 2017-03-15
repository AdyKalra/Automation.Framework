using Application.Library.Pages.HotelManagement;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Application.Tests.StepDefinitions
{
    [Binding]
    public sealed class SampleWiniumTestStepDefinition
    {
        AddEditCustomerWindow addeditCustomer;
        CustomersWindow customer;
        HotelManagementWindow mainWindow;

        public SampleWiniumTestStepDefinition()
        {
            var unity = TestBase.Unity;
            addeditCustomer = unity.Resolve<AddEditCustomerWindow>();
            customer = unity.Resolve<CustomersWindow>();
            mainWindow = unity.Resolve<HotelManagementWindow>();
        }

        [When(@"I Click Customers Tab")]
        public void WhenIClickCustomersTab()
        {
            mainWindow.ClickCustomersTab();
        }

        [When(@"I Click Add New Customer Button")]
        public void WhenIClickAddNewCustomerButton()
        {
            customer.ClickAddNewCustomerButton();
        }

        [When(@"I Set NameandSurname as (.*)")]
        public void WhenISetNameandSurnameAs(string name)
        {
            addeditCustomer.SetNameAndSurname(name);
        }

        [When(@"I Set Address as (.*)")]
        public void WhenISetAddressAs(string address)
        {
            addeditCustomer.SetAddress(address);
        }

        [When(@"I Set PhoneNumber as (.*)")]
        public void WhenISetPhoneNumberAs(string phone)
        {
            addeditCustomer.SetPhoneNumber(phone);
        }

        [When(@"I Click Save Button")]
        public void WhenIClickSaveButton()
        {
            addeditCustomer.ClickSaveButton();
        }

    }
}
