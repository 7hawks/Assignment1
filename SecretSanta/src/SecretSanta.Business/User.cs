using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSanta.Business
{
    class User
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Gift> Gifts { get; set;}
    }
}
