using MugerKing.Views;

namespace MugerKing;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new InfomationPage(); //new NavigationPage(new MainPage());
	}
}
