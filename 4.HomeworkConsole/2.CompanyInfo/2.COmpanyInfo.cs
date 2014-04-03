using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompanyInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.*/
            Console.WriteLine("enter: companyName: ");
            string companyName = Console.ReadLine();
            Console.WriteLine("enter: companyAdress: ");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("enter: companyPhoneNumber: ");
            string companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("enter: fax: ");
            string fax = Console.ReadLine();
            Console.WriteLine("enter: website: ");
            string website = Console.ReadLine();
            Console.WriteLine("enter: cmanagerFirstName: ");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("enter: managerLastName: ");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("enter:managerAge: ");
            string managerAge = Console.ReadLine();
            Console.WriteLine("managerPhone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine("My company is {0}.Its located in {1}. To contact us call {2} or fax to : {3}. Our site is {4}.Our manager is {5} {6}. he is {7} years old. His phone is{8}",companyName,companyAdress,companyPhoneNumber,fax, website,managerFirstName,managerLastName,managerAge,managerPhone);


        }
    }
}
