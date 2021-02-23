using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitMaker.Units;

namespace UnitConsole
{
    public static class Tester
    {
        public static void Main()
        {
            Console.WriteLine(2 * UnitFactory.GetBaseUnit(UnitType.Mass));
        }
    }
}
