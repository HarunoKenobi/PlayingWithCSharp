using System;
using System.Threading.Tasks;

namespace StringAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var output = await "I'm a async string";

            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
