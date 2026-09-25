namespace MauiApp1;

public partial class NewPage4 : ContentPage
{
	public NewPage4()
	{
		InitializeComponent();
	}
    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		string value = Stepper.Value.ToString("F0");
		StepperValue.Text = $"Osoby: {value}";
    }
	private void OnButtonClicked(object sender, EventArgs e)
	{
        string value = Stepper.Value.ToString("F0");
        if (PickerSale.SelectedIndex == -1)
		{
			DisplayAlert("Błąd", "Wybierz sale", "OK");
		}
		else
		{
            string picker = PickerSale.SelectedItem.ToString();
			DisplayAlert("Rezerwacja pomyślna", $"Sala: {picker},\n Liczba osób: {value},\n Data: {Data.Date:yyyy-MM-dd}", "OK");
		}

    }
}