using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "GhaithNote";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);
                sw.Write(richTextBox1.Text);
                sw.Close();
                fileStream.Close();
                richTextBox1.Clear();

            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            toolStripButton2.Checked = false;
            toolStripButton3.Checked = false;
            if (toolStripButton1.Checked == false)
            {
                toolStripButton1.Checked = true;    
            }
            else if (toolStripButton1.Checked == true)
            {
                toolStripButton1.Checked = false;    
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;    
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton3.Checked = false;
            if (toolStripButton2.Checked == false)
            {
                toolStripButton2.Checked = true;    
            }
            else if (toolStripButton2.Checked == true)
            {
                toolStripButton2.Checked = false;    
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;     
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            toolStripButton2.Checked = false;
            if (toolStripButton3.Checked == false)
            {
                toolStripButton3.Checked = true;   
            }
            else if (toolStripButton3.Checked == true)
            {
                toolStripButton3.Checked = false;    
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;    
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (toolStripButton7.Checked == false)
            {
                toolStripButton7.Checked = true; 
            }
            else if (toolStripButton7.Checked == true)
            {
                toolStripButton7.Checked = false;   
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

        
            FontStyle style = richTextBox1.SelectionFont.Style;

           
            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);     
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (toolStripButton8.Checked == false)
            {
                toolStripButton8.Checked = true;   
            }
            else if (toolStripButton8.Checked == true)
            {
                toolStripButton8.Checked = false;    
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
           
            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);    
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (toolStripButton9.Checked == false)
            {
                toolStripButton9.Checked = true;     
            }
            else if (toolStripButton9.Checked == true)
            {
                toolStripButton9.Checked = false;   
            }

            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

           
            FontStyle style = richTextBox1.SelectionFont.Style;

        
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);   
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (toolStripButton10.Checked == false)
            {
                toolStripButton10.Checked = true;
                richTextBox1.SelectionBullet = true;   
            }
            else if (toolStripButton10.Checked == true)
            {
                toolStripButton10.Checked = false;
                richTextBox1.SelectionBullet = false;  
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = "الملف: " + openFileDialog1.FileName;
            }
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }
        }
    }

