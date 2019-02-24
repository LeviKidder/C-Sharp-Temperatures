using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureData
{   //creating temperatureinfo class
    class TemperatureInfo
    {
        public double[] tempArray;

        //creating a class constructor
        public TemperatureInfo(double[] tempArray)
        {
            this.tempArray = tempArray;
        }

        //AVG TEMP METHOD
        public double AvgTemp()
        {
            double avgTemp, totalTemp = 0.0, tempCount = 0.0;

            foreach (double Temp in tempArray)
            {
                tempCount++;
                totalTemp += Temp;
            }
            avgTemp = totalTemp / tempCount;

            return avgTemp;
        }

        //MAX TEMP METHOD
        public double MaxTemp()
        {
            double maxTemp = 0;

            foreach (double Temp in tempArray)
            {
                if (Temp > maxTemp)
                {
                    maxTemp = Temp;
                }
            }
            return maxTemp;
        }
        //MIN TEMP METHOD
        public double MinTemp()
        {
            double minTemp = tempArray[0];
            foreach (double Temp in tempArray)
            {
                if (Temp < minTemp)
                {
                    minTemp = Temp;
                }
            }
            return minTemp;

        }
        //CHECK IF TEMP IN PROPER RANGE RETURNS ARRAY OF BOOLS
        public bool[] InTempRange(double minTemp,double maxTemp) {
            
           

            bool[] tempBoolArray = new bool[tempArray.Count()];
            int counter = 0;
            foreach (double Temp in tempArray) {
                if (Temp >= minTemp && Temp <= maxTemp)
                {
                    tempBoolArray[counter] = true;
                }
                
                counter++;
            }
            return tempBoolArray;
        }
    }

}
