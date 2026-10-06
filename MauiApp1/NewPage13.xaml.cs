namespace MauiApp1;

public partial class NewPage13 : ContentPage
{
        int count = 0;
	public NewPage13()
	{
		InitializeComponent();
    }
    private void OnCounterClicked(object? sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}