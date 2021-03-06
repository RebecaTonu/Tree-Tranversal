/*
 * 
 *  TreePainter. Draws all the nodes of a TreeView in a Panel (with Labels).
 *  Copyright (C) 2010 Gustavo Antonio Parada Sarmiento gaps96@gmail.com
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */ 

namespace TreePainter_v3_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaseTree = new System.Windows.Forms.Label();
            this.trvBaseTree = new System.Windows.Forms.TreeView();
            this.trvTempTree = new System.Windows.Forms.TreeView();
            this.pnlDrawBoard = new System.Windows.Forms.Panel();
            this.lblDrawTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbDraw = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseTree
            // 
            this.lblBaseTree.AutoSize = true;
            this.lblBaseTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseTree.Location = new System.Drawing.Point(16, 11);
            this.lblBaseTree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseTree.Name = "lblBaseTree";
            this.lblBaseTree.Size = new System.Drawing.Size(123, 20);
            this.lblBaseTree.TabIndex = 0;
            this.lblBaseTree.Text = "Base TreeView";
            // 
            // trvBaseTree
            // 
            this.trvBaseTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvBaseTree.Location = new System.Drawing.Point(19, 32);
            this.trvBaseTree.Margin = new System.Windows.Forms.Padding(4);
            this.trvBaseTree.Name = "trvBaseTree";
            this.trvBaseTree.Size = new System.Drawing.Size(325, 278);
            this.trvBaseTree.TabIndex = 3;
            this.trvBaseTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvBaseTree_AfterSelect);
            // 
            // trvTempTree
            // 
            this.trvTempTree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trvTempTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvTempTree.Location = new System.Drawing.Point(59, 81);
            this.trvTempTree.Margin = new System.Windows.Forms.Padding(4);
            this.trvTempTree.Name = "trvTempTree";
            this.trvTempTree.Size = new System.Drawing.Size(195, 195);
            this.trvTempTree.TabIndex = 4;
            // 
            // pnlDrawBoard
            // 
            this.pnlDrawBoard.BackColor = System.Drawing.Color.Gray;
            this.pnlDrawBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDrawBoard.Location = new System.Drawing.Point(589, 31);
            this.pnlDrawBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDrawBoard.Name = "pnlDrawBoard";
            this.pnlDrawBoard.Size = new System.Drawing.Size(768, 455);
            this.pnlDrawBoard.TabIndex = 5;
            // 
            // lblDrawTitle
            // 
            this.lblDrawTitle.AutoSize = true;
            this.lblDrawTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawTitle.Location = new System.Drawing.Point(585, 11);
            this.lblDrawTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawTitle.Name = "lblDrawTitle";
            this.lblDrawTitle.Size = new System.Drawing.Size(166, 20);
            this.lblDrawTitle.TabIndex = 2;
            this.lblDrawTitle.Text = "Reprezentare grafica";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(352, 32);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(203, 278);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Informatii despre nod:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbDraw);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(536, 168);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduceti nodurile:";
            // 
            // chbDraw
            // 
            this.chbDraw.AutoSize = true;
            this.chbDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDraw.Location = new System.Drawing.Point(217, 95);
            this.chbDraw.Margin = new System.Windows.Forms.Padding(4);
            this.chbDraw.Name = "chbDraw";
            this.chbDraw.Size = new System.Drawing.Size(182, 24);
            this.chbDraw.TabIndex = 20;
            this.chbDraw.Text = "Deseneaza arborele";
            this.chbDraw.UseVisualStyleBackColor = true;
            this.chbDraw.CheckedChanged += new System.EventHandler(this.chbDraw_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 27);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 107);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adauga nodul fiu nodului parinte selectat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Depth First Search(DFS)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.richTextBox);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1337, 345);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmi";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(14, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(310, 36);
            this.button7.TabIndex = 29;
            this.button7.Text = "Greedy Best First Search (GBFS)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(14, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(310, 36);
            this.button6.TabIndex = 28;
            this.button6.Text = "Iterative Deepening Search (IDS)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(14, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(310, 36);
            this.button5.TabIndex = 27;
            this.button5.Text = "Breadth First Search (BFS)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(398, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(49, 27);
            this.textBox3.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Limita:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(908, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(421, 27);
            this.textBox2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Introduceti numerele:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(518, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 54);
            this.button4.TabIndex = 22;
            this.button4.Text = "MIMIMAX";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(518, 33);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(811, 127);
            this.richTextBox.TabIndex = 21;
            this.richTextBox.Text = "";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Depth Limited Search(DLS)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 855);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDrawTitle);
            this.Controls.Add(this.pnlDrawBoard);
            this.Controls.Add(this.trvBaseTree);
            this.Controls.Add(this.lblBaseTree);
            this.Controls.Add(this.trvTempTree);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1391, 902);
            this.MinimumSize = new System.Drawing.Size(1391, 902);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree Painter and Algorithm Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseTree;
        private System.Windows.Forms.TreeView trvBaseTree;
        private System.Windows.Forms.TreeView trvTempTree;
        private System.Windows.Forms.Panel pnlDrawBoard;
        private System.Windows.Forms.Label lblDrawTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbDraw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

