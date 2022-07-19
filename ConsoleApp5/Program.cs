using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "C:/Users/ngoakot/Downloads/file.json";

            var fileContents = File.ReadAllText(file);

            var myDeserializedClass = JsonConvert.DeserializeObject<List<Test>>(fileContents);

            var filter = myDeserializedClass.GroupBy(n => new { n.newsSite, n.publishedAt.Year, n.publishedAt.Month });

            var list = new List<Newssite>();

            foreach (var item in filter)
            {
                list.Add(new Newssite
                {
                    newsSite = item.Key.newsSite,
                    MonthYear = new DateTime(item.Key.Year, item.Key.Month, 1),
                    Count = item.Count()
                });
            }
            foreach (var listItem in list)
            {
                Console.WriteLine($"{listItem.MonthYear.ToString("yyyy MMMM")} {listItem.newsSite} {listItem.Count}");
            }
            Console.ReadLine();
        }
    }
}
