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
    public partial class estsharya_tarexMartha : Form
    {
        public estsharya_tarexMartha()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
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
            comboBox23.Enabled = true;
            comboBox24.Enabled = true;
            comboBox25.Enabled = true;
            comboBox26.Enabled = true;
            comboBox27.Enabled = true;
            comboBox28.Enabled = true;
            comboBox29.Enabled = true;
            comboBox30.Enabled = true;
            comboBox31.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;    
            textBox6.Enabled = false;
          
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
 
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
       
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;       

            button4.Enabled = true;
            button5.Enabled = true;

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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
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
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            comboBox30.Enabled = false;
            comboBox31.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;

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
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
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
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            comboBox30.Enabled = false;
            comboBox31.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox6.Enabled = true;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}
