using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Ü_Stunde_1
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber {  get; set; }

        public Contact(string pFirstName, string pLastName)
        {
            FirstName = pFirstName;
            LastName = pLastName;
        }
    }
}
