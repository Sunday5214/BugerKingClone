namespace MugerKing.Views;

public partial class HomeView : ContentView
{
    private static readonly Lazy<HomeView> instance =
        new Lazy<HomeView>(() => new HomeView());
    public static HomeView Instance => instance.Value;
    public HomeView()
	{
		InitializeComponent();
	}
}