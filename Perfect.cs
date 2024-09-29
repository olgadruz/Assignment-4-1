using System.Runtime.CompilerServices;

namespace Perfect;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int g = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < g; i++)
        {
            if (g % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == g)
        {
            Console.WriteLine("Perfect Number");
        }
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }
    }
}
