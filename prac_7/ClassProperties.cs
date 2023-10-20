using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_7
{
    public class ClassProperties
    {
        public int Value { get; set; }

        public ClassProperties(int value)
        {
            Value = value;
        }

        public static bool operator == (ClassProperties a, ClassProperties b)
        {
            return a.Value == b.Value;
        }

        public static bool operator != (ClassProperties a, ClassProperties b)
        {
            return a.Value != b.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is ClassProperties other)
            {
                return this.Value == other.Value;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
