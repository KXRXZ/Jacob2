namespace MentoreeApplication.Pages;

public partial class RegisterForm : ContentPage
{
	public RegisterForm()
	{
		InitializeComponent();
	}

    private async void btnNext_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Register());
    }
}