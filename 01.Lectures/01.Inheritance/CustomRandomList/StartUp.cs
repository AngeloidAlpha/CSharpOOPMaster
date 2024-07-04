using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList randomList = new();

            randomList.Add("Slavi");
            randomList.Add("Kriss");
            randomList.Add("Drago");

            Console.WriteLine("Removed Item:");
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine();

            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
