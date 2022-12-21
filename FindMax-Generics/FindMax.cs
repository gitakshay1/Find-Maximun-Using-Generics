using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax_Generics
{
    public class FindMax
    {
        public static int FindIntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return 0;
        }
        public static float FindFloatMax(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            return 0;
        }
        public static string FindStringMax(string num1, string num2, string num3)
        {
            if (string.Compare(num1,num2) > 0 && string.Compare(num1,num3) > 0)
            {
                return num1;
            }
            if (string.Compare(num2, num1) > 0 && string.Compare(num2, num3) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }

        }
    }
}
