using System;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin.UITest.Pages
{
    public class ContactsPage : BasePage
    {
		readonly Query _goButton;
		readonly Query _textEntry;
		readonly Query _textLabel;

		readonly Query _goButtonUsingID;
		readonly Query _textEntryUsingID;


        public ContactsPage(IApp app, Platform platform) : base(app, platform)
        { 
        
        }
    }
}
