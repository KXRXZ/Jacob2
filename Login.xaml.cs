namespace MentoreeApplication.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void btnLogin_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new Splash());
	}
}