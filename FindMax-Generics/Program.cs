
namespace FindMax_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Max = FindMax.FindMaxNum<int>(2, 1, 3);
            Console.WriteLine(Max);
            float Maxfloat = FindMax.FindMaxNum<float>(1.2f, 1.1f, 1.3f);
            Console.WriteLine(Maxfloat);
            string MaxString = FindMax.FindMaxNum<string>("Apple", "Peach", "Banana");
            Console.WriteLine(MaxString);
        }
    }
    
}
