using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    public class ParticipantAnswer
    {
        public int Id { get; set; }
        public Participant Participant { get; set; }
        public Test TestId { get; set; }
        public Question QuestionId { get; set; }
        public Answers AnswerId { get; set; }
    }
}