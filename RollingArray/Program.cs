using System;

namespace RollingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            RollingArray<int> myarray = new RollingArray<int>(10);
            Console.WriteLine("IsEmpty:" + myarray.IsEmpty.ToString());
            for (int i = 0; i < 5; i++)
            {
                myarray.Add(i);
            }
            Console.WriteLine("IsEmpty:" + myarray.IsEmpty.ToString());
            Console.WriteLine("Count:" + myarray.Count.ToString());
            Console.WriteLine("Head:" + myarray.Head.ToString());
            Console.WriteLine("Tail:" + myarray.Tail.ToString());
            arr = myarray.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
            myarray.Clear();
            Console.WriteLine("IsEmpty:" + myarray.IsEmpty.ToString());
            for (int i = 0; i < 15; i++)
            {
                myarray.Add(i);
            }
            Console.WriteLine("IsEmpty:" + myarray.IsEmpty.ToString());
            Console.WriteLine("Count:" + myarray.Count.ToString());
            Console.WriteLine("Head:" + myarray.Head.ToString());
            Console.WriteLine("Tail:" + myarray.Tail.ToString());
            arr = myarray.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
            myarray.Clear();
            Console.WriteLine("IsEmpty:" + myarray.IsEmpty.ToString());
            Console.WriteLine("Count:" + myarray.Count.ToString());
            try
            {
                Console.WriteLine("Head:" + myarray.Head.ToString());
                Console.WriteLine("Tail:" + myarray.Tail.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }


}
