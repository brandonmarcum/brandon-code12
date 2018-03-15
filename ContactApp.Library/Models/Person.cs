using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Library.Enums;

namespace ContactApp.Library.Models
{
    public class Person
    {
        public Name Name {get; set;}
        public Phone Phone { get; set; }
        public Dictionary<ContactEnum, string> Email { get; set; }
        public Dictionary<ContactEnum, Address> Address { get; set; }
        
    }
}
