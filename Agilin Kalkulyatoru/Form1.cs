using System.Xml;

namespace Agilin_Kalkulyatoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(Output.Text=="")
            {
                Output.Text = "1";
            }
            else
            {
                Output.Text += 1;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "2";
            }
            else
            {
                Output.Text += 2;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "3";
            }
            else
            {
                Output.Text += 3;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "4";
            }
            else
            {
                Output.Text += 4;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "5";
            }
            else
            {
                Output.Text += 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "6";
            }
            else
            {
                Output.Text += 6;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "7";
            }
            else
            {
                Output.Text += 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "8";
            }
            else
            {
                Output.Text += 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "9";
            }
            else
            {
                Output.Text += 9;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (Output.Text == "")
            {
                Output.Text = "0";
            }
            else
            {
                Output.Text += 0;
            }
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            if(Output.Text=="")
            {
                Output.Text += "";
            }
            else if(Output.Text.Contains(","))
            {
                Output.Text += ",";
            }
        }

        string operation;
        double first, second;

        private void btn_minus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Output.Text);
            operation = "-";

            lbl_result.Text = Output.Text + "-";
            Output.Text = "";
        }

        private void btn_by_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Output.Text);
            operation = "*";

            lbl_result.Text = Output.Text + "*";
            Output.Text = "";
        }

        private void btn_diverse_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Output.Text);
            operation = "/";

            lbl_result.Text = Output.Text + "/";
            Output.Text = "";
        }

        double result;
        private void btn_equal_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            if (operation == "+")
            {
                lbl_result.Text += Output.Text;
                result = first + second;
                Output.Text = result.ToString();


            }
            if (operation == "-")
            {
                lbl_result.Text += Output.Text;
                result = first - second;
                Output.Text = result.ToString();


            }
            if (operation == "*")
            {
                lbl_result.Text += Output.Text;
                result = first * second;
                Output.Text = result.ToString();


            }
            if (operation == "/")
            {
                if (second != 0)
                {
                    lbl_result.Text += Output.Text;
                    result = first / second;
                    Output.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Error!");

                }
            }
         if(operation=="percent")
            {
                lbl_result.Text += Output.Text;
                result = first * second/100;
                Output.Text = result.ToString();
            }


        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Output.Text);
            operation = "percent";

            lbl_result.Text += Output.Text + "%";
            Output.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
            lbl_result.Text = "";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Output.Text.Length > 0)
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1, 1);
            }
            else if (Output.Text.Length == 0)
            {
                Output.Text = "";
            }
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            Output.Text = "3,14";
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            lbl_result.Text = "sin" + second;
            result = Math.Sin(second);
            Output.Text = result.ToString();
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            lbl_result.Text = "cos" + second;
            result = Math.Cos(second);
            Output.Text = result.ToString();
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            lbl_result.Text = "tan" + second;
            result = Math.Tan(second);
            Output.Text = result.ToString();
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            lbl_result.Text = second +  "^2";
            result = Math.Pow(second, 2);
            Output.Text = result.ToString();
        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(Output.Text);
            lbl_result.Text = second + " " + "root";
            result = Math.Sqrt(second);
            Output.Text = result.ToString();
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Output.Text);
            operation = "+";

            lbl_result.Text = Output.Text + "+";
            Output.Text = "";
        }
    }
}