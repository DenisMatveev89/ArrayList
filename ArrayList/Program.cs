using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int[] array = new int[] { 1, 3, 7, 1, 5, 3, 2, 87, 0, 1, 5 };
            al.AddLast(array);
            al.Sort();
            //al.ToArray();
            al.PrintArrayList();
        }
    }
}
