using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string fName = "Amanda";
            string lName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long ID = 8306112507;
            int EmployeNumber = 27563571;

            Console.WriteLine("First name: {0} \nLast name: {1} \nAge: {2} \nGender: {3} \nPersonal ID: {4} \nUnique Employee Number: {5}", fName, lName, age, gender, ID, EmployeNumber);
        }
    }
}
