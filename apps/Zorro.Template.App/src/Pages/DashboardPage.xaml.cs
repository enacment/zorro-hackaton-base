using Zorro.Template.App.Auth;

namespace Zorro.Template.App.Pages;

public partial class DashboardPage : ContentPage
{
    private readonly IAuthProvider _authProvider;

    public DashboardPage(IAuthProvider authProvider)
    {
        InitializeComponent();
        _authProvider = authProvider;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var session = await _authProvider.GetCurrentSessionAsync();
        WelcomeLabel.Text = session is not null
            ? $"Bienvenido, {session.Username}"
            : "Bienvenido";
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await _authProvider.LogoutAsync();
        await Shell.Current.GoToAsync("//login");
    }
}
