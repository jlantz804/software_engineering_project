namespace AdaptedPE;

/*
Author: Joey Lantz
Date: October 4th
Description: This is the teacher sign-in page logic
Bugs: None found
*/

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
