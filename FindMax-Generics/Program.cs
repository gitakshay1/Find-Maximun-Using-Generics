
namespace FindMax_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Max = FindMax.FindIntMax(2, 1, 3);
            Console.WriteLine(Max);
            float Maxfloat = FindMax.FindFloatMax(1.3f, 1.2f, 1.1f);
            Console.WriteLine(Maxfloat);
        }
    }
    
}
