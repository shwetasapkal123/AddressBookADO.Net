﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADONet
{
    public class AddressBookModel
    {
        public int Id { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }

    }
}
