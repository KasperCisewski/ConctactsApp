﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataBindingMVVM.Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Favourite { get; set; }
        public Contact()
        {

        }
    }
}
