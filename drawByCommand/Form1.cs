using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawByCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Font f;
        Pen p;
        Brush b;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            f = Font;
            p = new Pen(Color.Black, 1);
            b = new SolidBrush(Color.Black);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float x1 = float.Parse(textBox2.Text);
                float y1 = float.Parse(textBox3.Text);
                float x2 = float.Parse(textBox4.Text);
                float y2 = float.Parse(textBox5.Text);

                if (textBox1.Text == "Line")
                {
                    g.DrawLine(p, x1, y1, x2, y2);

                }
                else if (textBox1.Text == "Point")
                {
                    g.DrawEllipse(p, x1, y1, x2, y2);
                }
                else if (textBox1.Text == "Rectangle")
                {
                    g.DrawRectangle(p, x1, y1, x2, y2);
                }
                else if (textBox1.Text == "Elipse")
                {
                    g.DrawEllipse(p, x1, y1, x2, y2);
                }
                else if (textBox1.Text == "Circle")
                {
                    g.DrawEllipse(p, x1, y1, x2, y2);
                }
                else if (textBox1.Text == "String")
                {
                    g.DrawString(textBox7.Text, f, b, x1, y1);
                }
                else if (textBox1.Text == "Square")
                {
                    g.DrawRectangle(p, x1, y1, x2, y2);
                }

                textBox6.Text += textBox1.Text + " , ";
                textBox6.Text += textBox2.Text + " , ";
                textBox6.Text += textBox3.Text + " , ";
                textBox6.Text += textBox4.Text + " , ";
                textBox6.Text += textBox5.Text + " , ";
                if (textBox1.Text == "String")
                {
                    textBox6.Text += textBox7.Text;
                }
                textBox6.Text += " \r\n ";
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Point";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Line";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Rectangle";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Square";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Elipse";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Circle";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "String";
        }
    }
}
