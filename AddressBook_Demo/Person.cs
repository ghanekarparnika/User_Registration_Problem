using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public string Phone { get; set; }
        
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return string.Equals(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }
    }
}
