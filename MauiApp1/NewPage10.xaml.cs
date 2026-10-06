using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class NewPage10 : ContentPage
{
    private ObservableCollection<string> pobraneKolory = new ObservableCollection<string>();

    public NewPage10()
    {
        InitializeComponent();

        listaKolorow.ItemsSource = pobraneKolory;

        AktualizujDuzyProstokat();
    }

    private void SuwakZmieniony(object sender, ValueChangedEventArgs e)
    {
        AktualizujDuzyProstokat();
    }

    private void AktualizujDuzyProstokat()
    {
        int r = (int)suwakR.Value;
        int g = (int)suwakG.Value;
        int b = (int)suwakB.Value;

        etykietaR.Text = r.ToString();
        etykietaG.Text = g.ToString();
        etykietaB.Text = b.ToString();

        duzyProstokat.Color = Color.FromRgb(r, g, b);

        etykietaHex.Text = $"#{r:X2}{g:X2}{b:X2}";
    }

    private void PobierzKolor(object sender, EventArgs e)
    {
        int r = (int)suwakR.Value;
        int g = (int)suwakG.Value;
        int b = (int)suwakB.Value;

        malyProstokat.BackgroundColor = Color.FromRgb(r, g, b);

        etykietaPobrany.Text = $"{r}, {g}, {b}";

        // Dodanie pobranego koloru do listy
        pobraneKolory.Add($"{r}, {g}, {b}");
    }
}
