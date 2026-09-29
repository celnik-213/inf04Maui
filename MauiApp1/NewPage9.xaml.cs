namespace MauiApp1;

public partial class NewPage9 : ContentPage
{
	public NewPage9()
	{
		InitializeComponent();
	}
	private void Button_OnClicked(object sender, EventArgs e)
    {
		int rgb = (int)Suwak.Value;
        LabelWynik.BackgroundColor = Color.FromRgb(rgb, rgb, rgb);
		LabelWynik.Text = $"Kolor: #{rgb:X2}{rgb:X2}{rgb:X2}";

    }
}