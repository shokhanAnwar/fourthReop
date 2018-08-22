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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            textBox4.Text = DateTime.Now.ToString("yyyy/MM/dd",new System.Globalization.CultureInfo(""));
            textBox5.Text = DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo(""));
        }

         

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainform_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString("hh : mm : ss .tt");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
