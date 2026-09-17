namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnChangeWordClicked(object sender, EventArgs e)
        {
            count++;
            Przywitanie.Text = $"Aplikacja działa poprawnie";
            Licznik.Text = $"Klikniecia: {count}";
        }
        private void OnResetWordClicked(object sender, EventArgs e)
        {
            count++;
            Przywitanie.Text = $"Witamy w aplikacji";
            Licznik.Text = $"Klikniecia: {count}";
        }
    }
}
