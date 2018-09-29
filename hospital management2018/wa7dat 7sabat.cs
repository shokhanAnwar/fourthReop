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
    public partial class wa7dat_7sabat : Form
    {
        public wa7dat_7sabat()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        Thread th;
        private void button8_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;


            textBox1.Enabled = true;
            textBox8.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
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
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox37.Enabled = true;
            textBox41.Enabled = true;
            textBox45.Enabled = true;
            textBox35.Enabled = true;
            textBox36.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox47.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox50.Enabled = true;
            textBox46.Enabled = true;
            textBox53.Enabled = true;
      


            textBox6.Enabled = false;

            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;

            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;

            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;


            textBox1.Enabled = false;
            textBox8.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
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
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox37.Enabled = false;
            textBox41.Enabled = false;
            textBox45.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox46.Enabled = false;
            textBox53.Enabled = false;



            textBox6.Enabled = true;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;


            textBox1.Enabled = false;
            textBox8.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
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
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox37.Enabled = false;
            textBox41.Enabled = false;
            textBox45.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox46.Enabled = false;
            textBox53.Enabled = false;



            textBox6.Enabled = true;

            dateTimePicker6.Enabled = true;
            dateTimePicker7.Enabled = true;

            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

    }
}
