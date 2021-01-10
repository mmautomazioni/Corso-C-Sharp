using System;
namespace StackAndHeap
{
    class Program
    {
        static void Main()
        {
            int x1 = 10;
            int result=FirstMethod(x1);
           
        }
        static int FirstMethod(int a)
        {
            int y = 20;
            int z;
            z = SecondMethod(y);
            return z;
        }
        static int SecondMethod(int b)
        {
            int k = 30;
            return b+k;
        }
    }
}
