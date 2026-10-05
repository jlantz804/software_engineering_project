namespace AdaptedPE;

public partial class TeacherSignInPage : ContentPage
{
    public TeacherSignInPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnSignInClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new SchoolLevelPage());
    }
}
