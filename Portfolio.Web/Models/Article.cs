using System;

namespace Portfolio.Web.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime Date { get; set; }
        public string Body { get; set; }
    }
}