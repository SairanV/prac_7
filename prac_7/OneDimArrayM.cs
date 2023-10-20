using System;

namespace prac_7
{
    internal class OneDimArrayM
    {
        private int[] array;

        public OneDimArrayM(int[] arr)
        {
            array = arr;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public static bool operator ==(OneDimArrayM a, OneDimArrayM b)
        {
            if (a.array.Length != b.array.Length)
                return false;

            for (int i = 0; i < a.array.Length; i++)
            {
                if (a.array[i] != b.array[i])
                    return false;
            }

            return true;
        }

        public static bool operator !=(OneDimArrayM a, OneDimArrayM b)
        {
            return !(a == b);
        }

        public static OneDimArrayM operator +(OneDimArrayM a, OneDimArrayM b)
        {
            if (a.array.Length != b.array.Length)
            {
                throw new InvalidOperationException("Arrays must have the same length for addition.");
            }

            int[] resultArray = new int[a.array.Length];
            for (int i = 0; i < a.array.Length; i++)
            {
                resultArray[i] = a.array[i] + b.array[i];
            }

            return new OneDimArrayM(resultArray);
        }
    }
}
