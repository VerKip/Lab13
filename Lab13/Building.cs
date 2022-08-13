using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Building
    {
        string address;
        double length;
        double width;
        double height;

        double Length
        {
            get { return length; }
            set { if (value <= 0) length = 1; else length = value; }
        }

        double Width
        {
            get { return width; }
            set { if (value <= 0) width = 1; else width = value; }
        }

        double Height
        {
            get { return height; }
            set { if (value <= 0) height = 1; else height = value; }
        }

        public Building (string address, double length, double width, double height)
        {
            this.address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string Print()
        {
            return $"{address} {length} {width} {height}";
        }
    }
}
