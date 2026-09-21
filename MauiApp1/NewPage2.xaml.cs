namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private void OnZamowClicked(object sender, EventArgs e)
	{
		string produkt = Produkt.Text;
		string ilosc = Ilosc.Text;
		string adres = Adres.Text;
		if(!string.IsNullOrWhiteSpace(produkt) && !string.IsNullOrWhiteSpace(adres) && !string.IsNullOrWhiteSpace(ilosc))
		{
			 DisplayAlert("Podsumowanie", $"Produkt: {produkt}, ilość: {ilosc}, adres: {adres}.", "OK");
		}
		else
		{
			DisplayAlert("Błąd", "Uzupełnij wszystkie dane!", "OK");
		} 
	}
}