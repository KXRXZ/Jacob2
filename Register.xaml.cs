using CommunityToolkit.Mvvm;

namespace MentoreeApplication.Pages;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}
    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new Splash());
    }

    private async void btnSignup_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Login());
    }
}