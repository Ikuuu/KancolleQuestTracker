using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KancolleQuestTracker
{
    internal class QuestItem
    {
        public List<Reward> possibleRewards = new List<Reward>();
        public String ID { get; set; }
        public String type { get; set; }
        public String repeat { get; set; }
        public String name { get; set; }
        public int fuel { get; set; }
        public int ammo { get; set; }
        public int steel { get; set; }
        public int bauxite { get; set; }
        public String description { get; set; }
        public String requirement { get; set; }
        public String prereqs { get; set; }
        public String notes { get; set; }
        

    }
}
