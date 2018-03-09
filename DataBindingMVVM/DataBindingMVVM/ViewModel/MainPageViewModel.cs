using DataBindingMVVM.Model;
using DataBindingMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataBindingMVVM.ViewModel
{
    public class MainPageViewModel
    {
        public List<Contact> Contacts { get; set; }

        public MainPageViewModel()
        {

            Contacts = new List<Contact>();
            var listOfContacts = new List<Contact>();
            listOfContacts = Services.ContactGenerator.CreateContacts();
            Contacts = listOfContacts;
        }
          
    }
}
