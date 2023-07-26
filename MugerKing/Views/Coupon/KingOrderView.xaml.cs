namespace MugerKing.Views.Coupon;

public partial class KingOrderView : ContentView
{
    private static readonly Lazy<KingOrderView> instance =
        new Lazy<KingOrderView>(() => new KingOrderView());
    public static KingOrderView Instance => instance.Value;
    public KingOrderView()
	{
		InitializeComponent();
	}
}