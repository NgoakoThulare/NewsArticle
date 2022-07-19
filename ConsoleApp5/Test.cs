using System;
using System.Collections.Generic;

namespace ConsoleApp5
{

    public class Test
    {

        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public string newsSite { get; set; }
        public string summary { get; set; }
        public DateTime publishedAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool featured { get; set; }
        public List<Launch> launches { get; set; }
        public List<Event> events { get; set; }
    }
    public class Event
    {
        public int id { get; set; }
        public string provider { get; set; }
    }

    public class Launch
    {
        public string id { get; set; }
        public string provider { get; set; }
    }
}
