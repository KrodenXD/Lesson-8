using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception)
            {
                Console.WriteLine("Can't Divide By Zero");
            }
            finally
            {
                Console.WriteLine("End Of Program");
            }
        }
    }
}
