using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sfteovor
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen p = new Pen(Color.Red);
        int timer = 0;
        int interval1;
        int interval2;
        int interval3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            interval1 = int.Parse(textBox1.Text);
            interval2 = int.Parse(textBox2.Text);
            interval3 = int.Parse(textBox3.Text);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.DrawEllipse(p, 1, 1, 50, 50);
            g.DrawEllipse(p, 1, 51, 50, 50);
            g.DrawEllipse(p, 1, 101, 50, 50);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            timer++;
            if (timer < interval1)
            {
                g.FillEllipse(redBrush, 1, 1, 50, 50);
                g.FillEllipse(whiteBrush, 1, 51, 50, 50);
                g.FillEllipse(whiteBrush, 1, 101, 50, 50);

            }
            if (timer > interval1 && timer < (interval1+interval2+interval3)-interval1+interval3)
            {
                g.FillEllipse(whiteBrush, 1, 1, 50, 50);
                g.FillEllipse(yellowBrush, 1,51, 50, 50);
                g.FillEllipse(whiteBrush, 1, 101, 50, 50);
            }
            if (timer> interval1 + interval2 && timer<interval1+interval2+interval3 )
            {
                g.FillEllipse(greenBrush, 1, 101, 50, 50);
                g.FillEllipse(whiteBrush, 1, 51, 50, 50);
                g.FillEllipse(whiteBrush, 1, 1, 50, 50);
            }
            if (timer>interval1+interval2+interval3)
            {
                timer = 0;
            }
            Refresh();
        }
    }
}
