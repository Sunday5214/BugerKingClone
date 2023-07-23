using MugerKing.Views.Coupon;

namespace MugerKing.Views;

public partial class CouponView : ContentView
{
	private static readonly Lazy<CouponView> instance =
		new Lazy<CouponView>(() => new CouponView());
	public static CouponView Instance => instance.Value;

	public CouponView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		dynamicView.Content = new ContentView1();
    }
}