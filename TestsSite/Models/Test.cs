using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Question> Questions { get; set; }
        public Test()
        {
            Questions = new List<Question>();
        }
    }
}