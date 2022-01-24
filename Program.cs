using System;
using System.Text.Json;

namespace RTSLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var rts = new RTSLabs();
            int[] numbers = { 1, 5, 2, 1, 10 };
            var aboveBelowResult = rts.aboveBelow(numbers,6);

            var result = JsonSerializer.Serialize(aboveBelowResult);
            Console.WriteLine(result);

            result = rts.stringRotation("MyString", 2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
