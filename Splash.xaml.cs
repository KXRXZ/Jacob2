namespace MentoreeApplication.Pages;

public partial class Splash : ContentPage
{
   
    public Splash()
	{
		InitializeComponent();
	}

    private void onScreenTapped(object sender, TappedEventArgs e)
    {
        
    }

    private async void getStartedBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Role());
    }
}