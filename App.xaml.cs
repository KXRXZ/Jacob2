using MentoreeApplication.Pages;

namespace MentoreeApplication

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Role();           
        }
    }
}