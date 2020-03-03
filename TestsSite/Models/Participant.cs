using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    public class Participant
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Test> Tests { get; set; }
        public Participant()
        {
            Tests = new List<Test>();
        }
    }
}