using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshrtOOP
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //this is the constructor
        public Customer(string firstName = "Insert first name", string lastName = "Insert last name") {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer();
            Console.WriteLine(string.Format("First Name : {0}\nLast Name : {1}", cust.FirstName, cust.LastName));
            Console.ReadLine();
        }
    }
}
