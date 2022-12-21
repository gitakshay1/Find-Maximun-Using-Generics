
namespace FindMax_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Max = FindMax.FindIntMax(2, 1, 3);
            Console.WriteLine(Max);
            float Maxfloat = FindMax.FindFloatMax(1.2f, 1.1f, 1.3f);
            Console.WriteLine(Maxfloat);
            string MaxString = FindMax.FindStringMax("Apple", "Peach", "Banana");
            Console.WriteLine(MaxString);
        }
    }
    
}
