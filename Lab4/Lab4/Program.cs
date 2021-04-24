using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Elvis kibet
//Lab4
namespace Lab4
{
    class Program
    {
        public static void Pause()//pause function
        {
            Console.WriteLine("\n\nPress Any key to continue");
            Console.ReadKey();
        }
        public class Person//class(add the variables to class of public) as private
        {
            private string firstName;
            private string middleName;
            private string lastName;
            private string street1;
            private string street2;
            private string city;
            private string state;
            private string zip;
            private string phone;
            private string email;

            public string FirstName {//creating public variable based on the private variables  
                get
                {
                    return firstName;//return value of the private variables 
                }
                set
                {
                    firstName = value;//asssigning value of the public string to the private
                }
            }
            public string MiddleName
            {
                get
                {
                    return middleName;
                }
                set
                {
                    middleName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            public string Street1
            {
                get
                {
                    return street1;
                }
                set
                {
                    street1 = value;
                }
            }
            public string Street2
            {
                get
                {
                    return street2;
                }
                set
                {
                    street2 = value;
                }
            }
            public string Zip
            {
                get
                {
                    return zip;
                }
                set
                {
                    zip = value;
                }
            }
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
                }
            }
            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    state= value;
                }
            }
            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    phone = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }

        }
        static void Main(string[] args)
        {
            Person temp = new Person();
            //User data inputs 
            Console.Write("Enter First name:");
            temp.FirstName = Console.ReadLine();

            Console.Write("Enter middle name:");
            temp.MiddleName = Console.ReadLine();

            Console.Write("Enter Last name:");
            temp.LastName = Console.ReadLine();

            Console.Write("Enter street 1:");
            temp.Street1 = Console.ReadLine();

            Console.Write("Enter street 2:");
            temp.Street2 = Console.ReadLine();

            Console.Write("Enter City:");
            temp.City = Console.ReadLine();

            Console.Write("Enter State:");
            temp.State = Console.ReadLine();

            Console.Write("Enter Phone:");
            temp.Phone = Console.ReadLine();

            Console.Write("Enter Email:");
            temp.Email = Console.ReadLine();

            Console.Clear();

            Console.Write("\n\n\t\tUser's data!!!\n");
            //print the users info
            Console.Write($"\nFullName: {temp.FirstName} {temp.MiddleName} {temp.LastName}");
            Console.Write($"\nAddress: {temp.Street1}{temp.Street2} \t{temp.City},{temp.State}");
            Console.Write($"\nPhone: +(1){temp.Phone}");
            Console.Write($"\nEmail: {temp.Email}");

            Pause();
        }
    }
}
