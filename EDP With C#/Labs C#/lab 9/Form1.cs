using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skylineButton_Click(object sender, EventArgs e)
        {

            string text = SkyLinetextBox.Text;
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i = i + 2)
            {

                chars[i] = char.ToUpper(chars[i]);
            }
            string result1 = new string(chars);
            SkylineResultLabel.Text = result1;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f' };

           String string1 = new string(charArray);
           String string2 = new string(charArray, 1, 2);
           String string3 = new string('e', 4);

            label4.Text = string1;
            label5.Text = string2;
            label6.Text = string3;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                int num = int.Parse(evenOddTextBox.Text);
                int result = num % 2;
                if (result == 0)
                {
                    evenOddResultLabel.Text = "EVEN";
                }
                else if(result == 1)
                {
                    evenOddResultLabel.Text = "ODD";
                }

            }
            catch(FormatException)
            {
                MessageBox.Show("Please Enter Numbers Only");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            int[] ints = { 4, 9, 2, 7, 10, };
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i]%2 == 0)
                {
                    result.Append(ints[i] + " ");
                }
            }

            EvenreultLabel.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            string[] strings = { "Haset", "Alpha", "Dagmawi" };
            for (int i = 0;i < strings.Length;i++)
            {
                result.Append((string)strings[i] + " ") ;
            }
            stringResultLabel.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sentence = wordCounttextBox.Text;
            int k = 0;
            
            foreach(char s in sentence)
            {
                if(s ==' ')
                {
                    k++;
                }
            }
            wordCountResult.Text = (k+1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string string1 = q7textBox.Text;
            q7comboBox.Items.Add(string1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            q7comboBox.Items.Remove(q7comboBox.SelectedItem);
        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (checkedListBox1.SelectedIndex ==  0)
            {
                listBox1.Items.Add(checkedListBox1.Items[0]);
               
            }

            if (checkedListBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add(checkedListBox1.Items[1]);

            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add(checkedListBox1.Items[2]);

            }

            if (checkedListBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add(checkedListBox1.Items[3]);

            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void q7comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.Items[-1]);
        }
    }
}
