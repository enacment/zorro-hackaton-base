using Zorro.Planogramas.App.Auth;

namespace Zorro.Planogramas.App.Pages;

public partial class PlanogramasPage : ContentPage
{
    private readonly IAuthProvider _authProvider;

    public PlanogramasPage(IAuthProvider authProvider)
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
