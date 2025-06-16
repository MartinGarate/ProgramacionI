using MauiApp2222.Views;

namespace MauiApp2222
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PeliculasView();
        }
    }
}
