using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
        public ICollection<Question> Questions { get; set; }
        public Answers()
        {
            Questions = new List<Question>();
        }
    }
}