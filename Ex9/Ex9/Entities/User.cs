using System;
using System.Collections.Generic;

namespace Ex9.Entities
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<Identification> Identification { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int PhoneCountryCode { get; set; }
        public string Details { get; set; }
    }
}
