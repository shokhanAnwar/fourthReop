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
    public partial class saedaly_sareri : Form
    {
        public saedaly_sareri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {













        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;

            textBox6.Enabled = false;

          
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox13.Enabled = true;
            comboBox14.Enabled = true;
     


            dateTimePicker1.Enabled = true;
           


            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;



            button4.Enabled = true;
            button5.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            checkedListBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            textBox6.Enabled = true;


            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;



            dateTimePicker1.Enabled = false;



            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;



            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            checkedListBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

            textBox6.Enabled = true;


            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;



            dateTimePicker1.Enabled = false;



            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;



            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            checkedListBox1.Enabled = false;
        }
    }
}
