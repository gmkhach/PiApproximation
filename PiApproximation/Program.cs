using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiApproximation
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = Utilities.getLength();
            runSimulation(len);
            Utilities.runPresets();
        }

        public static void runSimulation(int len)
        {
            Coordinates[] array = Utilities.generateCoordinates(len);
            int counter = Utilities.getCounter(array);
            double ratio = Utilities.getRatio(counter, len);
            Utilities.printResults(counter, ratio);
        }
    }
}
