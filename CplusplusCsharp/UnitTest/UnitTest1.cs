using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReverseIterative()
        {
            string s = "The brown fox jumps around!";
            string s2 = CSharpLib.CSharpImpl.ReverseIterative(s);

            Assert.AreEqual(s2, "!dnuora spmuj xof nworb ehT");
            string s3 = CSharpLib.CSharpImpl.ReverseIterative(s2);
            Assert.AreEqual(s3, s);
        }

        [TestMethod]
        public void TestReverseRecursive()
        {
            string s = "The brown fox jumps around!";
            string s2 = CSharpLib.CSharpImpl.ReverseRecursive(s,s.Length);

            Assert.AreEqual(s2, "!dnuora spmuj xof nworb ehT");
            string s3 = CSharpLib.CSharpImpl.ReverseRecursive(s2,s2.Length);
            Assert.AreEqual(s3, s);
        }

        [TestMethod]
        public void TestCustomBinarySearch()
        {
            ArrayList a = new ArrayList();
            a.Add(1); a.Add(2); a.Add(3); a.Add(5); a.Add(4); a.Add(6); a.Add(7); a.Add(8);
            a.Sort();

            int i = CSharpLib.CSharpImpl.CustomBinarySearch(a, 2, 0, a.Count);
            Assert.AreEqual(i, 1);

            int z = 99;
            try
            {
                z = CSharpLib.CSharpImpl.CustomBinarySearch(a, 27, 0, a.Count);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(SystemException));
            }
            Assert.AreNotEqual(99, z);
        }
    }
}
