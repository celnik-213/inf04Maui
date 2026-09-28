namespace MauiApp1;

public partial class NewPage7 : ContentPage
{
	public NewPage7()
	{
		InitializeComponent();
	}
	private void ObliczPole_Clicked(object sender, EventArgs e)
    {
        if(string.IsNullOrWhiteSpace(bokAEntry.Text) || string.IsNullOrWhiteSpace(bokBEntry.Text))
        {
             DisplayAlert("Błąd", "Proszę wprowadzić wartości boków.", "OK");
            return;
        } else if (!double.TryParse(bokAEntry.Text, out _) || !double.TryParse(bokBEntry.Text, out _))
        {
            DisplayAlert("Błąd", "Proszę wprowadzić poprawne liczby.", "OK");
            return;
        }else if (double.Parse(bokAEntry.Text) <= 0 || double.Parse(bokBEntry.Text) <= 0)
        {
            DisplayAlert("Błąd", "Proszę wprowadzić liczby większe od zera.", "OK");
            return;
        }
        else { 
        double a = double.Parse(bokAEntry.Text);
        double b = double.Parse(bokBEntry.Text);
        double pole = a * b;
        WynikLabel.Text = $"Pole prostokąta wynosi: {pole}";
        }
    }
    private async void Wyczysc_Clicked(object sender, EventArgs e)
    {
        bool odpowiedz = await DisplayAlert("Potwierdzenie", "Czy na pewno chcesz usunąć to konto?", "Tak", "Nie");
        {
            if (odpowiedz) { 
            bokAEntry.Text = "";
            bokBEntry.Text = "";
            WynikLabel.Text = "";
            }
        }
    }
}