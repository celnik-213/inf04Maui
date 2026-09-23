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
}