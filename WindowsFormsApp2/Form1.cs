using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        long var = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Highボタンがクリックされた時
            if (var >= 5)
            {
                label2.Text = "あたり☆";
            }
            else
            {
                label2.Text = "はずれ(笑)";
            }
            label1.Text = var.ToString();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lowボタンがクリックされた時
            if (var <= 4)
            {
                label2.Text = "あたり☆";
            }
            else
            {
                label2.Text = "はずれ(笑)";
            }
            label1.Text = var.ToString();
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            //起動時の初期処理
            label1.Text = "";
            label2.Text = "5より大きい？小さい？";

            var = rand.Next(1, 10); //１から９までの乱数
            Console.WriteLine("乱数" + var);
            button1.Enabled = true;
            button2.Enabled = true;

        }

    }
}
