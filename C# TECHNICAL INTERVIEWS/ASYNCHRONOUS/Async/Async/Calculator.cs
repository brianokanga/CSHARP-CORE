using System;
using System.Threading.Tasks;

namespace Async
{
    public class Calculator
    {
        public Calculator()
        {
            
        }
        public async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }

        public void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
    }
}