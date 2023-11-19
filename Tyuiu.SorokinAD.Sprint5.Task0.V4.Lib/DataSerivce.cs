using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint5.Task0.V4.Lib
{
    public class DataSerivce : ISprint5Task0V4
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = ((double)(2*Math.Pow(x,3)) + (double)(0.5*Math.Pow(x,2)) - (double)(x * 3.5) + (double)2);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
