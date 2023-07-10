using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OOP_Classes
{
    internal class Customer
    {
        public string TcNumber;
        public string name;
        public string surname;
        public int gender;

        // constructor method 
        public Customer()
        {
            TcNumber = "4578456";
        }

        public Customer(string tcNumber, string name, string surname, int gender)
        {
            TcNumber = tcNumber;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
        }

        internal bool CustomerControl()
        {
            bool control = CustomerControlDb(TcNumber);
            return control;
        }

        private bool CustomerControlDb(string TcNumber)
        { 
            // we have gone to the db and checked tcnumber. It was our scenario
            return true;
        }


       
    }
}
