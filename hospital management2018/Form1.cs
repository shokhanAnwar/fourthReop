using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_management2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        
        private void Form1_Load(object sender, EventArgs e)
        {
            slidepanel.Top = button3.Top;
            white1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button3.Top;
            userControl21.BringToFront();
         

        }

        private void button13_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button13.Top;
            userControl11.BringToFront();
           
           
        }

        private void userControl21_Load_2(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button6.Top;
            userControl31.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button8.Top;
            userControl41.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button10.Top;
            userControl51.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button9.Top;
            userControl61.BringToFront();
        }

        private void userControl61_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            a7saa aa = new a7saa();
            aa.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button15.Top;
            userControl71.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            slidepanel.Top = button20.Top;
            userControl81.BringToFront();
        }

   
    }
}
