namespace AdaptedPE;

/*
Author: Joey Lantz
Date: October 4th
Description: This is the main page logic
Bugs: None found
*/

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

    private async void OnTeacherSignInTapped(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new TeacherSignInPage());
    }
}
