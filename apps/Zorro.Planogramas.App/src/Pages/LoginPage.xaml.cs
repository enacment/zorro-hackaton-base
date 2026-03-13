using Zorro.Planogramas.App.Auth;

namespace Zorro.Planogramas.App.Pages;

public partial class LoginPage : ContentPage
{
    private readonly IAuthProvider _authProvider;

    public LoginPage(IAuthProvider authProvider)
    {
        InitializeComponent();
        _authProvider = authProvider;
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        ErrorLabel.IsVisible = false;
        LoginButton.IsEnabled = false;

        var username = UsernameEntry.Text?.Trim() ?? string.Empty;
        var password = PasswordEntry.Text ?? string.Empty;

        var result = await _authProvider.LoginAsync(username, password);

        if (result.Success)
        {
            await Shell.Current.GoToAsync("//work");
        }
        else
        {
            ErrorLabel.Text = result.Error ?? "Error al iniciar sesión.";
            ErrorLabel.IsVisible = true;
            LoginButton.IsEnabled = true;
        }
    }
}
