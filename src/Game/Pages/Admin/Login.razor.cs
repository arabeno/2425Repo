using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Game.Pages.Admin
{
    public partial class Login : ComponentBase
    {
        [Inject]
        private NavigationManager Navigation { get; set; } = default!;

        [Inject]
        private IJSRuntime JSRuntime { get; set; } = default!;

        private LoginModel loginModel = new LoginModel();
        private bool showPassword = false;

        private void TogglePassword()
        {
            showPassword = !showPassword;
        }

        private void HandleLogin()
        {
            if (loginModel.Username == "user123" && loginModel.Password == "pass123")
            {
                Navigation.NavigateTo("/Main");
            }
            else
            {
                JSRuntime.InvokeVoidAsync("alert", "You have entered an invalid username or password.");
            }
        }

         private void NavigateToLoginBox()
        {
            Navigation.NavigateTo("/LoginBox");
        }

        private void NavigateToReset()
        {
            Navigation.NavigateTo("/Reset");
        }

        private void NavigateToTerms()
        {
            Navigation.NavigateTo("/Terms");
        }

        private void NavigateToMain()
        {
            Navigation.NavigateTo("/Main");
        }

        private void NavigateToGameBoard(){
            Navigation.NavigateTo("/GameBoard");
        }

        public class LoginModel
        {
            public string Username { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public bool RememberMe { get; set; } = false;
        }
    }
}