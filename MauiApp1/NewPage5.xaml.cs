namespace MauiApp1;

public partial class NewPage5 : ContentPage
{
	public NewPage5()
	{
		InitializeComponent();
	}
    int counte = 0;
    private void OnPlusClicked(object sender, EventArgs e)
    {
        counte = counte + 1;
        wyswietl.Text = $"Liczba polubien: {counte}";
    }
    private void OnMinusClicked(object sender, EventArgs e)
    {
        if(counte > 0)
        {
            counte = counte - 1;
            wyswietl.Text = $"Liczba polubien: {counte}";
        }
        else
        {
            DisplayAlert("Bład", "Liczba nie może być mniejsza od zera", "OK");
        }
    }
    private void OnZerujClicked(object sender, EventArgs e)
    {
        counte = 0;
        wyswietl.Text = $"Liczba polubien: {counte}";
    }
}