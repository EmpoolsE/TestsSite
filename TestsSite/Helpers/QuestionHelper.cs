using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestsSite.Models;

namespace TestsSite.Helpers
{
    public static class QuestionHelper
    {
        public static MvcHtmlString ShowQuestions(this HtmlHelper html, IEnumerable<Question> questions)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (var item in questions)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item.Title);
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }
    }

}