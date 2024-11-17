using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class contratacaoHospedagem : ContentPage
{
	App PropriedadesApp;


	public contratacaoHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);
        dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);


    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new hospedagemContratada());

		}catch(Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Ok");
		}

    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(2);
    }

    private void pck_quarto_SelectedIndexChanged(object sender, EventArgs e)
    {
		Picker quarto = (Picker)sender;

		int indiceQuartoSelecionado = quarto.SelectedIndex;
		
		if(indiceQuartoSelecionado != -1)
		{
			lbl_descricaoQuarto.Text = (string)PropriedadesApp.lista_quartos[indiceQuartoSelecionado].descricao;
		}
    }
}