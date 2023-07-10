using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08OOP_Encapsulation
{
    internal class Customer
    {
        // class --> field
        public int id;
        public string name;
        public string surName;
        private string email;

        // class --> property

        public string Email
        {
           
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
    }
}
