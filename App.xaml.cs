using Microsoft.Extensions.DependencyInjection;

using Software_App.Views;
namespace Software_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		 return new Window(new ActivitiesPage());  //uncomment this line to set ActivitiesPage as the main page
		 //return new Window(new BasketballPage());  //uncomment this line to set BasketballPage as the main page
	}
}