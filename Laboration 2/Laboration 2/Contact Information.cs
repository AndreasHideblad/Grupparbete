using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    class ContactInfo
    {
        private string _firstName;
        private string _surName;
        private string _address;
        private string _phoneHome;
        private string _phoneMob;

        public ContactInfo()
        {

        }
        public ContactInfo(string firstName, string surName, string address, string phoneHome, string phoneMob)
        {
            _firstName = firstName;
            _surName = surName;
            _address = address;
            _phoneHome = phoneHome;
            _phoneMob = phoneMob;
        }
        //public string FirstName { get; set; }
        //public string SurName { get; set; }
        //public string Address { get; set; }
        //public string PhoneHome { get; set; }
        //public string PhoneMob { get; set; }

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string SurName { get { return _surName; } set { _surName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string PhoneHome { get { return _phoneHome; } set { _phoneHome = value; } }
        public string PhoneMob { get { return _phoneMob; } set { _phoneMob = value; } }

        public void Contacts()
        {
            //{
            //    Console.WriteLine("First Name:" + person.FirstName);
            //    Console.WriteLine("Last Name:" + person.SurName);
            //    Console.WriteLine("Phone Number:" + person.Address);
            //    Console.WriteLine("Home Number:" + person.PhoneHome);
            //    Console.WriteLine("Address:" + person.PhoneMob);
            //    Console.WriteLine("-----------------------------------------");
            //}            
            Console.Write($"Name: {_surName}, {_firstName} \nAddress: {_address} \nHome number: {_phoneHome} \nPhone Number: {_phoneMob}\n\n");
        }
        public void SearchFunc()
        {
            //string findFirstName = Console.ReadLine();
            //if (findFirstName==_firstName)
            //{
            //    Console.wr
            //}
            //Console.WriteLine(searchFirstName);
        }
    }
}
