using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;

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





        void Handle_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
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
