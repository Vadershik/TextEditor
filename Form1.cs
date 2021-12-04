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

namespace Sublime_Text_10
{
    public partial class Form1 : Form
    {
        public string[] csreservL = File.ReadAllLines("cs-reserv-list.dicr");
        public Form1()
        {
            InitializeComponent();
            autocompleteMenu1.Items = csreservL;
            saveFileDialog1.Filter = "Text File (*.txt)|*.txt| All Files (*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, fastColoredTextBox1.Text);

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            string filename = openFileDialog1.FileName;
            fastColoredTextBox1.Text = File.ReadAllText(filename);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа написана неопытным шкилой");
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel) return;
            var font = fontDialog1.Font;
            fastColoredTextBox1.Font = font;
        }

        private void заднийФонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel) return;
            var color = colorDialog1.Color;
            fastColoredTextBox1.BackColor = color;
        }

        private void сToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JSON;
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.BackColor = Color.FromArgb(255,255,255);
            fastColoredTextBox1.ForeColor = Color.FromArgb(0,0,0);
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(255, 255, 255);
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(0, 0, 0);
        }

        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.BackColor = Color.FromArgb(88,88,88);
            panel1.BackColor = Color.FromArgb(99,99,99);
            fastColoredTextBox1.IndentBackColor = Color.FromArgb(99,99,99);
            fastColoredTextBox1.ForeColor = Color.FromArgb(220,220,220);
            fastColoredTextBox1.LineNumberColor = Color.FromArgb(220,220,220);
        }
    }
}
