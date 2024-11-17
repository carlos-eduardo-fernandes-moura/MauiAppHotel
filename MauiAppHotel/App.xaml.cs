
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                nome = "Suíte super luxo",
                descricao = "1 suíte, Café da manhã, almoço e janta incluso",
                valorDiariaAdulto = 150.00,
                valorDiariaCrianca = 100
            },

            new Quarto()
            {
                nome = "Suíte de luxo",
                descricao = "1 suíte, café da manhã e almoço incluso",
                valorDiariaAdulto = 100.00,
                valorDiariaCrianca = 80.00
            },

            new Quarto()
            {
                nome = "Suíte padrão",
                descricao = "1 suíte, café da manhã incluso",
                valorDiariaAdulto = 80.00,
                valorDiariaCrianca = 60.00
            },

            new Quarto()
            {
                nome = "Suite standart",
                descricao = "1 suíte, sem refeições inclusas",
                valorDiariaAdulto = 50.00,
                valorDiariaCrianca = 30.00
            }

        };

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
