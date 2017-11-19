using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCleaningFunction
{
    static class Utils
    {
        public static float toAbs(this float f)
        {
            return Math.Abs(f);
        }

        public static float qu(this float f)
        {
            return (float) Math.Pow(f, 2);
        }
    }
}
