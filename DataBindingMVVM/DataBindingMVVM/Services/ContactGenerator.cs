using DataBindingMVVM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingMVVM.Services
{
    public class ContactGenerator
    {
        private static List<string> FirstNames = new List<string>
        {
            "Adam","Liam","Jacob","Ryder","Jason", "Elliot","Xavier","Caleb"
        };
        private static List<string> LastNames = new List<string>
        {
            "Smith","Johnoson","Brown","Jenking","Jordan","Morales","Powell","Sullivan"
        };
        public static List<Contact> CreateContacts()
        {
            var random = new Random();
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < 7; i++)
            {
                string first = FirstNames[random.Next(FirstNames.Count - 1)];
                string last = LastNames[random.Next(LastNames.Count - 1)];
                first = InitCap(first);
                last = InitCap(last);
                Contact contact = new Contact();
                contact.FirstName = first;
                contact.LastName = last;
                contact.Email = first + "@gmail.com";
                contact.Favourite = (random.Next(0,1) == 0);
                contacts.Add(contact);
            }
            return contacts;
        }

        private static string InitCap(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = char.ToLower(array[i]);
            }
            if (array.Length >= 1)
            {
                array[0] = char.ToUpper(array[0]);
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }


    }
}
