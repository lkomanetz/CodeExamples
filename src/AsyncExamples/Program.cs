using System;
using System.Threading.Tasks;

namespace AsyncExamples {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Starting One Task that calls another...");
            Task.WaitAll(FirstMethodAsync());
            Console.WriteLine("Done with everything...");

            Console.WriteLine("Calling multiple tasks in parallel...");
            Task.WaitAll(SecondMethodAsync(), ThirdMethodAsync());
            Console.WriteLine("Done calling multiple tasks...");
        }

        static async Task FirstMethodAsync() {
            Console.WriteLine("Starting First Method...");
            await Task.Delay(500);
            await SecondMethodAsync();
            Console.WriteLine("Finished First Method...");
        }

        static async Task SecondMethodAsync() {
            Console.WriteLine("Starting Second Method...");
            await Task.Delay(500);
            Console.WriteLine("Finished Second Method...");
        }

        static async Task ThirdMethodAsync() {
            Console.WriteLine("Starting Third Method...");
            await Task.Delay(500);
            Console.WriteLine("Finished Third Method...");
        }

    }

}