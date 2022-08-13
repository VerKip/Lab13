using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
   sealed class MultiBuilding:Building
    {
        int floors;

        int Floors
        {
            get { return floors; }
            set { if (value < 1) floors = 1; else floors = value; }
        }

        public MultiBuilding (string address, double length, double width, double height, int floors)
            :base (address, length, width, height)
        {
            this.Floors = floors;   
        }

        public string Print()
        {
           string result = base.Print();
            result += $" {floors}";
            return result;
        }
    }
}
