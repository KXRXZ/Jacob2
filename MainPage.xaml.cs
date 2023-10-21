using MentoreeApplication.Pages;

namespace MentoreeApplication
{
    public partial class MainPage : ContentPage
    {
    

        public MainPage()
        {
            InitializeComponent();
        }

    /*    private async void OnCounterClicked(object sender, EventArgs e)
        {
             await Navigation.PushModalAsync(new Register());
        }*/

        private async void btnNext_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Register());
        }
    }
}