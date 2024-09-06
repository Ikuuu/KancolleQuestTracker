using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KancolleQuestTracker
{
    internal class HTMLQuestItems
    {
        public HtmlNode ID {get; set;}
        public HtmlNode Description {get; set;}
        public HtmlNode Requirenment {get; set;}
        public HtmlNode PreReq {get; set;}
        public HtmlNode Notes {get; set;}
    }
}
