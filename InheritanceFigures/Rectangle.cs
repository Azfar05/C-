using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFigures
{
    internal class Rectangle
    {
        //attributen
        private int length;
        private int width;

        //constructor
        public Rectangle(int lengte, int breedte) 
        { 
            this.length = lengte;   
            this.width = breedte;
        }
        //method
        public string draw() 
        {
            Console.WriteLine("Een rechthoek wordt getekend");
            return "Een Rechthoek is getekend";
        }
    }
}
