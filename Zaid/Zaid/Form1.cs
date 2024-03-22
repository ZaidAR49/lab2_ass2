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
namespace Zaid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void fasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void slowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void hideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
        int i = 0;
        int x, y;
        int c=0;
        private void timer1_Tick(object sender, EventArgs e)
        {


            x = int.Parse(s[i]);
            y = int.Parse(s[i+1]);
          
            pictureBox1.Location = new Point(x , y);
            i +=2;
            if(c==0)
            pictureBox1.Image = Properties.Resources._11;
            if (c == 1)
                pictureBox1.Image = Properties.Resources._22;
            if (c == 2)
                pictureBox1.Image = Properties.Resources._33;
            if (c == 3)
                pictureBox1.Image = Properties.Resources._44;
            if (c == 4)
                pictureBox1.Image = Properties.Resources._55;
            if (c == 5)
            {
                pictureBox1.Image = Properties.Resources._66;
                c = 0;
            }
            c++;
        }
        String[] s;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void importLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog open = new OpenFileDialog();
                open.ShowDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    StreamReader st = new StreamReader(open.FileName);
               s = st.ReadToEnd().Split(new char[] { '(', ')', ',', ' ', '\t', '\n', '\r' },StringSplitOptions.RemoveEmptyEntries);
                    timer1.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry ... somthig went wrong\n "+ ex.Message);
            }
                

        }
    }
}
