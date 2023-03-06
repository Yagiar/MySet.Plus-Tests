using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MySet<int> Set1 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Assert.AreEqual("1,2,3", Set1.ToString());
        }
        [TestMethod]
        public void TestMethod2()
        {
            MySet<int> Set1 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set1.Remove(2);
            Assert.AreEqual("1,3", Set1.ToString());
        }
        [TestMethod]
        public void TestMethod3()
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set1.Remove(2);
            Set2.Add(4);
            Set2.Add(5);
            Assert.AreEqual("1,3,4,5", (Set1.Objedinenie(Set2)).ToString());
        }
        [TestMethod]
        public void TestMethod4()
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set2.Add(2);
            Set2.Add(3);
            Set2.Add(4);
            Assert.AreEqual("2,3", (Set1.Peresechenie(Set2)).ToString());
        }
        [TestMethod]
        public void TestMethod5()
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set2.Add(2);
            Set2.Add(3);
            Set2.Add(4);
            Assert.AreEqual("1", (Set1.Raznost(Set2)).ToString());
        }
        [TestMethod]
        public void TestMethod6()
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set2.Add(2);
            Set2.Add(3);
            Set2.Add(4);
            Assert.AreEqual("1,4", (Set1.SimRaznost(Set2)).ToString());
        }
        [TestMethod]
        public void TestMethod7()
        {
            MySet<int> Set1 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Assert.AreEqual(true, Set1.InSet(2));
        }

        [TestMethod]
        public void TestMethod8()
        {
            MySet<int> Set1 = new MySet<int>();
            MySet<int> Set2 = new MySet<int>();
            Set1.Add(1);
            Set1.Add(2);
            Set1.Add(3);
            Set2.Add(2);
            Set2.Add(3);
            Assert.AreEqual(true, Set1.InSet(Set2));
        }
    }
}
