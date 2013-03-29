using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string to reverse");
            string input = Console.ReadLine();
            input = input.Trim();
            
            Console.WriteLine("Reversing String using C# Iteratively");
            Console.WriteLine(CSharpLib.CSharpImpl.ReverseIterative(input));

            Console.WriteLine("Reversing String using C# Recusivily");
            Console.WriteLine(CSharpLib.CSharpImpl.ReverseRecursive(input,input.Length));

            Console.WriteLine("Lets do some Binary Searches");
            Console.WriteLine("Creating random test data");
            ArrayList a = CSharpLib.CSharpImpl.CreateTestArray(60);
            Console.WriteLine("Test data contains:");
            foreach (var item in a)
            {
                Console.Write(item.ToString());
                Console.Write(";");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter search value");
            string valuetest = Console.ReadLine();
            int val = Int32.Parse(valuetest);
            int r1 = CSharpLib.CSharpImpl.LibBinarySearch(a, val);
            int r2 = -2;
            string exmsg = string.Empty;
            try
            {
                r2 = CSharpLib.CSharpImpl.CustomBinarySearch(a, val, 0, a.Count);
            }
            catch (Exception ex)
            {
                exmsg = ex.Message;
                
            }
            string msg = "Custom Search notes the index position as:" + r2.ToString();
            if (!string.IsNullOrEmpty(exmsg))
            {
                msg = exmsg;
            }
            Console.WriteLine("CLR libraries notes the index position as:" + r1.ToString());
            Console.WriteLine(msg);
            Console.WriteLine("Thanks!");
            Console.ReadLine();
        }
    }
}