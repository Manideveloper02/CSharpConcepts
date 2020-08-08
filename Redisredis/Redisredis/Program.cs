using StackExchange.Redis;
using System;

namespace Redisredis
{
    class Program
    {
        static void Main(string[] args)
        {
            //REDIS
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            IDatabase db = redis.GetDatabase();
            if (!db.KeyExists("Name"))
            {
                db.KeyDelete("Name");
                db.StringSet("Name", "Mani");
            }
            Console.WriteLine(db.StringGet("Name"));
        }

    }
}
