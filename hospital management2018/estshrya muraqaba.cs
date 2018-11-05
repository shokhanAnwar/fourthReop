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
    public partial class estshrya_muraqaba : Form
    {
        public estshrya_muraqaba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox7.Enabled = true;
          
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;
            textBox28.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox32.Enabled = true;
            textBox33.Enabled = true;
            textBox34.Enabled = true;
            textBox35.Enabled = true;
            textBox36.Enabled = true;
            textBox37.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox41.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox45.Enabled = true;     
            textBox46.Enabled = true;
            textBox47.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox50.Enabled = true;
            textBox51.Enabled = true;
            textBox52.Enabled = true;
            textBox53.Enabled = true;
            textBox54.Enabled = true;
            textBox55.Enabled = true;
            textBox56.Enabled = true;
            textBox57.Enabled = true;
            textBox58.Enabled = true;
            textBox59.Enabled = true;
            textBox60.Enabled = true;
            textBox61.Enabled = true;
            textBox62.Enabled = true;
            textBox63.Enabled = true;
            textBox64.Enabled = true;
            textBox65.Enabled = true;
            textBox66.Enabled = true;
            textBox67.Enabled = true;
            textBox68.Enabled = true;
            textBox69.Enabled = true;
            textBox70.Enabled = true;
            textBox71.Enabled = true;
            textBox72.Enabled = true;
            textBox73.Enabled = true;
        
            dateTimePicker1.Enabled = true;

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
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
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox7.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = true;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox51.Enabled = false;
            textBox52.Enabled = false;
            textBox53.Enabled = false;
            textBox54.Enabled = false;
            textBox55.Enabled = false;
            textBox56.Enabled = false;
            textBox57.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox61.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox65.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;
            textBox69.Enabled = false;
            textBox70.Enabled = false;
            textBox71.Enabled = false;
            textBox72.Enabled = false;
            textBox73.Enabled = false;

            dateTimePicker1.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

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
            comboBox5.Enabled = false;
            comboBox7.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = true;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox28.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox32.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox51.Enabled = false;
            textBox52.Enabled = false;
            textBox53.Enabled = false;
            textBox54.Enabled = false;
            textBox55.Enabled = false;
            textBox56.Enabled = false;
            textBox57.Enabled = false;
            textBox58.Enabled = false;
            textBox59.Enabled = false;
            textBox60.Enabled = false;
            textBox61.Enabled = false;
            textBox62.Enabled = false;
            textBox63.Enabled = false;
            textBox64.Enabled = false;
            textBox65.Enabled = false;
            textBox66.Enabled = false;
            textBox67.Enabled = false;
            textBox68.Enabled = false;
            textBox69.Enabled = false;
            textBox70.Enabled = false;
            textBox71.Enabled = false;
            textBox72.Enabled = false;
            textBox73.Enabled = false;

            dateTimePicker1.Enabled = false;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;


            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
