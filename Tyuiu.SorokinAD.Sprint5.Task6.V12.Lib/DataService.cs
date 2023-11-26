﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint5.Task6.V12.Lib
{
    public class DataService : ISprint5Task6V12
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 1; i++) 
                    {
                        if (line[i] == 'н' && line[i+1] == 'н')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
