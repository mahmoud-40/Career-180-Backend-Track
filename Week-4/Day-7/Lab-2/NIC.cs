using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class NIC
    {
        private static NIC instance;
        private string manufacture;
        private string macAddress;
        private string type;

        private NIC(){}

        public static NIC Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NIC();
                }

                return instance;
            }
        }

        public string Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; }
        }

        public string MacAddress
        {
            get { return macAddress; }
            set { macAddress = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return $"Manufacture: {manufacture}, MAC Address: {macAddress}, Type: {type}";
        }
    }
}
