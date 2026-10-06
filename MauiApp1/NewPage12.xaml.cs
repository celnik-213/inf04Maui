using System;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions; 

namespace MauiApp1;

public partial class NewPage12 : ContentPage
{
    public NewPage12()
    {
        InitializeComponent();
    }

    private void OnCheckPriceButtonClicked(object sender, EventArgs e)
    {
        if (Pocztówka.IsChecked)
        {
            Price.Text = "Cena: 1 zł";
            parcelPhoto.Source = "pocztowka.jpg";
        }
        else if (List.IsChecked) 
        {
            Price.Text = "Cena: 2 zł";
            parcelPhoto.Source = "list.jpg";
        }
        else if (Paczka.IsChecked)
        {
            Price.Text = "Cena: 10 zł";
            parcelPhoto.Source = "paczka.jpg";
        }
        else if (Polecony.IsChecked)
        {
            Price.Text = "Cena: 3 zł";
            parcelPhoto.Source = "polecony.jpg";
        }
    }

    private void onConfirmButtonClicked(object sender, EventArgs e)
    {
        string wzorKodu = @"^\d{2}-\d{3}$";

        if (!string.IsNullOrWhiteSpace(KodPocztowy.Text) &&
            Regex.IsMatch(KodPocztowy.Text, wzorKodu) &&
            !string.IsNullOrWhiteSpace(Ulica.Text) &&
            !string.IsNullOrWhiteSpace(Miasto.Text))
        {
            DisplayAlert("Potwierdzenie", "Dane przesyłki zostały wprowadzone", "OK");
        }
        else
        {
            DisplayAlert("Błąd", "Proszę wpisać poprawny kod pocztowy, musi się składać z samych cyfr (schemat to 22-400) oraz uzupełnić pozostałe pola.", "OK");
        }
    }
}