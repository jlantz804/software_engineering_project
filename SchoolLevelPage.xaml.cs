namespace AdaptedPE;

/*
Author: Joey Lantz
Date: October 4th
Description: This is the school level page logic
Bugs: None found
*/

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
