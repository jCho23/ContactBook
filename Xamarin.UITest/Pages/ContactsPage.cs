using System;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin.UITest.Pages
{
    public class ContactsPage : BasePage
    {
		readonly Query _AddButton;

        readonly Query _AddButtonUsingID;

        public ContactsPage(IApp app, Platform platform) : base(app, platform)
        { 
        
        }
    }
}
