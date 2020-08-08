using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Method1();
            Method2();
            Console.ReadLine();
        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i + "Method1");
                }
            });
        }
        public static async void Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i + "Method2");
                }
            });

        }
        //static void Main(string[] args)
        //{
        //    CallMethod();
        //    Console.ReadKey();
        //}

        //public static async void CallMethod()
        //{

        //    int count = await Method1();
        //    Method2();
        //    Method3(count);
        //}

        //public static async Task<int> Method1()
        //{
        //    int count = 0;
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.WriteLine(" Method 1");
        //            count += 1;
        //        }
        //    });
        //    return count;
        //}

        //public static void Method2()
        //{
        //    for (int i = 0; i < 25; i++)
        //    {
        //        Console.WriteLine(" Method 2");
        //    }
        //}

        //public static void Method3(int count)
        //{
        //    Console.WriteLine("Total count is " + count);
        //}
    }
}
