using System;
using System.Collections;
using System.Collections.Generic;

namespace Caching
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> getData = (List<string>)ApplicationCache.GetCacheMemory(CacheKeys.AVAILABLESTOCKES);
            if (getData == null)
            {
                StockItems items = new StockItems();
                ApplicationCache.SetCacheMemory(CacheKeys.AVAILABLESTOCKES, items.GetDefaultStocks());
                getData = (List<string>)ApplicationCache.GetCacheMemory(CacheKeys.AVAILABLESTOCKES);
            }
            foreach (var item in getData)
            {
                Console.WriteLine(item);

            }
        }
    }

    public class StockItems
    {
        public IEnumerable GetDefaultStocks()
        {
            return new List<string>() { "Sweet", "Salt", "SweetandSalt" };
        }
    }


}
