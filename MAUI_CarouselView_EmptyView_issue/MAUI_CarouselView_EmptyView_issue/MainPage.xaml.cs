namespace MAUI_CarouselView_EmptyView_issue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
		Task.Run(async () =>
		{
			await Task.Delay(2000);
			MainThread.BeginInvokeOnMainThread(() => Carousel.ItemsSource = new List<string>()
			{
				"There was ",
				"no ",
				"red EmptyView"
			});
		});

        base.OnAppearing();
    }
}


