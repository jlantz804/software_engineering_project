namespace AdaptedPE;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnSchoolSelected(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SchoolLevelPage());
    }
}
