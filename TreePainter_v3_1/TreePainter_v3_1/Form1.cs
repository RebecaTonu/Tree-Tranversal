using System;
using System.Collections.Generic;
using System.Collections;           
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;     
using System.Text;
using System.Windows.Forms;

namespace TreePainter_v3_1
{
    public partial class Form1 : Form
    {
        private bool scrolledAction = false;

        #region treePainter_vars
        private Color enabledNodeBackColor;
        private Color enabledNodeForeColor;
        private Color disabledNodeBackColor;
        private Color disabledNodeForeColor;
        private int nodeFontSize;
        private Font drawNodeFont;
        private Pen unionNodeLinesPen;
        #endregion

        public Form1()
        {
            InitializeComponent();
            _Form1 = this;

            enabledNodeBackColor = Color.Azure;
            enabledNodeForeColor = Color.Black;
            disabledNodeBackColor = Color.LightGray;
            disabledNodeForeColor = Color.LightGray;
            nodeFontSize = 13;
            drawNodeFont = new Font("Arial", nodeFontSize, FontStyle.Bold);
        }
        public static Form1 _Form1;

        public void update(string message)
        {
            richTextBox.AppendText(message);
        }

        private void pnlDrawBoard_Paint()
        {
            Color initialColor = Color.Azure;
            Color finalColor = Color.Red;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            ArrayList labels = new ArrayList();

            if (!scrolledAction && chbDraw.Checked)
                locateNodes(pnlDrawBoard, trvBaseTree, trvTempTree, out labels);
            else
                return;

            pnlDrawBoard.AutoScroll = true;
            if (!scrolledAction)
                for (int i = 0; i < labels.Count; i++)
                    pnlDrawBoard.Controls.Add((Label)labels[i]);

            scrolledAction = false;
            return;
        }

        int[,] matrix = new int[200, 200];
        int[] arrayhelper = new int[2000];
        int n = 0, m = 0;
        int[] arrayhelper_level = new int[2000];

        private void trvBaseTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode tn = trvBaseTree.SelectedNode;
            lblStatus.Text = "Informatii despre nod: \n \n" + tn.ToString() + "  Nivel " + tn.Level.ToString() + "\n";

            if (tn.Parent != null)
            {
                lblStatus.Text += "Parinte" + tn.Parent.ToString() + "  Nivel " + tn.Parent.Level.ToString();

                if(tn.Index.ToString() == "0") // e in stanga
                {
                    matrix[2, int.Parse(tn.Parent.Text)] = int.Parse(tn.Text);
                }
                else if(tn.Index.ToString() == "1")
                {
                    matrix[3, int.Parse(tn.Parent.Text)] = int.Parse(tn.Text);
                }

            }
            else
            {
                lblStatus.Text += "Nu are parinte";
                matrix[ 1 , int.Parse(tn.Text) ]= int.Parse(tn.Text);
            }

            sender = null;
            e = null;
            
        }

        int[,] bfs_array = new int [101,101];
        int[,] gbfs_array = new int[101, 101];

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tn = trvBaseTree.SelectedNode;

