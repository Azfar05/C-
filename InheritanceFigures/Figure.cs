using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFigures
{
    internal class Figure
    {
        //attributen
        private string color;
        //constructor
        public Figure(string kleur) 
        {
            this.color = kleur;
        }


        //methods
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {  
            return this.color;
        }
       
        public void draw()
        {
            Console.WriteLine("het figuur wordt getekend");
            
        }

        

    }
}
