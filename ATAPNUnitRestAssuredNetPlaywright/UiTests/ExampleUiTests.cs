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
            // Navigate to the Sauce Demo home page
            await Page.GotoAsync("https://www.saucedemo.com");

            // Perform the login sequence
            await Page.GetByPlaceholder("Username").FillAsync("standard_user");
            await Page.GetByPlaceholder("Password").FillAsync("secret_sauce");
            await Page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();

            // Check that the Sauce Labs Backpack product link is visible
            await Expect(Page.GetByText("Sauce Labs Backpack")).ToBeVisibleAsync();
        }
    }
}
