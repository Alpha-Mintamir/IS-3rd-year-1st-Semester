using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator_WithC_
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if(txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                    {
                        txtResult.Text += num.Text;
                    }
                } else
                {
                    txtResult.Text += num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);
            switch(op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;
                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break; 
                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;
                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;
                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j ;
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                default: 
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);
            f = "";
            s = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 377;
            txtResult.Width = 318;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            txtResult.Width = 700;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to exit ", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int o = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(o, 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = sqrt.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Sqrt(logg);
            txtResult.Text = logg.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double y;
            y = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(y);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = a.ToString();

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sn = Convert.ToDouble(txtResult.Text);
            sn = Math.Sinh(sn);
            txtResult.Text = Convert.ToString(sn);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sn = Convert.ToDouble(txtResult.Text);
            sn = Math.Sin(sn);
            txtResult.Text = Convert.ToString(sn);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(txtResult.Text);
            int i1 = Convert.ToInt32(d);
            int i2 = (int)d;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double csh = Convert.ToDouble(txtResult.Text);
            csh = Math.Cosh(csh);
            txtResult.Text = Convert.ToString(csh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cs = Convert.ToDouble(txtResult.Text);
            cs = Math.Cos(cs);
            txtResult.Text = Convert.ToString(cs);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tnh = Convert.ToDouble(txtResult.Text);
            tnh = Math.Tanh(tnh);
            txtResult.Text = Convert.ToString(tnh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tn = Convert.ToDouble(txtResult.Text);
            tn = Math.Tan(tn);
            txtResult.Text = Convert.ToString(tn);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int h = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(h, 16);
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            double pr = Convert.ToDouble(txtResult.Text);
            pr = pr / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(pr);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Width = 760;
            txtResult.Width = 700;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Width = 377;
            txtResult.Width = 318;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 377;
            txtResult.Width = 318;
        }
    }
}
