
using System.Timers;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace BounceDefender;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		var currentBounds = AbsoluteLayout.GetLayoutBounds(movingBox);
		
		//AbsoluteLayout.SetLayoutBounds(movingBox, new Rect(currentBounds.X, currentBounds.Y, currentBounds.Width, currentBounds.Height));

		for (int i = 0;i < 30; i++) {
			AbsoluteLayout.SetLayoutBounds(movingBox, new Rect(currentBounds.X, currentBounds.Y - i, currentBounds.Width, currentBounds.Height));
		}
	}
}

