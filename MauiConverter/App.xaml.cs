using MauiConverter.MVVM.Views;

namespace MauiConverter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MenuView());
    }
}
