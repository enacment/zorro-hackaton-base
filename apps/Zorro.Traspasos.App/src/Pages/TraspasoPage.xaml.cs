using Zorro.Traspasos.App.Auth;

namespace Zorro.Traspasos.App.Pages;

public partial class TraspasoPage : ContentPage
{
    private readonly IAuthProvider _authProvider;

    public TraspasoPage(IAuthProvider authProvider)
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
