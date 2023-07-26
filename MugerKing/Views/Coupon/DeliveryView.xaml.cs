namespace MugerKing.Views.Coupon;

public partial class DeliveryView : ContentView
{
    private static readonly Lazy<DeliveryView> instance =
        new Lazy<DeliveryView>(() => new DeliveryView());
    public static DeliveryView Instance => instance.Value;
    public DeliveryView()
	{
		InitializeComponent();
	}
}