namespace MugerKing.Views;

public partial class BaseView : ContentView
{
    public static readonly BindableProperty MainContentProperty =
                BindableProperty.Create(
                    "MainContent",
                    typeof(View),
                    typeof(BaseView),
                    null,
                    BindingMode.Default,
                    propertyChanged: MainContentChanged);

    public View MainContent
    {
        get { return (View)GetValue(MainContentProperty); }
        set { SetValue(MainContentProperty, value); }
    }

    private static void MainContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue != null && newValue is View view && bindable is BaseView page)
        {
            page.content.Children.Add(view);
        }
    }

    public static readonly BindableProperty TitleContentProperty =
        BindableProperty.Create(
            "TitleContent",
            typeof(View),
            typeof(BaseView),
            null,
            BindingMode.Default,
            propertyChanged: TitleContentChanged);

    private static void TitleContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue != null && newValue is View view && bindable is BaseView page)
        {
            page.title.Children.Add(view);
        }
    }

    public View TitleContent
    {
        get { return (View)GetValue(TitleContentProperty); }
        set { SetValue(TitleContentProperty, value); }
    }

    public static readonly BindableProperty AlertContentProperty =
        BindableProperty.Create(
    "AlertContent",
    typeof(View),
    typeof(BaseView),
    null,
    BindingMode.Default,
    propertyChanged: AlertContentChanged);

    private static void AlertContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue != null && newValue is View view && bindable is BaseView page)
        {
            page.alertContent.Content = view;
        }
    }

    public View AlertContent
    {
        get { return (View)GetValue(AlertContentProperty); }
        set { SetValue(AlertContentProperty, value); }
    }

    public void ShowAlert()
    {
        alertContainer.IsVisible = true;
    }

    public void CloseAlert(bool isAccept)
    {
        alertContainer.IsVisible = false;
        Closed?.Invoke(isAccept);
    }

    public event Action<bool> Closed;

    public BaseView()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        CloseAlert(false);
    }
}