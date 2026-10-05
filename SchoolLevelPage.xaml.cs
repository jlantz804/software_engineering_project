namespace AdaptedPE;

public partial class SchoolLevelPage : ContentPage
{
    public SchoolLevelPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
