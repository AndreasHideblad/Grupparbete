using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Laboration_2
{
    class Program
    {
        public static List<ContactInfo> People = new List<ContactInfo>();

        static void Main()
        {
            //ContactInfo contactInfo = new ContactInfo();
            //var contactList = new List<ContactInfo>();
            People.Add(new ContactInfo("Lars", "Carlstedt", "hemma hos sig", "000-00 000", "000-00 00 000"));
            People.Add(new ContactInfo("Oskar", "Vennerlund", "någonstans", "000-00 00 000", "000-00 00 000"));
            People.Add(new ContactInfo("Karin", "Mäki-kala", "på discord", "000-00 00 000", "000-00 00 000"));
            People.Add(new ContactInfo("Simon", "Karvonen", "i ett grupprum", "000-00 00 000", "000-00 00 000"));
            People.Add(new ContactInfo("Andreas", "Hideblad", "Lillebovägen 13", "000-00 00 000", "000-00 00 000"));
            People.Add(new ContactInfo("Emil", "Sevon", "Hemma", "000-00 00 000", "073-24 99 538"));

            Console.WriteLine("Welcome to your phonebook.");
            Console.WriteLine("Choose an option from the list:");
            Console.WriteLine("add\nremove\nlist\nsearch\nchange\nexit\n");

            string firstName;
            string surName;
            string address;
            string homeNumber;
            string phoneNumber;
            
            while (true)
            {
                var choice = Console.ReadLine();
                choice.ToLower();
                if (choice == "add")
                {
                    Console.Write("Please enter your first name: ");
                    firstName = Console.ReadLine();
                    Console.Write("Please enter your surname: ");
                    surName = Console.ReadLine();
                    Console.Write("Please enter your address: ");
                    address = Console.ReadLine();
                    Console.Write("Please enter your home number: ");
                    homeNumber = Console.ReadLine();
                    Console.Write("Please enter your mobile number: ");
                    phoneNumber = Console.ReadLine();
                    People.Add(new ContactInfo(firstName, surName, address, homeNumber, phoneNumber));
                    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    continue;
                }
                else if (choice == "remove")
                {

                    //RemoveSearch();
                    int i = 1;
                    foreach(var index in People)
                    {
                        Console.WriteLine(i++);
                        index.Contacts();
                    }
                    Console.Write("Enter the number of the person you want to remove: ");
                    
                    People.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);

                    //if (Console.ReadLine() == )
                    //{
                    //    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    //    continue;
                    //}
                    //Console.WriteLine("\nInvalid input.");
                    
                }
                else if (choice == "list")
                {
                    int i = 1;
                    foreach (var index in People)
                    {
                        Console.WriteLine(i++);
                        index.Contacts();
                    }
                    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    continue;
                }
                else if (choice == "search")
                {
                    Console.WriteLine("What do you want to change? \n1. First name\n2. LastName\n3. Address\n4. Phone home\n5. Phone mobile");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        SearchFirstName();
                    }
                    else if (choice == "2")
                    {
                        SearchSurName();
                    }
                    else if (choice == "3")
                    {
                        SearchAddress();
                    }
                    else if (choice == "4")
                    {
                        SearchPhoneHome();
                    }
                    else if (choice == "5")
                    {
                        SearchPhoneMob();
                    }


                    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    continue;
                }
                else if (choice == "change")
                {
                    Console.WriteLine("\nWhich contact would you like to change?\n");
                    foreach (var item in People)
                    {
                        item.Contacts();
                    }
                    //int user_Index = Convert.ToInt32(Console.ReadLine());
                    //contactList.ElementAt(user_Index - 1);

                    Console.WriteLine("What do you want to change? \n'first name', 'surname', 'address', 'home number', 'mobile number' or 'exit' to save changes");
                    var choice2 = Console.ReadLine();
                    choice2.ToLower();
                    if (choice2 == "first name" || choice2 == "firstname")
                    {
                        var newFirstName = Console.ReadLine();
                        //ContactInfo. = newFirstName;
                    }
                    else if (choice2 == "surname")
                    {
                        var newSurName = Console.ReadLine();
                        //ContactInfo. = newSurName;
                    }
                    else if (choice2 == "address")
                    {
                        var newAddress = Console.ReadLine();
                        //ContactInfo. = newAddress;
                    }
                    else if (choice2 == "home number" || choice2 == "homenumber")
                    {
                        var newHomeNumber = Console.ReadLine();
                        //ContactInfo. = newHomeNumber;
                    }
                    else if (choice2 == "mobile number" || choice2 == "mobilenumber")
                    {
                        var newPhoneNumber = Console.ReadLine();
                        //ContactInfo.= newPhoneNumber;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option: choose an item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    }
                    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                }
                else if (choice == "exit")
                {
                    Console.WriteLine("\nChoose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid option, choose a new item in the list: \nadd\nremove\nlist\nsearch\nchange\nexit\n");
                    continue;
                }
            }
        }


        private static void RemovePerson()
        {
            List<ContactInfo> people = FirstNameSearch();

            if (people.Count == 0)
            {
                Console.WriteLine("Could not be found.");
                return;
            }
            if (people.Count == 1)
            {
                RemovePersonFromList();
                return;
            }
            Console.WriteLine("Choose the number of the person to remove.");
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write(i);
                foreach(var index in people)
                {
                    index.Contacts();
                }
            }
            int removePersonNumber = Convert.ToInt32(Console.ReadLine());
            if (removePersonNumber > people.Count -1 || removePersonNumber < 0)
            {
                Console.WriteLine("Invalid.");
                return;
            }
            foreach(var index in people)
            {
                index.Contacts();
            }
        }

        private static void RemovePersonFromList()
        {
            Console.WriteLine("Do you want to remove this person? Y/N");
            foreach (var index in People)
            {
                index.Contacts();
            }
            string choiceRemove = "";
            if (choiceRemove == "Y" || choiceRemove == "y")
            {
                foreach (var index in People)
                {
                    //index.Remove();
                }
            }
        }

        //private static void RemoveSearch()
        //{
        //    List<ContactInfo> people = FirstNameSearch();
        //    if (people.Count == 0)
        //    {
        //        Console.WriteLine("False");
        //        return;
        //    }
        //    //Console.WriteLine("Person Removed");
        //    //People.RemoveAt(Console.ReadLine());
        //}

        private static void SearchFirstName()
        {
            List<ContactInfo> people = FirstNameSearch();
            if(people.Count == 0)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine("True");
            foreach(var index in people)
            {
                index.Contacts();
            }
        }
        private static void SearchSurName()
        {
            List<ContactInfo> people = SurNameSearch();
            if (people.Count == 0)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine("True");
            foreach (var index in people)
            {
                index.Contacts();
            }
        }
        private static void SearchAddress()
        {
            List<ContactInfo> people = AdressSearch();
            if (people.Count == 0)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine("True");
            foreach (var index in people)
            {
                index.Contacts();
            }
        }
        private static void SearchPhoneHome()
        {
            List<ContactInfo> people = PhoneHomeSearch();
            if (people.Count == 0)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine("True");
            foreach (var index in people)
            {
                index.Contacts();
            }
        }
        private static void SearchPhoneMob()
        {
            List<ContactInfo> people = PhoneMobSearch();
            if (people.Count == 0)
            {
                Console.WriteLine("False");
                return;
            }
            Console.WriteLine("True");
            foreach (var index in people)
            {
                index.Contacts();
            }
        }

        private static List<ContactInfo> FirstNameSearch()
        {
            Console.WriteLine("Who do you want to find?");
            string firstName = Console.ReadLine();
            return People.Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
        }

        private static List<ContactInfo> SurNameSearch()
        {
            Console.WriteLine("Who do you want to find?");
            string surName = Console.ReadLine();
            return People.Where(x => x.SurName.ToLower() == surName.ToLower()).ToList();
        }
        private static List<ContactInfo> AdressSearch()
        {
            Console.WriteLine("Who do you want to find?");
            string address = Console.ReadLine();
            return People.Where(x => x.Address.ToLower() == address.ToLower()).ToList();
        }
        private static List<ContactInfo> PhoneHomeSearch()
        {
            Console.WriteLine("Who do you want to find?");
            string phoneHome = Console.ReadLine();
            return People.Where(x => x.PhoneHome.ToLower() == phoneHome.ToLower()).ToList();
        }
        private static List<ContactInfo> PhoneMobSearch()
        {
            Console.WriteLine("Who do you want to find?");
            string phoneMob = Console.ReadLine();
            return People.Where(x => x.PhoneMob.ToLower() == phoneMob.ToLower()).ToList();
        }

    }
}
