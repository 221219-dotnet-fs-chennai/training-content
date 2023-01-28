using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Algorithm<T>
    {
        internal static void Swap(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }
    }
}
