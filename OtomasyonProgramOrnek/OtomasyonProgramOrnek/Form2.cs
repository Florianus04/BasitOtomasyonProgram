using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonProgramOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void BilgiVer(String koltukNo)
        {
            listBox7.Items.Add(koltukNo);
            listBox2.Items.Add(textBox1.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox6.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
        }
        void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BilgiVer("1");
            Temizle();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BilgiVer("2");
            Temizle();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BilgiVer("3");
            Temizle();
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BilgiVer("4");
            Temizle();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BilgiVer("5");
            Temizle();
            button7.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BilgiVer("6");
            Temizle();
            button5.Enabled = false;
        }
    }
}
