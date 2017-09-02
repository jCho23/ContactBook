using System;
namespace Xamarin.UITest.Pages
{
	public abstract class BasePage
	{
		protected readonly IApp App;
		protected readonly bool OnAndroid;
		protected readonly bool OniOS;

		protected BasePage(IApp app, Platform platform)
		{
			App = app;

			OnAndroid = platform == Platform.Android;
			OniOS = platform == Platform.iOS;
		}
	}
}
