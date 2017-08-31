using System;
using System.Collections.Generic;

using ContactBook.Models;
using Xamarin.Forms;
using SQLite;
using ContactBook.DataBase;

namespace ContactBook.Views
{
    public partial class ContactDetailPage : ContentPage
    {
        public event EventHandler<Contact> ContactAdded;
        public event EventHandler<Contact> ContactUpdated;

        private SQLiteAsyncConnection _connection;

        public ContactDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            BindingContext = new Contact
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked

            };
        }
    }
}