            if (tn != null)
            {
                tn.Nodes.Insert(trvBaseTree.SelectedNode.Index + 1, textBox1.Text);
                arrayhelper[++n] = int.Parse(trvBaseTree.SelectedNode.Text);
                arrayhelper[++n] = int.Parse(textBox1.Text);

                arrayhelper_level[++m] = int.Parse(trvBaseTree.SelectedNode.Text); //parintele
                arrayhelper_level[++m] = int.Parse(trvBaseTree.SelectedNode.Level.ToString()); //niv parinte
                arrayhelper_level[++m] = int.Parse(textBox1.Text); // copil
                arrayhelper_level[++m] = int.Parse(trvBaseTree.SelectedNode.Level.ToString()) + 1; //niv copil

                int j = int.Parse(trvBaseTree.SelectedNode.Level.ToString()) + 1;
                int sw = 0, sw2 = 0;
                int poz = 0;

                for(int i=1; i<=100; i++)
                {
                    if (bfs_array[j,i] == int.Parse(trvBaseTree.SelectedNode.Text))
                    {
                        sw=1;
                    }
                    if(bfs_array[j, i] == 0 && sw2 == 0)
                    {
                        poz = i;
                        sw2 = 1;
                    }
                }
                if(sw==0)
                {
                    bfs_array[j, poz] = int.Parse(trvBaseTree.SelectedNode.Text);
                }

                j++;
                sw = 0;
                sw2 = 0;
                poz = 0;

                for (int i = 1; i <= 100; i++)
                {
                    if (bfs_array[j, i] == int.Parse(textBox1.Text))
                    {
                        sw = 1;
                    }
                    if (bfs_array[j, i] == 0 && sw2 == 0)
                    {
                        poz = i;
                        sw2 = 1;
                    }
                }
                if (sw == 0)
                {
                    bfs_array[j, poz] = int.Parse(textBox1.Text);
                }

                for(int i=1; i<=20; i++)
                {
                    if(gbfs_array[i, int.Parse(trvBaseTree.SelectedNode.Text)] == 0)
                    {
                        gbfs_array[i, int.Parse(trvBaseTree.SelectedNode.Text)] = int.Parse(textBox1.Text);
                    }
                }
            }
            else
            {
                trvBaseTree.Nodes.Insert(trvBaseTree.GetNodeCount(false), textBox1.Text);
                bfs_array[1, 1] = int.Parse(textBox1.Text);
                gbfs_array[0, 0] = int.Parse(textBox1.Text);
            }
            textBox1.Clear();
        }

        private void chbDraw_CheckedChanged(object sender, EventArgs e)
        {
            nodeFontSize = 13;

            pnlDrawBoard.Controls.Clear();
            pnlDrawBoard.Refresh();
            pnlDrawBoard_Paint();
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBlankNode(TreeNode t, int untilLevel)
        {
            if (t.Level < untilLevel)
            {
                TreeNode tnBlank = new TreeNode("---");
                t.Nodes.Add(tnBlank);
                tnBlank.BackColor = Color.DodgerBlue;

                if (tnBlank.Level < untilLevel)
                    addBlankNode(tnBlank, untilLevel);
            }
            return;
        }

        private int getAllChildNodes(TreeNodeCollection nodes, ArrayList array)
        {
            int totalNodes = nodes.Count;
            foreach (TreeNode node in nodes)
            {
                array.Add(node);
                totalNodes += this.getAllChildNodes(node.Nodes, array);
            }
            return totalNodes;
        }

        int maxDepht2 = 0;

        private void locateNodes(Panel drawingPanel, TreeView originalTree, TreeView tempTree, out ArrayList labeledNodes)
        {
            tempTree.Nodes.Clear();
            Label labelAux;                 

            labeledNodes = new ArrayList();

            if (originalTree.Nodes.Count == 0)
                return;

            #region drawing variables

            Graphics board = drawingPanel.CreateGraphics();

            int x = 20;
            int y = 20;

            int maxDepht = 0;

            ArrayList list;
            ArrayList[] listByLevel;

            int xStart = 15;
            int yStart = pnlDrawBoard.Height - 30;

            int xInitial = xStart;
            int yInitial = yStart;

            this.drawNodeFont = new Font("Arial",13, FontStyle.Bold);

            #endregion

            list = new ArrayList();
            int totalNodes = getAllChildNodes(originalTree.Nodes, list);

            foreach (TreeNode n in list)
            {
                if (n.Level > maxDepht)
                {
                    maxDepht = n.Level;
                    maxDepht2 = n.Level;
                }
            }

            listByLevel = new ArrayList[maxDepht + 1];
        
            foreach (TreeNode n in list)
                if (n.Level == 0)
                    tempTree.Nodes.Add((TreeNode)n.Clone());

            list = new ArrayList();
            totalNodes = getAllChildNodes(tempTree.Nodes, list);

            foreach (TreeNode n in list)
                if (n.Nodes.Count == 0 && n.Level < maxDepht)
                    addBlankNode(n, maxDepht);  

            list = new ArrayList();
            totalNodes = getAllChildNodes(tempTree.Nodes, list);

            foreach (TreeNode n in list)
            {
                if (listByLevel[n.Level] == null)
                    listByLevel[n.Level] = new ArrayList();
                listByLevel[n.Level].Add(n);
            }

            x = xInitial;
            y = yInitial;

            for (int z = maxDepht; z >= 0; z--)
            {
                for (int index = 0; index < listByLevel[z].Count; index++)
                {
                    TreeNode nodeToPaint = (TreeNode)(listByLevel[z][index]);

                    labelAux = new Label();
                    labelAux.Name = nodeToPaint.Name;
                    labelAux.Font = drawNodeFont;
                    labelAux.Text = nodeToPaint.Text;
                    labelAux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labelAux.AutoSize = true;
                    labelAux.BorderStyle = BorderStyle.FixedSingle;

                    labelAux.Tag = nodeToPaint;

                    if (nodeToPaint.Text == "---")
                    {   
                        labelAux.BackColor = this.disabledNodeBackColor;
                        labelAux.ForeColor = this.disabledNodeForeColor;
                    }
                    else
                    {   
                        labelAux.BackColor = this.enabledNodeBackColor;
                        labelAux.ForeColor = this.enabledNodeForeColor;
                    }
                    unionNodeLinesPen = new Pen(labelAux.BackColor);

                    labelAux.Location = new Point(x, y);

                    nodeToPaint.Tag = new Rectangle(labelAux.Left,
                                                    labelAux.Top,
                                                    labelAux.PreferredWidth,
                                                    labelAux.PreferredHeight);

                    if (z < maxDepht)
                    {
                        Point posFirstChild =
                            getRectangleCenter((Rectangle)(nodeToPaint.FirstNode.Tag));

                        Point posLastChild =
                            getRectangleCenter((Rectangle)(nodeToPaint.LastNode.Tag));

                        Point relocatedPoint = labelAux.Location;
                        relocatedPoint.X = (posFirstChild.X + posLastChild.X) / 2 - labelAux.PreferredWidth / 2;
                        System.Console.WriteLine(nodeToPaint.Text + " x= " + relocatedPoint.X
                            + "\n  ->1: " + nodeToPaint.FirstNode.Text + " (" + posFirstChild.X + ");"
                            + "\n  ->2: " + nodeToPaint.LastNode.Text + " (" + posLastChild.X + ");");

                        labelAux.Location = relocatedPoint;
                        nodeToPaint.Tag = new Rectangle(labelAux.Left,
                                labelAux.Top,
                                labelAux.PreferredWidth,
                                labelAux.PreferredHeight);


                    }


                    foreach (TreeNode t in nodeToPaint.Nodes)
                    {
                        Rectangle r = new Rectangle(labelAux.Left,
                                                    labelAux.Top,
                                                    labelAux.PreferredWidth,
                                                    labelAux.PreferredHeight);

                        Point parentCenterPos = getRectangleCenter(r);


                        Point childCenterPos = getRectangleCenter((Rectangle)t.Tag);
                        childCenterPos.Y = ((Rectangle)t.Tag).Top;

                        board.DrawLine(unionNodeLinesPen, parentCenterPos, childCenterPos);
                    }

                    labeledNodes.Add(labelAux);
                    x = labelAux.Left + labelAux.PreferredWidth + 10;
                    System.Console.WriteLine("Calculated X:" + x.ToString());
                }
                y -= 30;

            }

        }

        private Point getRectangleCenter(Rectangle r)
        {
            return new Point(r.Left + r.Width / 2, r.Top + r.Height / 2);
        }

        //----------------------------------------------------------------------------------------------------------------


        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            
            Graph graph = new Graph(maxDepht2 + 10);
            for (int i = 1; i <= n; i = i + 2)
            {
                graph.AddEdge(arrayhelper[i], arrayhelper[i + 1]);
            }
            richTextBox.AppendText("Depth First Search (DFS):  ");
            graph.DFS();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            if(textBox3.Text == " ")
            {
                MessageBox.Show("Introduceti adancimea limita");
            }
            else
            {
                Graph graph2 = new Graph(maxDepht2 + 10);
                for (int i = 1; i <= m; i = i + 4)
                {
                    if (arrayhelper_level[i + 1] <= int.Parse(textBox3.Text) && arrayhelper_level[i + 3] <= int.Parse(textBox3.Text))
                    {
                        graph2.AddEdge(arrayhelper_level[i], arrayhelper_level[i + 2]);
                    }
                }
                richTextBox.AppendText("Depth Limited Search(DLS):  ");
                graph2.DFS_with_limit(int.Parse(textBox3.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            richTextBox.AppendText("Breadth First Search (BFS): ");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (bfs_array[i, j] != 0)
                    {
                        richTextBox.AppendText(bfs_array[i, j] + " ");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            int limit = maxDepht2 + 1;
            Graph[] graph_array = new Graph[10];
            richTextBox.AppendText("Iterative deepening search (IDS):  ");

            for (int j=1; j<=limit; j++)
            {
                richTextBox.AppendText("\n");
                graph_array[j] = new Graph(maxDepht2 + 10);

                for (int i = 1; i <= m; i = i + 4)
                {
                    if (arrayhelper_level[i + 1] < j && arrayhelper_level[i + 3] < j)
                    {
                        graph_array[j].AddEdge(arrayhelper_level[i], arrayhelper_level[i + 2]);
                    }
                }

                richTextBox.AppendText("Nivelul "+(j-1)+":  ");
                //graph2.DFS_with_limit(int.Parse(textBox3.Text));
                graph_array[j].DFS_with_limit(j);
            }
        }
        int cautare_min(int[,] gbfs_array, int col)
        {
            int mini = gbfs_array[1, col];
            for(int i=2; i<=20; i++)
            {
                if(gbfs_array[1,col]<mini)
                {
                    mini = gbfs_array[i, col];
                }
            }
            if(mini==0)
            {
                return 0;
            }
            else
            {
                return mini;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            richTextBox.AppendText("Greedy Best First Search (GBFS): ");
            richTextBox.AppendText(gbfs_array[0, 0] + " ");
            int coloana_cautare = gbfs_array[0, 0];
            int sw = 0;

            while(sw==0)
            {
                if(cautare_min(gbfs_array,coloana_cautare)==0)
                {
                    sw = 1;
                    break;
                }
                else
                {
                    
                    richTextBox.AppendText(cautare_min(gbfs_array, coloana_cautare) + " ");
                    coloana_cautare = cautare_min(gbfs_array, coloana_cautare);

                }
            }
        }

        //----------------------------------------------------------------------------------------
        int min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }

        int max(int a, int b)
        {
            if (a < b) return b;
            else return a;
        }

        int find_depth(int n)
        {
            int adancime = 0;
            while(n!=1)
            {
                n = n / 2;
                adancime++;
            }
            return adancime;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();

            if(textBox2.Text == " ")
            {
                MessageBox.Show("Introduceti numerele");
            }
            else
            {
                string[] numbers = textBox2.Text.Split(' ');
                int[] scores = new int[2000];
                int n = 0;

                foreach (var number in numbers)
                {
                    scores[++n] = int.Parse(number); 
                }

                int adancime = find_depth(n);

                int[,] minimaxi = new int[200, 200];

                for (int i = 1; i <= n; i++)
                {
                    minimaxi[1, i] = scores[i];
                    richTextBox.AppendText(scores[i] + " ");
                }
                richTextBox.AppendText("\n");

                int linie = 2;
                while (adancime != 0)
                {

                    int col = 1;

                    if (adancime%2==1)
                    {
                        richTextBox.AppendText("max: ");
                        for (int i = 1; i <= n; i = i + 2)
                        {
                            minimaxi[linie, col] = max(minimaxi[linie - 1, i], minimaxi[linie - 1, i + 1]);
                            richTextBox.AppendText(minimaxi[linie, col] + " ");
                            col++;
                        }
                    }
                    else if(adancime%2==0)
                    {
                        richTextBox.AppendText("min: ");
                        for (int i = 1; i <= n; i = i + 2)
                        {
                            minimaxi[linie, col] = min(minimaxi[linie - 1, i], minimaxi[linie - 1, i + 1]);
                            richTextBox.AppendText(minimaxi[linie, col] + " ");
                            col++;
                        }
                    }

                    n = n / 2;
                    linie++;
                    adancime--;
                    richTextBox.AppendText("\n");
                }
            }
        }
    }
}