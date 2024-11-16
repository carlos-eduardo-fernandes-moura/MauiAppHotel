
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.contratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window  = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 900;
            return window;
        }
    }
}
