using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint5.Task6.V12.Lib;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint5.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            
            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";
            DataService ds = new DataService();
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
