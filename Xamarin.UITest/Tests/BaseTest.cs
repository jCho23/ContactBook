using System;
using NUnit.Framework;

namespace Xamarin.UITest.Tests

{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]

	public abstract class BaseTest
	{
		protected IApp App;
		protected Platform Platform;

        protected ContactsPage ContactsPage;
        protected ContactDetailPage ContactDetailPage;
	

		protected BaseTest(Platform platform) => Platform = platform;

		[SetUp]
		virtual public void BeforeEachTest()
		{
			App = AppInitializer.StartApp(Platform);
			App.Screenshot("App Launched");
           
            ContactsPage = new ContactsPage(App, Platform);
            ContactDetailPage = new ContactDetailPage(App, Platform);
		
			//LoginPage.WaitForLoginScreen();
		}
	}
}

