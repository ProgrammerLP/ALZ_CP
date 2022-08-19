using System.Diagnostics;

namespace ALZ_CP;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void btn1_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new lotto());
	}

	private async void btn2_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Euro());
    }

	private async void ws_btn_Clicked(object sender, EventArgs e)
	{
		try
		{
			Uri uri = new Uri("https://programmerlp-net.vercel.app");
			await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception ex)
		{

			throw;
		}
	}

	private void quit_btn_Clicked(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}
}

