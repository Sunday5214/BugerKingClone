namespace MugerKing.Views;

public partial class MoreView : ContentView
{
    private static readonly Lazy<MoreView> instance =
        new Lazy<MoreView>(() => new MoreView());
    public static MoreView Instance => instance.Value;
    public MoreView()
	{
		InitializeComponent();
	}
}