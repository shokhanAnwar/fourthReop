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
    public partial class sheet : Form
    {
        public sheet()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            comboBox1.Enabled =  true;
            comboBox2.Enabled =  true;
            comboBox4.Enabled =  true;
            comboBox5.Enabled =  true;
            comboBox31.Enabled = true;
            comboBox32.Enabled = true;
            comboBox33.Enabled = true;
            comboBox34.Enabled = true;
            comboBox35.Enabled = true;
            comboBox36.Enabled = true;
            comboBox22.Enabled = true;
            comboBox23.Enabled = true;
            comboBox24.Enabled = true;
            comboBox25.Enabled = true;
            comboBox26.Enabled = true;
            comboBox27.Enabled = true;
            comboBox28.Enabled = true;
            comboBox29.Enabled = true;
            comboBox30.Enabled = true;

            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox9.Enabled = true;
            textBox12.Enabled = true;

            panel3.Enabled = true;
            panel4.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox31.Enabled = false;
            comboBox32.Enabled = false;
            comboBox33.Enabled = false;
            comboBox34.Enabled = false;
            comboBox35.Enabled = false;
            comboBox36.Enabled = false;
            comboBox22.Enabled = false;
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            comboBox30.Enabled = false;

            textBox1.Enabled = true;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Enabled = false;
            textBox12.Enabled = false;

            panel3.Enabled = false;
            panel4.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox31.Enabled = false;
            comboBox32.Enabled = false;
            comboBox33.Enabled = false;
            comboBox34.Enabled = false;
            comboBox35.Enabled = false;
            comboBox36.Enabled = false;
            comboBox22.Enabled = false;
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            comboBox30.Enabled = false;

            textBox1.Enabled = true;

            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox9.Enabled = false;
            textBox12.Enabled = false;

            panel3.Enabled = false;
            panel4.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }
        Thread th;
        private void button7_Click(object sender, EventArgs e)
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

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
