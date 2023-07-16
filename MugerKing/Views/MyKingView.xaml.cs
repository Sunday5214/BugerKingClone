namespace MugerKing.Views;

public partial class MyKingView : ContentView
{
    private static readonly Lazy<MyKingView> instance =
        new Lazy<MyKingView>(() => new MyKingView());
    public static MyKingView Instance => instance.Value;
    public MyKingView()
	{
		InitializeComponent();
	}
}