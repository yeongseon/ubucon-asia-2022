using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleApp
{
    internal class Program
    {
        public class Session
        {
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public string? Title { get; set; }
            public string? Language { get; set; }
            public string? Speaker { get; set; }
        }
        static void Main(string[] args)
        {
            List<Session> sessionList = new List<Session>();

            var session1 = new Session
            {
                StartTime = new DateTime(2022, 11, 26, 10, 00, 00),
                EndTime = new DateTime(2022, 1, 26, 10, 30, 00),
                Title = "Opening speech",
                Language = "Korean",
                Speaker = "N/A"
            };

            sessionList.Add(session1);

            var session2 = new Session
            {
                StartTime = new DateTime(2022, 11, 26, 10, 30, 00),
                EndTime = new DateTime(2022, 1, 26, 11, 15, 00),
                Title = "Keynote",
                Language = "Korean",
                Speaker = "N/A"
            };

            sessionList.Add(session2);

            string fileName = "session.json";
            string jsonString = JsonSerializer.Serialize(sessionList);
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
