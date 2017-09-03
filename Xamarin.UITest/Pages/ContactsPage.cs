using System;
using System.Linq;

using Xamarin.UITest;
using Xamarin.UITest.Queries;

using ContactBook.Shared.Constants;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin.UITest.Pages
{
    public class ContactsPage : BasePage
    {
		readonly Query _addButton;

        readonly Query _addButtonUsingID;

        public ContactsPage(IApp app, Platform platform) : base(app, platform)
        {
            _addButtonUsingID = x => x.Marked(AutomationIdConstants.AddButton);
        }
    }

    public void TappedAddButton()
    {
        App.Tap(_addButtonUsingID);

    }
}
