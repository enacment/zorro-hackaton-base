using Zorro.Traspasos.App.Auth;

namespace Zorro.Traspasos.App;

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
        var route = isAuthenticated ? "//work" : "//login";
        await Shell.Current.GoToAsync(route);
    }
}
