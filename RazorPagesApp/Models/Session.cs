using System;
using System.Text.Json.Serialization;

namespace RazorPagesApp.Models
{
    public class Session
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime {get; set; }
        public string? Title { get; set; }
        public string? Language { get; set;}
        public string? Speaker {get; set;}
    }
}