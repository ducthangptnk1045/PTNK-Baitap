using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string st, st1, finals, tem, tem1, sh ,sk;
        public static int k;
        long ll;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true )
            {
                label1.Text = " Enter the number ";
                radioButton1.Text = " Vietnamese ";
                radioButton2.Text = " English ";
                groupBox1.Text = " Languages ";
                button1.Text = " Read ";
                button2.Text = " Close ";
                button3.Text = " Listen ";
                this.Text = " Number ";
                if (textBox2.Text != "" )
                {
                    st = sh;
                    Class2.operation();
                    textBox2.Text = finals;
                }
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sh = ""; sk = textBox1.Text;
            for (int i = 0; i < sk.Length; i++)
                if (sk[i] != ',') sh += sk[i];
            if (Int64.TryParse(sk, out ll)) sk = ll.ToString("#,##0");
            else if (Int64.TryParse(sh, out ll)) sk = ll.ToString("#,##0");
            textBox1.Text = sk;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.MaxLength = 15;
            st = sh;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((radioButton2.Checked == true) && ( finals != ""))
            {
                SpeechSynthesizer doit = new SpeechSynthesizer();
                doit.SpeakAsync(finals);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = " Nhập số ";
                radioButton1.Text = " Tiếng Việt ";
                radioButton2.Text = " Tiếng Anh ";
                groupBox1.Text = " Ngôn Ngữ ";
                button1.Text = " Đọc số ";
                button2.Text = " Đóng ";
                button3.Text = " Nghe ";
                this.Text = " Đọc số Nguyên";
                if (textBox2.Text != "")
                {
                    st = sh;
                    Class1.xuly();
                    textBox2.Text = finals;
                }              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = finals = "";
            st = sh;
            if (radioButton1.Checked == true)
            {
                Class1.xuly();
                TiengVietissosuckthatIwannagiveupbutIcant.Vietxongmochettocbac();
            }
            else           
                Class2.operation();
            textBox2.Text = finals;       
        }
    }
}
