namespace AbsoluteLayoutDemo;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
		StartUpdatingControl();
	}

	private async void StartUpdatingControl()
	{
		int x = 10, y = 10, w = 25, h = 25;
		AbsoluteLayout.SetLayoutBounds(bvControl, new Rect(x, y, w, h));


		while (true)
		{
			x += 10;
			AbsoluteLayout.SetLayoutBounds(bvControl,new Rect(x, y, w, h));
			await Task.Delay(1000); //Hace que espere un segundo
		}

			
	}
}