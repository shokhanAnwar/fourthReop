using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace hospital_management2018
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        Thread th;
        private void button6_Click(object sender, EventArgs e)
        {
            th = new Thread(backButton);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Hide();
        }
        private void backButton()
        {
            Application.Run(new white().ParentForm);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
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
            comboBox15.Enabled = true;
            comboBox16.Enabled = true;

            checkedListBox1.Enabled = true;
            checkedListBox2.Enabled = true;
            checkedListBox3.Enabled = true;

            textBox4.Enabled = true;
            textBox9.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;       
            textBox16.Enabled = true;
            textBox21.Enabled = true;          
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
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox41.Enabled = true;
            textBox42.Enabled = true;
            textBox44.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox50.Enabled = true;

           

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            checkBox32.Enabled = true;
            checkBox33.Enabled = true;
            checkBox34.Enabled = true;
            checkBox35.Enabled = true;

            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;

            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تمت اضافة المعلومات");
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
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
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;

            checkedListBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox3.Enabled = false;

            textBox4.Enabled = false;
            textBox9.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox16.Enabled = false;
            textBox21.Enabled = false;
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
         
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
       
            textBox44.Enabled = false;
       
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;



            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            checkBox32.Enabled = false;
            checkBox33.Enabled = false;
            checkBox34.Enabled = false;
            checkBox35.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;

            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
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
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;

            checkedListBox1.Enabled = false;
            checkedListBox2.Enabled = false;
            checkedListBox3.Enabled = false;

            textBox4.Enabled = false;
            textBox9.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox16.Enabled = false;
            textBox21.Enabled = false;
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

            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;

            textBox44.Enabled = false;

            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;



            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            checkBox32.Enabled = false;
            checkBox33.Enabled = false;
            checkBox34.Enabled = false;
            checkBox35.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;

            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }
    }
}
