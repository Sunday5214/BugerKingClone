namespace MugerKing.Views.Coupon;

public partial class StoreView : ContentView
{
    private static readonly Lazy<StoreView> instance =
        new Lazy<StoreView>(() => new StoreView());
    public static StoreView Instance => instance.Value;
    public StoreView()
	{
		InitializeComponent();
	}
}