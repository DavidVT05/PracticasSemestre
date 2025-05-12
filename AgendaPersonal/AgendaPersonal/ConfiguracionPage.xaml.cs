using AgendaPersonal.Views;

namespace AgendaPersonal;

public partial class ConfiguracionPage : ContentPage
{
	public ConfiguracionPage()
	{
		InitializeComponent();
	}
    private void Cambiar(object sender, EventArgs e)
    {
        var app = Application.Current;
        app.UserAppTheme = app.UserAppTheme == AppTheme.Light
            ? AppTheme.Dark
            : AppTheme.Light;
    }
    private void IrCerrar(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage(), true);
    }
}