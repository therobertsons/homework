using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Collections;

namespace CSharpLib
{
    public class CSharpImpl
    {
        public static string ReverseIterative(string s)
        {
            Array cArray = s.ToCharArray();
            Array.Reverse(cArray);
            string reversedString = string.Empty; 
            foreach (char c in cArray)
            {
                reversedString += c; 
            }
            return reversedString;
        }

        public static string ReverseRecursive(string s, int l)
        {
            if (l == 1)
                return s;
            else
                return ReverseRecursive(s.Substring(l - (s.Length - 1), s.Length - 1), l - 1) + s[0].ToString();

        }

        public static ArrayList CreateTestArray(int arraylen)
        {
            ArrayList testdata = new ArrayList(arraylen);
            Random r = new Random(12346);
            r.Next(0, 100);
            for (int i = 0; i < arraylen; i++)
            {
                r.Next(0, 100);
                testdata.Add(r.Next(0, 100));
                r.Next(0, 100);
            }
            testdata.Sort();
            return testdata;
        }

        public static int LibBinarySearch(ArrayList a, int value)
        {
            return a.BinarySearch(value);
        }

        public static int CustomBinarySearch(ArrayList a, int value, int min, int max)
        {
            if (max <= min)
            {
                throw new SystemException("the value is not in the given array");
            }
            int mid = (min + max)/2;

            if ((int)a[mid] > value)
                return CustomBinarySearch(a, value, min, mid - 1);
            else if ((int)a[mid] < value)
                return CustomBinarySearch(a, value, mid + 1, max);
            else
                return mid;

        }
    }

}
