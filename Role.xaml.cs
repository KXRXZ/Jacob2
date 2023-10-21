namespace MentoreeApplication.Pages;

public partial class Role : ContentPage
{
	public Role()
	{
		InitializeComponent();

        var image1 = new Image
        {
            Source = "teacher_with_transparent.png",
            WidthRequest = 10,
            Aspect = Aspect.AspectFit
        };

        var image2 = new Image
        {
            Source = "student_with_transparent.png",
            WidthRequest = 10,
            Aspect = Aspect.AspectFit
        };
    }

    private async void MentorImg_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new RegisterForm());
    }

    private async void MenteeReg_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new RegisterForm());
    }
}