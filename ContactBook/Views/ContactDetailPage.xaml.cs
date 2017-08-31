using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SQLite;

namespace ContactBook.Views
{
    public partial class ContactDetailPage : ContentPage
    {
		public event EventHandler<Contact> ContactAdded;
        public event EventHandler<Contact> ContactUpdated;

        private SQLiteAsyncConnection _connection;

		public ContactDetailPage(Contact contact)
        {


            InitializeComponent();
        }
    }
}
