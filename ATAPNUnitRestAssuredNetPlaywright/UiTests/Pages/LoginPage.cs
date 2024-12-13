using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Playwright;

namespace ATAPNUnitRestAssuredNetPlaywright.UiTests.Pages
{
    public class LoginPage
    {
        private readonly IPage page;
        
        public LoginPage(IPage page)
        {
            this.page = page;
        }

        public async Task Open()
        {
            await this.page.GotoAsync("https://www.saucedemo.com");
        }

        public async Task LoginAs(string username, string password)
        {
            await this.page.GetByPlaceholder("Username").FillAsync("standard_user");
            await this.page.GetByPlaceholder("Password").FillAsync("secret_sauce");
            await this.page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();
        }
    }
}
