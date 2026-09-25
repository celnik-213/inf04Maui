namespace MauiApp1;

public partial class NewPage6 : ContentPage
{
	public NewPage6()
	{
		InitializeComponent();
        Kolor.Background = Color.FromRgb(0, 0, 0);
    }
    private void SuwakValueChanged(object sender, ValueChangedEventArgs e)
    {

        int r = (int)SuwakR.Value;
        int g = (int)SuwakG.Value;
        int b = (int)SuwakB.Value;


        Kolor.Background = Color.FromRgb(r, g, b);


        string hexR = r.ToString("X2");
        string hexG = g.ToString("X2");
        string hexB = b.ToString("X2");

        EtykietaKolor.Text = "#" + hexR + hexG + hexB;
    }
}