using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public Test Test { get; set; }
        public string Title { get; set; }
        public ICollection<Answers> Variants { get; set; }
        public Question()
        {
            Variants = new List<Answers>();
        }
    }
}