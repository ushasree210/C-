using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayreversename
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the name");

    var name=Console.ReadLine();
            var namy = new char[name.Length];
            for (int i = 0; i<name.Length; i++)
                namy[name.Length-i-1] = name[i];
            var reversed = namy;
            Console.WriteLine(reversed); 
        }
    }
}
