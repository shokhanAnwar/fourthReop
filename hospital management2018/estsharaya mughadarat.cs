using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace hospital_management2018
{
    public partial class estsharaya_mughadarat : Form
    {
        public estsharaya_mughadarat()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox2.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;


            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;

            textBox6.Enabled = false;

           
            dateTimePicker3.Enabled = true;
          

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            button4.Enabled = true;
            button5.Enabled = true;

        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox2.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;


            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            textBox6.Enabled = true;


            dateTimePicker3.Enabled = false;


            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox2.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;


            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            textBox6.Enabled = true;


            dateTimePicker3.Enabled = false;


            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;
        }
        Thread th;
        private void button6_Click(object sender, EventArgs e)
        {

            th = new Thread(backButton);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void backButton()
        {
            Application.Run(new UserControl1().ParentForm);
        }

    }
}
