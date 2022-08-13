using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Санкт-Петербург", 31, 10.5, 6);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Москва", 14, 10, 6, 3);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
