using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenti
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Instrument[] i = new Instrument[3];
            i[0] = new Gitara();
            i[1] = new Baraban();
            i[2] = new Truba();

            foreach (Instrument instrument in i)
            {
                instrument.play();
            }
            Console.ReadKey();
        }
    }
}
