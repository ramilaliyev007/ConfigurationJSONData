using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurationJSONData
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
