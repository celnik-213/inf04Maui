namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void OnImieClicked(object sender, EventArgs e)
	{
		string miasto = poleMiasto.Text;
		Tekst.Text = $"Witaj {miasto}";
	}

    private void Przycisk_Clicked(object sender, EventArgs e)
    {

    }
}