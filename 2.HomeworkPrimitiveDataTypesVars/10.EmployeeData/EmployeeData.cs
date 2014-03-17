using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
//            Problem 10.	Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

    string FirstName = "Kondio";
    string LastName = "DaiRakiq.com";
    sbyte Age  = 112;
    char  Gender  = 'm';
	string PersonalIDNumber ="8306112507"  ;
    string UniqueEmployeeNumber = "(27560000436436546467575676585685686527569999";
    Console.WriteLine("I'm {0} {1}, yearsold- {2}, Gender - {3}, \n\r personal number:{4} \n\r MyEmployeeNumber:{5}",FirstName,LastName,Age,Gender,PersonalIDNumber,UniqueEmployeeNumber);



        }
    }
}
