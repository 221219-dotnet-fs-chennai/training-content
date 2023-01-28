using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class AsynchProgramming
    {
        internal static void Method1()
        {
            Console.WriteLine("-Method 1-----");
        }
        internal static void Method2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("----Method 2-----");
            
        }
        internal static async void LongMethod()
        {
            await Task.Run(()=>Method2());
            Console.WriteLine("--- Long Method -----");
        }
    }
}
