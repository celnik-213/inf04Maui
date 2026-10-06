namespace MauiApp1;

public partial class NewPage14 : ContentPage
{
	public NewPage14()
	{
		InitializeComponent();
	}
    private void OnCalculateTipClicked(object? sender, EventArgs e)
    {
        double tip = 0;
        if (Tip10.IsChecked)
        {
            tip = 0.1;
        }
        else if (Tip15.IsChecked)
        {
            tip = 0.15;
        }
        else if (Tip20.IsChecked)
        {
            tip = 0.2;
        }
        else if (Tip25.IsChecked)
        {
            tip = 0.25;
        }

        if (double.TryParse(BillAmount.Text, out double billAmount))
        {
            if (int.TryParse(NumberOfPeople.Text, out int Pepole))
            {
                if (Pepole > 0)
                {
                    TipAmount.Text = $"Tip Amount: {(billAmount * tip) / Pepole:C}";
                    TotalAmount.Text = $"Total Amount: {(billAmount + (billAmount * tip)):C}";
                    WithPepole.Text = $"Total Amount: {(billAmount + (billAmount * tip)) / Pepole:C}";
                }
                else
                {
                    DisplayAlert("Error", "Wprowadź poprawą liczbę osób", "OK");
                }
            }
        }
        else
        {
            DisplayAlert("Error", "Wprowadź poprawą kwotę", "OK");
        }


    }
    private void OnClearClicked(object? sender, EventArgs e)
    {
        BillAmount.Text = string.Empty;
        TipAmount.Text = "Napiwek: ";
        TotalAmount.Text = "Razem: ";
        Tip10.IsChecked = true;
    }
}