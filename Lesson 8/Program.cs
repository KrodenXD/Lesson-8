using System;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.Sum(10, 6);
            Calc calc1 = new Calc(6, 10);
        }
    }
}
