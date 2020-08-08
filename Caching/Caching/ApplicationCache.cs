using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Caching;

namespace Caching
{
    public static class ApplicationCache
    {
        private static CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
        private static ObjectCache cache = MemoryCache.Default;
        public static void SetCacheMemory(string cacheName, object cacheValue)
        {
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddDays(1);
            cache.Add(cacheName, cacheValue, cacheItemPolicy);
        }
        public static void SetCacheMemory(string cacheName, object cacheValue , int days)
        {
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddDays(days);
            cache.Add(cacheName, cacheValue, cacheItemPolicy);
        }

        public static object GetCacheMemory(string cacheName)
        {
            if (cache.Contains(cacheName))
            {
                return (List<string>)cache.Get(cacheName);
            }
            else
            {
                return null;
            }

        }
    }
}
