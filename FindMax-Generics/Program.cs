using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax_Generics
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int Max = FindMax<int>.FindMaxNum(2, 1, 3);
            Console.WriteLine(Max);
            float Maxfloat = FindMax<float>.FindMaxNum(1.2f, 1.1f, 1.3f);
            Console.WriteLine(Maxfloat);
            string MaxString = FindMax<string>.FindMaxNum("Apple", "Peach", "Banana");
            Console.WriteLine(MaxString);
        }
    }
    
}
