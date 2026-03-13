using Zorro.Template.App.Auth;
using Zorro.Template.App.Pages;

namespace Zorro.Template.App;

public partial class App : Application
{
    private readonly IAuthProvider _authProvider;

    public App(IAuthProvider authProvider)
    {
        InitializeComponent();
        _authProvider = authProvider;
        MainPage = new AppShell();
    }

    protected override async void OnStart()
    {
        base.OnStart();
        var isAuthenticated = await _authProvider.IsAuthenticatedAsync();
        var route = isAuthenticated ? "//dashboard" : "//login";
        await Shell.Current.GoToAsync(route);
    }
}
