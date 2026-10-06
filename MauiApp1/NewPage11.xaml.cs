namespace MauiApp1;

public partial class NewPage11 : ContentPage
{
	public NewPage11()
	{
		InitializeComponent();
	}
    private void NumerOpuszczony(object sender, FocusEventArgs e)

    {
        string numer = poleNumer.Text;

        if (string.IsNullOrWhiteSpace(numer))

        {
            obrazZdjecie.Source = null;
            obrazOdcisk.Source = null;
            return;

        }
        obrazZdjecie.Source = numer + "–lada.jpg";
        obrazOdcisk.Source = numer + "–ae86.jpg";
    }
    private async void ZatwierdzDane(object sender, EventArgs e)

    {
        string imie = poleImie.Text;

        string nazwisko = poleNazwisko.Text;

        if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))

        {

            await DisplayAlert("Uwaga", "Wprowadz dane", "OK");
            return;

        }
        string kolorOczu = PobierzKolorOczu();



        string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

        await DisplayAlert("Dane paszportowe", komunikat, "OK");

    }
    private string PobierzKolorOczu()

    {

        if (oczyNiebieskie.IsChecked)

            return "niebieskie";

        if (oczyZielone.IsChecked)

            return "zielone";



        return "piwne";

    }
}