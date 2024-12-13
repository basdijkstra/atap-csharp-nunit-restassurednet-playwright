using ATAPNUnitRestAssuredNetPlaywright.UiTests.Pages;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace ATAPNUnitRestAssuredNetPlaywright.UiTests
{
    [TestFixture]
    public class ExampleUiTests : PageTest
    {
        [Test]
        public async Task CheckLoginToSauceDemoShop()
        {
            var loginPage = new LoginPage(Page);
            await loginPage.Open();
            await loginPage.LoginAs("standard_user", "secret_sauce");            

            // Check that the Sauce Labs Backpack product link is visible
            await Expect(Page.GetByText("Sauce Labs Backpack")).ToBeVisibleAsync();
        }
    }
}
