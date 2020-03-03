using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestsSite.Models
{
    //DropCreateDatabaseIfModelChanges
    public class RaisecInit : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var RaisecTest = new Test();
            RaisecTest.Title = "RAISEC";
            Answers a1 = new Answers { Title = "Yes", Value = 1 };
            Answers a2 = new Answers { Title = "No", Value = 0 };
            context.AllAnswers.AddRange(new List<Answers> { a1, a2 });
            context.SaveChanges();
            Question q1 = new Question { Title = "I like to work on cars" };
            Question q2 = new Question { Title = "I like to do puzzles" };
            Question q3 = new Question { Title = "I am good at working independently" };
            Question q4 = new Question { Title = "I like to work in teams" };
            Question q5 = new Question { Title = "I am an ambitious person, I set goals for myself" };
            Question q6 = new Question { Title = "I like to organize things, (files, desks/offices)" };
            Question q7 = new Question { Title = "I like to build things" };
            Question q8 = new Question { Title = "I like to read about art and music" };
            Question q9 = new Question { Title = "I like to have clear instructions to follow" };
            Question q10 = new Question { Title = "I like to try to influence or persuade people" };
            Question q11 = new Question { Title = "I like to do experiments" };
            Question q12 = new Question { Title = "I like to teach or train people" };
            Question q13 = new Question { Title = "I like trying to help people solve their problems" };
            Question q14 = new Question { Title = "I like to take care of animals" };
            Question q15 = new Question { Title = "I wouldn’t mind working 8 hours per day in an office" };
            Question q16 = new Question { Title = "I like selling things" };
            Question q17 = new Question { Title = "I enjoy creative writing" };
            Question q18 = new Question { Title = "I enjoy science" };
            Question q19 = new Question { Title = "I am quick to take on new responsibilities" };
            Question q20 = new Question { Title = "I am interested in healing people" };
            Question q21 = new Question { Title = "I enjoy trying to figure out how things work" };
            Question q22 = new Question { Title = "I like putting things together or assembling things" };
            Question q23 = new Question { Title = "I am a creative person" };
            Question q24 = new Question { Title = "I pay attention to details" };
            Question q25 = new Question { Title = "I like to do filing or typing" };
            Question q26 = new Question { Title = "I like to analyze things (problems/situations)" };
            Question q27 = new Question { Title = "I like to play instruments or sing" };
            Question q28 = new Question { Title = "I enjoy learning about other cultures" };
            Question q29 = new Question { Title = "I would like to start my own business" };
            Question q30 = new Question { Title = "I like to cook" };
            Question q31 = new Question { Title = "I like acting in plays" };
            Question q32 = new Question { Title = "I am a practical person" };
            Question q33 = new Question { Title = "I like working with numbers or charts" };
            Question q34 = new Question { Title = "I like to get into discussions about issues" };
            Question q35 = new Question { Title = "I am good at keeping records of my work" };
            Question q36 = new Question { Title = "I like to lead" };
            Question q37 = new Question { Title = "I like working outdoors" };
            Question q38 = new Question { Title = "I would like to work in an office" };
            Question q39 = new Question { Title = "I’m good at math" };
            Question q40 = new Question { Title = "I like helping people" };
            Question q41 = new Question { Title = "I like to draw" };
            Question q42 = new Question { Title = "I like to give speeches" };
            List<Question> questions = new List<Question> { q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24, q25, q26, q27, q28, q29, q30, q31, q32, q33, q34, q35, q36, q37, q38, q39, q40, q41, q42 };
            foreach (var q in questions)
            {
                q.Variants.Add(a1);
                q.Variants.Add(a2);
            }
            context.Questions.AddRange(questions);
            context.SaveChanges();
            Test raisec = new Test { Title = "Raisec Test"};
            foreach (var q in questions)
            {
                raisec.Questions.Add(q);
            }
            context.Tests.Add(raisec);
            context.SaveChanges();
        }
    }
}