using System;
using System.Linq;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0;
            int[] mas = new int[count];
            int rez = 0;
            for (int i = 0; i < count; i++)
            {
                sum = number + (i * add);
                mas[i] = sum;
                rez = mas.Sum();
            }
            return rez;
        }
    }
}
