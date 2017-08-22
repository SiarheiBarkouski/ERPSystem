using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem.Infrastructure
{
    static class Randomer
    {
        private static Random random;

        static Randomer()
        {
            random = new Random();
        }

        public static int Next()
        {
            return random.Next();
        }

        public static int Next100()
        {
            return random.Next(1, 100);
        }

        public static int Next(int a, int b)
        {
            return random.Next(a, b);
        }
        

    }
}
