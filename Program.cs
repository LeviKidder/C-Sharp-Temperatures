using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureData
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] testArr = new double[] {4.6, 1.6, 89, 57, 45.7, 109.5, 45.2, 18, 89.6};
            FileReader fileName = new FileReader();

            var testArr = fileName.UserArray("temps.txt");

            


            TemperatureInfo tempSet = new TemperatureInfo(testArr);
 
            Console.WriteLine(tempSet.AvgTemp());
            Console.WriteLine(tempSet.MaxTemp());
            Console.WriteLine(tempSet.MinTemp());
            foreach (bool Temp in tempSet.InTempRange(30,90)) {
                Console.WriteLine(Temp);

            }
            Console.ReadLine();
        }
    }
}
