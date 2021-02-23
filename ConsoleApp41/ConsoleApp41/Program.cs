using System;

namespace ConsoleApp41
{
    class Program
    {
        delegate float NumHandler(float num1, float num2, float num3);
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            NumHandler numHandler = delegate (float x, float y, float z)
            {
                return (x + y + z) / 3;
            };
            float d = numHandler(x, y, z);
            Console.WriteLine(d);
            Console.Read();
        }
        
    }
}
