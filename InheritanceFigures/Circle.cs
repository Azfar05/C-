using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFigures
{
    internal class Circle
    {
        // attributen
        private int radius;

        // constructor
        public Circle(int straal)
        { 
            this.radius = straal;
        }

        // method
        public string draw()
        {
            Console.WriteLine("De cirkel wordt getekend");
            return "De Cirkel is getekend";
        }

    }
}
