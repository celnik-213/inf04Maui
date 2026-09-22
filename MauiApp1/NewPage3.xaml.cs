namespace MauiApp1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}

	private void OnZapiszClicked(object sender, EventArgs e)
	{
		string imie = Imie.Text;
		bool wiedza = Wiedza.IsChecked;
		bool certyfikat = Certyfikat.IsToggled;
		object forma = RadioButtonGroup.GetSelectedValue(Kursy1);
		string oczekiwania = Oczekiwania.Text;

		if(wiedza == false || certyfikat == false)
		{
			DisplayAlert("Błąd", "Zaznacz pole z wiedzą i certyfikatem", "Ok");
		}else if(string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(oczekiwania))
		{
			DisplayAlert("Błąd", "Uzupełnij pole z imieniem i nazwiskiem i oczekiwania", "Ok");
        }else
		{
			DisplayAlert("Sukces", $"{imie} pomyślnie zapisano na kurs,czy posiadasz podstawową wiedzę: {wiedza}, czy chcesz otrzymać certyfikat: {certyfikat} forma: {forma} oczekiwania: {oczekiwania}", "Ok");
		}
	}
}