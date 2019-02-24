using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemperatureData
{
    class FileReader
    {
        //CREATES METHOD THAT RETURNS A LIST OF DOUBLES
        public List<double> UserArray(String fileName)
        {
            //CREATES NEW LIST OF DOUBLES VARIABLE 
            List<Double> userArray = new List<double>();
            //CREATES FILE CONTENT VARIABLE THAT IS ALL TEXT IN fileName
            var fileContent = File.ReadAllText(fileName);
            //SPLITS THE DATA AT ALL SPACES
            var array = fileContent.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            //PARSES SPLIT DATA INTO DOUBLES AND ADDS IT TO userArray 
            userArray = array.Select(arg => double.Parse(arg)).ToList();
            
            return userArray;
        }







    }
}
