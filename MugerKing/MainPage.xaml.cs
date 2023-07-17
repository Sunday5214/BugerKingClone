using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace MugerKing;

public partial class MainPage : ContentPage
{
    bool canCloseApp = false;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void ShowBackButtonToast()
    {
        string text = "한 번 더 누르면 종료됩니다.";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show();
    }

    protected override bool OnBackButtonPressed()
    {
        if(!canCloseApp)
        {
            ShowBackButtonToast();
            canCloseApp = true;
            return true;
        }
        else
            return false;
    }
}

