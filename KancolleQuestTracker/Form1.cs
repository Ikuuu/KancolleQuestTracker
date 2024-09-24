using HtmlAgilityPack;
using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using Northwoods.Go;
using Northwoods.Go.Layouts;
using Northwoods.Go.Models;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KancolleQuestTracker
{
    public partial class Form1 : Form
    {
        private Diagram myDiagram;
        public class MyModel : GraphLinksModel<NodeData, string, object, LinkData, string, string> { }
        public class NodeData : MyModel.NodeData { 
            public string Color { get; set; }
            public bool isCompleted { get; set; }
        }
        public class LinkData : MyModel.LinkData { }
        private List<QuestItem> quests = new List<QuestItem>();
        private List<NodeData> questNodes = new List<NodeData>();
        private List<LinkData> linkDatas = new List<LinkData>();
        private Node currentlyClickedNode;
        private List<String> completedQuest = new List<String>();
        private List<String> manuallyCompleted = new List<String>();

        public Form1()
        {
            InitializeComponent();
            
            myDiagram = mainDiagramControl.Diagram;
            myDiagram.AllowMove = false;
            myDiagram.AllowCopy = false;
            myDiagram.AllowDelete = false;
 
        }
        private void nodeClick(GraphObject obj) {

            foreach (var node in myDiagram.Nodes)
            {
                var aShape = node.FindElement("SHAPE") as Shape;
                node.Opacity = .2;
                aShape.Stroke = null;
                //node.Visible = false;
            }

            foreach (var link in myDiagram.Links) 
            {
                link.Opacity = .2;
            }


            Node currNode = obj as Node;
            currNode.IsSelected = !currNode.IsSelected;
            var shape = currNode.FindElement("SHAPE") as Shape;
            
            shape.Stroke = "yellow";
            
            highlightNodeLineBack(currNode);
            highlightNodeLineForward(currNode);
            

        }

        private void highlightNodeLineBack(Node aNode)
        {
            
            //IEnumerable<Link> nodeLinksBack = aNode.Diagram.Links.Where(aLink => aLink.ToNode.Part.Key == aNode.Part.Key);
            IEnumerable<Link> nodeLinksBack = aNode.FindLinksInto();

            foreach (Link aLink in nodeLinksBack) 
            {
                aLink.Opacity = 1;
                highlightNodeLineBack(aLink.FromNode);
            }           
            
            aNode.Opacity = 1;
        }

        private void highlightNodeLineForward(Node aNode) 
        {
            //IEnumerable<Link> nodeLinksForward = aNode.Diagram.Links.Where(aLink => aLink.FromNode.Part.Key == aNode.Part.Key);
            IEnumerable<Link> nodeLinksForward = aNode.FindLinksOutOf();
            
            foreach (Link aLink in nodeLinksForward)
            {
                aLink.Opacity = 1;
                highlightNodeLineForward(aLink.ToNode);
            }
            
            aNode.Opacity = 1;
        }
        
        private void setup()
        {
            myDiagram.UndoManager.IsEnabled = true;

            myDiagram.NodeTemplate =
                new Node("Auto")
                {
                    Click = (e, obj) => 
                    {
                        
                        currentlyClickedNode = obj as Node;
                        nodeClick(obj);
                        generateQuestInfo(obj as Node);
                        
                    },
                    DoubleClick = (e, obj) => 
                    {
                        Node thisNode = obj as Node;
                        generateQuestInfo(thisNode);
                        Shape aShape = thisNode.FindElement("SHAPE") as Shape;
                        aShape.Stroke = "yellow";
                        foreach (var node in myDiagram.Nodes)
                        {
                            node.Visible = false;
                        }
                        searchedNodesBack(thisNode);
                        searchedNodesForward(thisNode);

                    },
                    Cursor = "pointer"
                }.Add(
                    new Shape("RoundedRectangle")
                    {
                        Name = "SHAPE",
                        Width = 600,
                        Height = 200,
                        Margin = 0,
                        Stroke = null,
                        StrokeWidth = 15,
                        Cursor = "pointer",
                        
                    }   
                        .Bind("Fill", "Color"),
                    new TextBlock
                    { Margin = 6, Font = new Northwoods.Go.Font("Segoe UI", 126), }
                      .Bind(new Northwoods.Go.Models.Binding("Text"))
                  );

            myDiagram.LinkTemplate =
                 new Link 
                 {
                    ToShortLength = 10,
                    
                 }.Add(
                    new Shape { StrokeWidth = 16, Opacity = 1 },
                    new Shape { ToArrow = "Standard", Stroke = null }
                 );

            

            myDiagram.Model = new MyModel
            {
                NodeDataSource = questNodes,
                LinkDataSource = linkDatas,
                
            };

            myDiagram.Layout = new LayeredDigraphLayout
            {
                LayerSpacing = 500,
                ColumnSpacing = 0
            };


        }

        private void clearOldRewards() 
        {
            picReward1.Image = null;
            picReward2.Image = null;
            picReward3.Image = null;
            picReward4.Image = null;
            picReward5.Image = null;
            picReward6.Image = null;

            lblReward1.Text = null;
            lblReward2.Text = null;
            lblReward3.Text = null;
            lblReward4.Text = null;
            lblReward5.Text = null;
            lblReward6.Text = null;
        }

        private void generateQuestInfo(Node aNode) 
        {
            clearOldRewards();
            QuestItem theQuest;
            try
            {
                theQuest = quests.Find(aQuest => aQuest.ID.ToLower() == aNode.Part.Key.ToString().ToLower());
                lblQuest.Text = theQuest.ID;
                lblQuestName.Text = theQuest.name;
                lblRequirenments.Text = theQuest.requirement;
                lblRequirenments.MaximumSize = panel2.Size;
                lblQuestRequirement.Text = theQuest.prereqs;
                lblRewardFuel.Text = theQuest.fuel.ToString();
                lblRewardAmmo.Text = theQuest.ammo.ToString();
                lblRewardSteel.Text = theQuest.steel.ToString();
                lblRewardBauxite.Text = theQuest.bauxite.ToString();
                linklblToWiki.Text = $"{theQuest.ID}";
                lblReward1.MaximumSize = picReward1.Size;
                lblReward2.MaximumSize = picReward2.Size;
                lblReward3.MaximumSize = picReward3.Size;
                lblReward4.MaximumSize = picReward4.Size;
                lblReward5.MaximumSize = picReward5.Size;
                lblReward6.MaximumSize = picReward6.Size;

                int rewardCounter = 0;

                foreach (Reward aReward in theQuest.possibleRewards)
                {
                    switch (rewardCounter)
                    {
                        case 0:
                            picReward1.Load(aReward.imgLink);
                            lblReward1.Text = aReward.name;
                            break;
                        case 1:
                            picReward2.Load(aReward.imgLink);
                            lblReward2.Text = aReward.name;
                            break;
                        case 2:
                            picReward3.Load(aReward.imgLink);
                            lblReward3.Text = aReward.name;
                            break;
                        case 3:
                            picReward4.Load(aReward.imgLink);
                            lblReward4.Text = aReward.name;
                            break;
                        case 4:
                            picReward5.Load(aReward.imgLink);
                            lblReward5.Text = aReward.name;
                            break;
                        case 5:
                            picReward6.Load(aReward.imgLink);
                            lblReward6.Text = aReward.name;
                            break;
                    }
                    rewardCounter++;
                }

                switch (theQuest.type)
                {
                    case "Composition":
                        panel1.BackColor = Color.Green;
                        panel2.BackColor = Color.Green;
                        panel3.BackColor = Color.Green;
                        panel4.BackColor = Color.Green;
                        panel6.BackColor = Color.Green;
                        break;
                    case "Sortie":
                        panel1.BackColor = Color.Red;
                        panel2.BackColor = Color.Red;
                        panel3.BackColor = Color.Red;
                        panel4.BackColor = Color.Red;
                        panel6.BackColor = Color.Red;
                        break;
                    case "Exersise":
                        panel1.BackColor = Color.LightGreen;
                        panel2.BackColor = Color.LightGreen;
                        panel3.BackColor = Color.LightGreen;
                        panel4.BackColor = Color.LightGreen;
                        panel6.BackColor = Color.LightGreen;
                        break;
                    case "Expedition":
                        panel1.BackColor = Color.LightBlue;
                        panel2.BackColor = Color.LightBlue;
                        panel3.BackColor = Color.LightBlue;
                        panel4.BackColor = Color.LightBlue;
                        panel6.BackColor = Color.LightBlue;
                        break;
                    case "Supply":
                        panel1.BackColor = Color.Yellow;
                        panel2.BackColor = Color.Yellow;
                        panel3.BackColor = Color.Yellow;
                        panel4.BackColor = Color.Yellow;
                        panel6.BackColor = Color.Yellow;
                        break;
                    case "Factory":
                        panel1.BackColor = Color.Brown;
                        panel2.BackColor = Color.Brown;
                        panel3.BackColor = Color.Brown;
                        panel4.BackColor = Color.Brown;
                        panel6.BackColor = Color.Brown;
                        break;
                    case "Modernization":
                        panel1.BackColor = Color.Purple;
                        panel2.BackColor = Color.Purple;
                        panel3.BackColor = Color.Purple;
                        panel4.BackColor = Color.Purple;
                        panel6.BackColor = Color.Purple;
                        break;
                    case "Marriage":
                        panel1.BackColor = Color.LightPink;
                        panel2.BackColor = Color.LightPink;
                        panel3.BackColor = Color.LightPink;
                        panel4.BackColor = Color.LightPink;
                        panel6.BackColor = Color.LightPink;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Quest Not Found");
            }
            
        }



        

        

        private void txtRemoveFilter_Click(object sender, EventArgs e)
        {
            foreach (var node in myDiagram.Nodes)
            {
                Shape aShape = node.FindElement("SHAPE") as Shape;
                aShape.Stroke = null;
                node.Visible = true;

                Shape aRibbon = node.FindElement("RIBBON") as Shape;
                if (aRibbon == null) 
                    node.Opacity = 1;
                else 
                    node.Opacity = .5;
            }

            foreach (var link in myDiagram.Links)
            {
                link.Opacity = 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String questToSearch = txtSearch.Text;
            if (!String.IsNullOrEmpty(questToSearch)) 
            {
                Object key = questToSearch.ToLower();
                Node searchedNode = myDiagram.FindNodeForKey(key);
                if (searchedNode != null) 
                {
                    generateQuestInfo(searchedNode);
                    Shape aShape = searchedNode.FindElement("SHAPE") as Shape;
                    aShape.Stroke = "yellow";
                    foreach (var node in myDiagram.Nodes)
                    {
                        node.Visible = false;
                    }
                    searchedNodesBack(searchedNode);
                    searchedNodesForward(searchedNode);
                }
                else 
                {
                    MessageBox.Show($"Quest: {questToSearch} was not found in the chart","Quest not found",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }


        }

        private void searchedNodesBack(Node aNode)
        {

            //IEnumerable<Link> nodeLinksBack = aNode.Diagram.Links.Where(aLink => aLink.ToNode.Part.Key == aNode.Part.Key);
            IEnumerable<Link> nodeLinksBack = aNode.FindLinksInto();

            foreach (Link aLink in nodeLinksBack)
            {
                aLink.Opacity = 1;
                searchedNodesBack(aLink.FromNode);
            }
            aNode.Visible = true;
            aNode.Opacity = 1;
        }

        private void searchedNodesForward(Node aNode)
        {
            //IEnumerable<Link> nodeLinksForward = aNode.Diagram.Links.Where(aLink => aLink.FromNode.Part.Key == aNode.Part.Key);
            IEnumerable<Link> nodeLinksForward = aNode.FindLinksOutOf();
            //aNode.Link
            foreach (Link aLink in nodeLinksForward)
            {
                aLink.Opacity = 1;
                searchedNodesForward(aLink.ToNode);
            }

            aNode.Visible = true;
            aNode.Opacity = 1;
        }


        private void completePreviousNodes(Node aNode) 
        {
            if (!completedQuest.Exists(x => x.ToLower() == aNode.Part.Key.ToString().ToLower())) 
            {
                completedQuest.Add(aNode.Part.Key.ToString());
            }
                

            IEnumerable<Link> nodeLinksBack = aNode.FindLinksInto();
            foreach (Link aLink in nodeLinksBack)
            {

                addCompletedRibbon(aLink.FromNode);
                aLink.FromNode.Opacity = .5;
                aLink.IsHighlighted = true;
                completePreviousNodes(aLink.FromNode);
            }


        }

        private void addCompletedRibbon(Node aNode) 
        {
            if (aNode.FindElement("RIBBON_PANEL") == null) 
            {
                aNode.Add(
                new Northwoods.Go.Panel("Spot")
                {
                    Name = "RIBBON_PANEL",
                    Opacity = 1,
                    Alignment = new Spot(1, 0, 5, -5),
                    AlignmentFocus = Spot.TopRight
                }
                .Add(
                    new Shape
                    {
                        Name = "RIBBON",
                        GeometryString = "F1 M0 0 L120 0 280 160 280 280z",
                        Fill = "DarkGreen",
                        StrokeWidth = 0
                    },
                    new TextBlock
                    {
                        Alignment = new Spot(1, 0, -29, 29),
                        Angle = 45,
                        MaxSize = new Northwoods.Go.Size(100, double.NaN),
                        Stroke = "white",
                        Font = new Northwoods.Go.Font("Segoe UI", 13, FontWeight.Bold),
                        TextAlign = TextAlign.Center
                    }
                )
            );
            }
            
        }

        private void removeCompletedRibbon(Node aNode) 
        {
            if(aNode.FindElement("RIBBON_PANEL") != null)
                aNode.Remove(aNode.FindElement("RIBBON_PANEL"));
        }

        private void btnSubmitQuests_Click(object sender, EventArgs e)
        {
           
            try 
            {
                String text = File.ReadAllText("./InputFiles/Quests.txt");
                if (!String.IsNullOrEmpty(text)) 
                {
                    String[] allMyQuests = text.Split(',');
                    foreach (String quest in allMyQuests)
                    {
                        completedQuest.Add(quest);
                        Object key = quest.ToLower();

                        Node searchedNode = myDiagram.FindNodeForKey(key);
                        if (searchedNode != null)
                            completePreviousNodes(searchedNode);
                        else
                            throw new Exception($"Quest: {quest} was not found in the nodes");
                    }
                }


                String manualQuest = File.ReadAllText("./InputFiles/manuallyCompleted.txt");
                if (!String.IsNullOrEmpty(manualQuest)) 
                {
                    String[] allManualQuests = manualQuest.Split(',');
                    foreach (String quest in allManualQuests)
                    {
                        manuallyCompleted.Add(quest);
                        Object key = quest.ToLower();

                        Node searchedNode = myDiagram.FindNodeForKey(key);
                        if (searchedNode != null)
                        {
                            addCompletedRibbon(searchedNode);
                            completePreviousNodes(searchedNode);
                        }
                        else
                            throw new Exception($"Quest: {quest} was not found in the nodes");
                    }
                }
                
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }

            button1.Enabled = true;
            btnQuestNotComplete.Enabled = true;
                
            
        }

        private void linklblToWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://en.kancollewiki.net/Quests#{linklblToWiki.Text}");
        }

        private void btnCompleteQuest(object sender, EventArgs e)
        {
            if (currentlyClickedNode != null)
            {
                currentlyClickedNode.Opacity = .5;
                addCompletedRibbon(currentlyClickedNode);
                completePreviousNodes(currentlyClickedNode);

                IEnumerable<Link> nodeLinksForward = currentlyClickedNode.FindLinksOutOf();
                foreach (Link aLink in nodeLinksForward) 
                {
                    if (!completedQuest.Exists(x => x.ToLower() == aLink.ToNode.Part.Key.ToString().ToLower()))
                    {
                        completedQuest.Add(aLink.ToNode.Part.Key.ToString());
                    }
                }
                rewriteQuestFile();
                manuallyCompleted.Add(currentlyClickedNode.Part.Key.ToString());
                rewriteManuallyCompleted();
            }
        }


        private void uncompleteNodesForward(Node aNode)
        {
            //IEnumerable<Link> nodeLinksForward = aNode.Diagram.Links.Where(aLink => aLink.FromNode.Part.Key == aNode.Part.Key);
            IEnumerable<Link> nodeLinksForward = aNode.FindLinksOutOf();
            //aNode.Link
            foreach (Link aLink in nodeLinksForward)
            {

                completedQuest.Remove(aLink.ToNode.Part.Key.ToString().ToLower());
                completedQuest.Remove(aLink.ToNode.Part.Key.ToString().ToUpper());

                manuallyCompleted.Remove(aLink.ToNode.Part.Key.ToString().ToLower());
                manuallyCompleted.Remove(aLink.ToNode.Part.Key.ToString().ToUpper());

                aLink.Opacity = 1;
                removeCompletedRibbon(aLink.ToNode);
                uncompleteNodesForward(aLink.ToNode);
            }

            aNode.Visible = true;
            aNode.Opacity = 1;
        }

        private void btnQuestNotComplete_Click(object sender, EventArgs e)
        {
            if (currentlyClickedNode != null)
            {
                manuallyCompleted.Remove(currentlyClickedNode.Part.Key.ToString().ToLower());
                manuallyCompleted.Remove(currentlyClickedNode.Part.Key.ToString().ToUpper());

                removeCompletedRibbon(currentlyClickedNode);
                uncompleteNodesForward(currentlyClickedNode);
                rewriteQuestFile();
                rewriteManuallyCompleted();
            }
        }

        private void rewriteManuallyCompleted()
        {

            String filePath = "./InputFiles/manuallyCompleted.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);

            if (manuallyCompleted.Count() > 0) 
            {
                List<string> result = manuallyCompleted;

                result = result.Distinct(StringComparer.OrdinalIgnoreCase).ToList();


                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    String text = "";
                    foreach (var quest in result)
                    {
                        var aString = quest;
                        if (aString.Contains(@"\"))
                            aString = aString.Substring(0, aString.IndexOf(@"\"));
                        text += aString + ",";
                    }

                    text = text.Substring(0, text.Length - 1);

                    outputFile.Write(text);
                }
            }
            else 
            {
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    String text = "";
                    outputFile.Write(text);
                }
            }
           
        }
        private void rewriteQuestFile() 
        {
            String filePath = "./InputFiles/Quests.txt";



            if (completedQuest.Count() > 0) 
            {
                List<string> result = completedQuest;

                result = result.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

                if (File.Exists(filePath))
                    File.Delete(filePath);

                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    String text = "";
                    foreach (var quest in result)
                    {
                        Node questNode = myDiagram.FindNodeForKey(quest as object);
                        if (questNode != null)
                        {
                            IEnumerable<Link> nodeLinksBack = questNode.FindLinksInto();
                            int previousNodeGood = 0;
                            foreach (Link nodeLink in nodeLinksBack)
                            {
                                if (nodeLink.FromNode.FindElement("RIBBON_PANEL") != null)
                                {
                                    previousNodeGood++;
                                }
                            }

                            if (previousNodeGood == nodeLinksBack.Count())
                            {
                                var aString = quest;
                                if (aString.Contains(@"\"))
                                    aString = aString.Substring(0, aString.IndexOf(@"\"));
                                text += aString + ",";
                            }
                        }

                    }
                    text = text.Substring(0, text.Length - 1);

                    outputFile.Write(text);
                }
            }
            
        }

        private void ImportQuests_Click(object sender, EventArgs e)
        {
            String url = "https://en.kancollewiki.net/Quests";
            HtmlWeb web = new HtmlWeb();




            List<HtmlNode> wikitables = new List<HtmlNode>();
            List<HTMLQuestItems> htmlQuests = new List<HTMLQuestItems>();


            try
            {
                HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(url);
                    

                HtmlNode htmlNode = htmlDoc.DocumentNode.ChildNodes[3].ChildNodes[3].ChildNodes[5].ChildNodes[9].ChildNodes[13].ChildNodes[0];



                foreach (HtmlNode node in htmlNode.ChildNodes)
                {
                    if (node.Name == "table" && node.OuterHtml.Contains("wikitable q"))
                    {
                        wikitables.Add(node.ChildNodes[1]);
                    }
                }

                foreach (HtmlNode node in wikitables)
                {
                    for (int i = 2; i < node.ChildNodes.Count; i++)
                    {
                        if (!String.IsNullOrEmpty(node.ChildNodes[i].Id))
                        {
                            HTMLQuestItems aQuestItem = new HTMLQuestItems();

                            aQuestItem.ID = node.ChildNodes[i];
                            aQuestItem.Description = node.ChildNodes[i + 2];
                            aQuestItem.Requirenment = node.ChildNodes[i + 4];
                            aQuestItem.PreReq = node.ChildNodes[i + 6];
                            aQuestItem.Notes = node.ChildNodes[i + 8];


                            htmlQuests.Add(aQuestItem);

                            i += 8;

                        }
                    }
                }

                foreach (HTMLQuestItems questItem in htmlQuests)
                {
                    QuestItem aQuest = new QuestItem();
                    aQuest.ID = questItem.ID.Id;
                    aQuest.repeat = questItem.ID.ChildNodes[1].InnerText;
                    String nameString = questItem.ID.ChildNodes[3].OuterHtml;
                    String fuelString = questItem.ID.ChildNodes[5].InnerText;
                    String ammoString = questItem.ID.ChildNodes[7].InnerText;
                    String steelString = questItem.ID.ChildNodes[9].InnerText;
                    String bauxiteString = questItem.ID.ChildNodes[11].InnerText;
                    String descriptionString = questItem.Description.ChildNodes[1].InnerText;
                    String requirementString = questItem.Requirenment.ChildNodes[1].InnerText;
                    String preReqString = questItem.PreReq.ChildNodes[3].InnerText;
                    String notesString = questItem.Notes.ChildNodes[3].InnerText;
                    if (nameString.IndexOf("<i>") > -1) {

                        int pFrom = nameString.IndexOf("<i>") + "<i>".Length;
                        int pTo = nameString.LastIndexOf("</i>");
                        aQuest.name = nameString.Substring(pFrom, pTo - pFrom);
                    }
                    else
                    {
                        aQuest.name = "Name Unknown";
                    }
                    

                    bool fuelSuccess = Int32.TryParse(fuelString.Substring(0, fuelString.Length - 1), out int fuelReward);
                    bool ammoSuccess = Int32.TryParse(ammoString.Substring(0, ammoString.Length - 1), out int ammoReward);
                    bool steelSuccess = Int32.TryParse(steelString.Substring(0, steelString.Length - 1), out int steelReward);
                    bool bauxiteSuccess = Int32.TryParse(bauxiteString.Substring(0, bauxiteString.Length - 1), out int bauxiteReward);

                    if (fuelSuccess)
                        aQuest.fuel = fuelReward;
                    else
                        aQuest.fuel = 0;

                    if (ammoSuccess)
                        aQuest.ammo = ammoReward; 
                    else
                        aQuest.ammo = 0;

                    if (steelSuccess) 
                        aQuest.steel = steelReward;
                    else
                        aQuest.steel = 0;
                    if (bauxiteSuccess)
                        aQuest.bauxite = bauxiteReward; 
                    else
                        aQuest.bauxite = 0;

                    aQuest.requirement = requirementString;
                    aQuest.description = descriptionString.Substring(0, descriptionString.Length - 1);
                    aQuest.prereqs = preReqString.Substring(0, preReqString.Length - 1);
                    aQuest.notes = notesString.Substring(0, notesString.Length - 1);

                    switch (aQuest.ID.ElementAt(0))
                    {
                        case 'A':
                            aQuest.type = "Composition";
                            break;
                        case 'B':
                            aQuest.type = "Sortie";
                            break;
                        case 'C':
                            aQuest.type = "Exersise";
                            break;
                        case 'D':
                            aQuest.type = "Expedition";
                            break;
                        case 'E':
                            aQuest.type = "Supply";
                            break;
                        case 'F':
                            aQuest.type = "Factory";
                            break;
                        case 'G':
                            aQuest.type = "Modernization";
                            break;
                        case 'W':
                            aQuest.type = "Marriage";
                            break;
                        default:
                            aQuest.type = "Unknown";
                            break;
                    }

                    foreach (HtmlNode rewardNode in questItem.Description.ChildNodes[3].ChildNodes)
                    {
                        if (rewardNode.Name == "div")
                        {
                            Reward aReward = new Reward();
                            aReward.name = rewardNode.InnerText;
                            aReward.imgLink = rewardNode.ChildNodes[0].ChildNodes[0].GetAttributeValue("src", "Not Found");
                            aQuest.possibleRewards.Add(aReward);
                        }
                    }


                    quests.Add(aQuest);
                }

                btnPopulate.Enabled = true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            foreach (QuestItem aQuest in quests)
            {
                NodeData aNode;
                if (aQuest.prereqs.Contains("Seasonal Exercises Quests")) 
                {
                    aQuest.prereqs = aQuest.prereqs.Replace("Seasonal Exercises Quests", "Cs3, Cs4, Cs5, Cs1, Cs2");
                }

                switch (aQuest.type)
                {
                    case "Composition":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "green", isCompleted = false };
                        break;
                    case "Sortie":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "red", isCompleted = false };
                        break;
                    case "Exersise":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "lightgreen", isCompleted = false };
                        break;
                    case "Expedition":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "lightblue", isCompleted = false };
                        break;
                    case "Supply":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "yellow", isCompleted = false };
                        break;
                    case "Factory":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "brown", isCompleted = false };
                        break;
                    case "Modernization":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "purple", isCompleted = false };
                        break;
                    case "Marriage":
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "lightpink", isCompleted = false };
                        break;
                    default:
                        aNode = new NodeData { Key = aQuest.ID.ToLower(), Text = aQuest.ID, Color = "orange", isCompleted = false };
                        break;
                }
                questNodes.Add(aNode);

                if (!String.IsNullOrEmpty(aQuest.prereqs))
                {
                    String[] preReqs = aQuest.prereqs.Split(',');
                    foreach (String preReq in preReqs)
                    {
                        String tempLine = preReq.ToLower();
                        if (tempLine.ElementAt(0) == ' ')
                        {
                            tempLine = tempLine.Substring(1);
                        }
                        LinkData aLinkData = new LinkData
                        {
                            From = tempLine,
                            To = aQuest.ID.ToLower()
                        };
                        linkDatas.Add(aLinkData);
                    }




                }
            }

            setup();
            ImportQuests.Enabled = false;
            btnPopulate.Enabled = false;
            btnSubmitQuests.Enabled = true;
            btnSearch.Enabled = true;
            btnRemoveFilter.Enabled = true;
        }
    }
}
