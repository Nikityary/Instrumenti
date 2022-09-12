using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenti
{
    internal class Truba : Instrument
    {
        private double diameter = 11;

        public void setDiameter(double diameter) 
        { 
            this.diameter = diameter; 
        }

        public double getDiameter() 
        { 
            return diameter; 
        }

        public void play() 
        { 
            Console.WriteLine("Труба играет. " + toString()); 
        }

        public String toString() 
        { 
            return "Диаметр трубы: " + diameter + " мм"; 
        }
    }
}
