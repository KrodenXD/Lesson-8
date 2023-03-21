using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Calc
    {
        public int Sum(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public int Abs(int a, int b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }

        public Calc()
        {

        }
        public Calc(int a, int b)
        {
            Sum(a, b);
            Abs(a, b);
        }
    }
}
