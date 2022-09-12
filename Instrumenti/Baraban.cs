using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenti
{
    internal class Baraban : Instrument
    {
        private String size = "22 x 18";

        public void setSize(String size) 
        { 
            this.size = size; 
        }

        public String getSize() 
        { 
            return size; 
        }

        public void play() 
        { 
            Console.WriteLine("Барабан играет. " + toString()); 
        }

        public String toString() 
        { 
            return "Размер барабана: " + size; 
        }

    }
}
