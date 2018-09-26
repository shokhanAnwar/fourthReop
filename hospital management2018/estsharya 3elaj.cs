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
    public partial class estsharya_3elaj : Form
    {
        public estsharya_3elaj()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
 
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
        
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
          
       
            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox23.Enabled = true;
            textBox22.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            dateTimePicker4.Enabled = true;
            dateTimePicker5.Enabled = true;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = true;
            dateTimePicker9.Enabled = true;
            dateTimePicker10.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
      
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            comboBox7.Enabled = false;
            comboBox8.Enabled = false;


            textBox1.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = true;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox23.Enabled = false;
            textBox22.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;

            comboBox7.Enabled = false;
            comboBox8.Enabled = false;


            textBox1.Enabled = false;        
            textBox5.Enabled = false;
            textBox6.Enabled = true;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox23.Enabled = false;
            textBox22.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;

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
