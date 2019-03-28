using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
using System.Collections.Generic;
namespace HashTableTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void ElementsTest()
        {
            var t = new HashTable.HashTable(3);

            t.PutPair("no", 57);
            t.PutPair("yes", 666);
            t.PutPair("yeah", 89);

            Assert.AreEqual(t.GetValueByKey("no"), 57);
            Assert.AreEqual(t.GetValueByKey("yes"), 666);
            Assert.AreEqual(t.GetValueByKey("yeah"), 89);
        }

        [TestMethod]
        public void TwoEquialsElementsTest()
        {
            var h = new HashTable.HashTable(3);

            h.PutPair("mirage", 123);
            h.PutPair("mirage", 321);

            Assert.AreEqual(h.GetValueByKey("mirage"), 321);
        }

        [TestMethod]
        public void ElementsTest2()
        {
            var h = new HashTable.HashTable(10000);

            for (int i = 1; i < 10000; i++)
            {
                h.PutPair(i, i + 1);
            }

            Assert.AreEqual(h.GetValueByKey(88), 89);
        }

        [TestMethod]
        public void ElementsSearchTests()
        {
            var h = new HashTable.HashTable(10000);

            for (int i = 1; i < 10000; i++)
            {
                h.PutPair(i, i + 1);
            }

            string [] s= new string [1000];
            for (int i = 1; i < 1000; i++)
            {
                s[i] = Convert.ToString(i);
            }
            foreach (string e in s)
            {
                Assert.AreEqual(h.GetValueByKey(e), null);
            }
        }
    }
}