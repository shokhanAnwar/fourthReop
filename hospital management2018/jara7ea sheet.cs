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
    public partial class jra7ea_mutaba3a_ser_marath : Form
    {
        public jra7ea_mutaba3a_ser_marath()
        {
            InitializeComponent();
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox9.Enabled = true;
            comboBox10.Enabled = true;
            comboBox11.Enabled = true;
            comboBox12.Enabled = true;
            comboBox13.Enabled = true;
            comboBox14.Enabled = true;
            comboBox15.Enabled = true;
            comboBox16.Enabled = true;
            comboBox17.Enabled = true;
            comboBox18.Enabled = true;
            comboBox19.Enabled = true;
            comboBox20.Enabled = true;
            comboBox21.Enabled = true;
            comboBox22.Enabled = true;
            comboBox23.Enabled = true;
            comboBox24.Enabled = true;
            comboBox25.Enabled = true;
            comboBox26.Enabled = true;
            comboBox27.Enabled = true;
            comboBox28.Enabled = true;
            comboBox29.Enabled = true;
            
            textBox6.Enabled = false;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox32.Enabled = true;
            textBox35.Enabled = true;
            textBox34.Enabled = true;
            textBox36.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox58.Enabled = true;
            textBox59.Enabled = true;
            textBox60.Enabled = true;
            textBox62.Enabled = true;
            textBox63.Enabled = true;
            textBox64.Enabled = true;
            textBox66.Enabled = true;
            textBox67.Enabled = true;
            textBox68.Enabled = true;
            
            dateTimePicker1.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;


            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;


            button4.Enabled = true;
            button5.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;

            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox17.Enabled = false;
            comboBox18.Enabled = false;
            comboBox19.Enabled = false;
            comboBox20.Enabled = false;
            comboBox21.Enabled = false;
            comboBox22.Enabled = false;
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = true;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox35.Enabled = false;
            textBox34.Enabled = false;
            textBox36.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox17.Enabled = false;
            comboBox18.Enabled = false;
            comboBox19.Enabled = false;
            comboBox20.Enabled = false;
            comboBox21.Enabled = false;
            comboBox22.Enabled = false;
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = true;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox35.Enabled = false;
            textBox34.Enabled = false;
            textBox36.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;


            button4.Enabled = false;
            button5.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
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

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
