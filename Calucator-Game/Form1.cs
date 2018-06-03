using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calucator_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //读取关卡数据
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resource1.button_clicked_red;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resource1.button_normal_red;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            button2.BackgroundImage = Resource1.button_clicked_black;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Resource1.button_normal_black;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Resource1.button_clicked_bl;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.BackgroundImage = Resource1.button_normal_bl;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackgroundImage = Resource1.button_clicked_black;
        }
    }
}
