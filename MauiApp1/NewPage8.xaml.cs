using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class NewPage8 : ContentPage
{
    private ObservableCollection<string> zakupy =
        new ObservableCollection<string>();
    public NewPage8()
	{
		InitializeComponent();
		WidokListy.ItemsSource = zakupy;
	}
	private void Dodaj_Clicked(object sender, EventArgs e)
	{
		string produkt = PoleZakupu.Text;
        if (string.IsNullOrWhiteSpace(produkt))
		{
			return;
		}
		zakupy.Add(produkt);
		PoleZakupu.Text = "";
		AktualizujLicznik();
    }
	private void Usun_Clicked(object sender, EventArgs e)
    {
        if (WidokListy.SelectedItem == null)
        {
			return;
        }
		string produkt = (string)WidokListy.SelectedItem;
		zakupy.Remove(produkt);
		AktualizujLicznik();

    }
	private void AktualizujLicznik()
	{
		EtykietaLicznik.Text = $"Liczba produktów: {zakupy.Count}";
    }
}