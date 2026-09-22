namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void OnPokazClicked(object sender, EventArgs e)
	{
		string imie = poleImie.Text;
		string miasto = poleMiasto.Text;
		if (!string.IsNullOrWhiteSpace(imie) && !string.IsNullOrWhiteSpace(miasto))
		{
			Tekst.Text = $"Witaj, {imie} z miasta: {miasto}";
		}
		else 
		{
			DisplayAlertAsync("Błąd", "Uzupełnij dane!", "OK");
		}
	}

}