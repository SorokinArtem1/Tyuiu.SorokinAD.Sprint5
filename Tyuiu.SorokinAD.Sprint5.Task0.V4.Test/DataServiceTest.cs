using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint5.Task0.V4.Lib;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint5.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint5\Tyuiu.SorokinAD.Sprint5.Task0.V4\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait,fileExists);

        }
    }
}
