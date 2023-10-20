using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_7
{
    public class ClassWithArray
    {
        private int[] array;

        public ClassWithArray(int[] arr)
        {
            array = arr;
        }

        public static bool operator < (ClassWithArray a, ClassWithArray b)
        {
            return a.array.Sum() < b.array.Sum();
        }

        public static bool operator > (ClassWithArray a, ClassWithArray b)
        {
            return a.array.Sum() > b.array.Sum();
        }
    }
}
