using Zorro.Precios.App.Auth;

namespace Zorro.Precios.App.Pages;

public partial class PreciosPage : ContentPage
{
    private readonly IAuthProvider _authProvider;

    public PreciosPage(IAuthProvider authProvider)
    {
        InitializeComponent();
        _authProvider = authProvider;
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await _authProvider.LogoutAsync();
        await Shell.Current.GoToAsync("//login");
    }
}
