using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino_car
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort2.PortName = "COM4";
            serialPort2.BaudRate = 9600;
            serialPort2.Open();
        }

            private void button1_Click(object sender, EventArgs e)
             {
             } 
            private void button1_MouseDown(object sender, MouseEventArgs e)
            {
                //serialPort2.Write("f");
                serialPort2.Write("w");

            }

            private void button1_MouseUp(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button5_MouseDown(object sender, MouseEventArgs e)
            {
                //serialPort2.Write("f");
                serialPort2.Write("s");
            }

            private void button5_MouseUp(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button2_Click(object sender, EventArgs e)
            {
                //serialPort2.Write("5");

            }

            private void button3_MouseDown(object sender, MouseEventArgs e)
            {
                //serialPort2.Write("f");
                serialPort2.Write("a");
            }

            private void button3_MouseUp(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button4_MouseDown(object sender, MouseEventArgs e)
            {
                //serialPort2.Write("f");
                serialPort2.Write("d");
            }

            private void button4_MouseUp(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void textBox1_KeyUp(object sender, KeyEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button2_MouseDown(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button2_MouseUp(object sender, MouseEventArgs e)
            {
                serialPort2.Write("f");
            }

            private void button6_Click(object sender, EventArgs e)
            {
                serialPort2.Write("l");
            }

            private void button7_Click(object sender, EventArgs e)
            {
                serialPort2.Write("o");
            }
        }
    }
