using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    class Account
    {
        /*
         ----------------------------------------------------------------------
         Note 1;
        ---------
            private string name; // field
            
            public string Name // property
            {
                get { return name; }       // get method
                set { name = value; }     // set method
            }

            same as:

            public string Name { get; set;}

        Note 2;
        -------
            static field -> Like a pass by reference, imagine it as a global variable for all objects from the same class.

        Note 3;
        -------
            The importance of Interfaces -> We do need it in the design level. 
            The implemented methods in the interfaces must be implemented in all classes which will inherit that interface.

        Note 4;
        -------
        base -> In the parent
        this -> In the same class
        new -> we can use it instead if override, new code with the same name
        sealed -> cant inherit from it
        --------------------------------------------------------------------
        */

        public string Name { get; set; }
        public string Address { get; set; }

        private double _balance = 0;

        private static int _count = 0;

        public Account(string inName, string inAddress, double inBalance)
        {
            Name = inName;
            Address = inAddress;
            _balance = inBalance;
            _count++;
        }

        public Account(string iName, string inAddress) : this(iName, inAddress, 0) { }
        public Account(string iName) : this(iName, "Not Supplied", 0) { }

        public bool WithdrawFunds(double amount)
        {
            if (_balance < amount)
            {
                return false;
            }

            _balance -= amount;
            return true;
        }

        public void PayInFunds( double amount)
        {
            _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
