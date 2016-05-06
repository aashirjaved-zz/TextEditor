using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();   //when user will click on new
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // when user will click on save button
        {
            SaveFileDialog sav = new SaveFileDialog();
     
            sav.DefaultExt = "*.txt";
            sav.Filter = "TXT Files|*.txt";
            if (sav.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
      sav.FileName.Length > 0)
            {
              
                richTextBox1.SaveFile(sav.FileName, RichTextBoxStreamType.PlainText);
                //richTextBox1.SaveFile(this.Text=   sav.FileName);
            }

           

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // when user will open the file
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // richTextBox1.Find();
         
                
    }

    private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Italic == true && richTextBox1.Font.Underline == true)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
            }

            else if (richTextBox1.Font.Italic == true)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);

            }
            else if (richTextBox1.Font.Underline == true)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);

            }

            else
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Underline && richTextBox1.Font.Bold)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
            }
            else if (richTextBox1.Font.Bold)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if (richTextBox1.Font.Underline)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Underline | FontStyle.Italic);
            }

            else
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Font.Italic && richTextBox1.Font.Bold)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Underline | FontStyle.Italic | FontStyle.Bold);
            }
            else if (richTextBox1.Font.Bold)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if (richTextBox1.Font.Italic)
            {
                richTextBox1.Font = new Font(this.Font, FontStyle.Italic | FontStyle.Underline);
            }

            else
                richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Aashir Javed Version 1.1");
        }

        private void aboutCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.aashirjaved.me");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text != string.Empty)
                {// if the ritchtextbox is not empty; highlight the search criteria
                    int index = 0;
                    String temp = richTextBox1.Text;
                    richTextBox1.Text = "";
                    richTextBox1.Text = temp;
                    while (index < richTextBox1.Text.LastIndexOf(toolStrip.Text))
                    {
                        richTextBox1.Find(toolStrip.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                        richTextBox1.SelectionBackColor = Color.Yellow;
                        index = richTextBox1.Text.IndexOf(toolStrip.Text, index) + 1;
                        richTextBox1.Select();
                    }
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message, "Error finding text"); }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.Text =  richTextBox1.Text.Replace(toolStripTextBox1.Text, toolStripTextBox2.Text);
            //for replacing
        }
    }
    }
   

