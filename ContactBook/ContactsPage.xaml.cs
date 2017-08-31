using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using System.Threading.Tasks;

namespace ContactBook
{
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        private SQLiteAsyncConnection _connection;
        private bool _isDataLoaded;

        public ContactsPage()
        {
            InitializeComponent();

            _connection = DependencyService.Get < ISQLiteDb().GetConnection();
        }

        protected override async void OnAppearing()
        {
            if
                (_isDataLoaded)
                return;
            
            _isDataLoaded = true;
            await LoadData();

            base.OnAppearing();
        }

        private async Task LoadData()
        {
            await _connection.CreateTableAsync<Contact>();

            var contacts = await _connection.Table<Contact>().ToListAsync();

            _contacts = new ObservableCollection<Contact>(contacts);
            contactsListView.ItemsSource = _contacts;
        }

        async void OnAddContact(object sender, System.EventArgs e)
        {
            var page = new ContactDetailPage(new Contact());

            page.ContactAdded += (source, contact) =>
            {
                _contacts.Add(contact);
            };
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnDeleteContact(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
