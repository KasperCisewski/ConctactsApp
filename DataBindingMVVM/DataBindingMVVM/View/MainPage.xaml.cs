using DataBindingMVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBindingMVVM
{
	public partial class MainPage : ContentPage
	{
        ViewModel.MainPageViewModel vm;
        public MainPage()
        {
            vm = new ViewModel.MainPageViewModel();
            BindingContext = vm;
            InitializeComponent();

        }

      
        public void OnItemTapped(object o, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            if (e != null)
            {
                DisplayAlert("Aha", String.Format("You selected {0} {1}", contact.FirstName, contact.LastName), "OK");
            }
        }
    }
}
