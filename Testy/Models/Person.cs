using System;
using System.Collections.Generic;
using System.Text;

namespace Testy.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public UserAddress Address { get; set; }
    }
}
