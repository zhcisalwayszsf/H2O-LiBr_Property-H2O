using System;
using System.Windows.Forms;

namespace LiBr_H2O_Calculator
{
    public partial class Form1 : Form
    {

        double n1 = 1167.0521452767;
        double n2 = -724213.16703206;
        double n3 = -17.073846940092;
        double n4 = 12020.82470247;
        double n5 = -3232555.0322333;
        double n6 = 14.91510861353;
        double n7 = -4823.2657361591;
        double n8 = 405113.40542057;
        double n9 = -0.23855557567849;
        double n10 = 650.17534844798;

        public Form1()
        {
            InitializeComponent();
        }

        //限定输入框的内容为数字和小数点（放在design的textbox后面）
        private void textBoxNumOnly(object sender, KeyPressEventArgs e)
        {

            //当前输入的是"."且(输入框已经有“.”或者文本框没有内容)，则屏蔽输入
            if (e.KeyChar == '.' && (((TextBox)sender).Text.IndexOf(".") != -1 || ((TextBox)sender).Text.Length == 0))
            {
                e.Handled = true;
            }
            //如果输入的不是退格、数字和点，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

        }

        //水--压力-->焓
        private double ConculateH_P_SW(double p)
        {
            double h;
            double b = Math.Pow(p / 1000, 0.25);

            double E = Math.Pow(b, 2) + n3 * b + n6;
            double F = n1 * Math.Pow(b, 2) + n4 * b + n7;
            double G = n2 * Math.Pow(b, 2) + n5 * b + n8;
            double D = 2 * G / (-F - Math.Pow(Math.Pow(F, 2) - 4 * E * G, 0.5));
            double t = (n10 + D - Math.Pow(Math.Pow(n10 + D, 2) - 4 * (n9 + n10 * D), 0.5)) / 2 - 273;
            h = 4.1868 * (1.001 * t - 0.01 + 100);
            return h;
        }
        //水--温度-->焓
        private double ConculateH_T_SW(double t)
        {
            double h;
            h = 4.1868 * (1.001 * t - 0.01 + 100);
            return h;
        }

        //水--温度-->计算压力
        private double ConculateP_T_SW(double t)
        {
            double p;
            double a = (t + 273) + n9 / (t + 273 - n10);
            double A = Math.Pow(a, 2) + n1 * a + n2;
            double B = n3 * Math.Pow(a, 2) + n4 * a + n5;
            double C = n6 * Math.Pow(a, 2) + n7 * a + n8;
            p = Math.Pow(2 * C / (-B + Math.Pow((Math.Pow(B, 2) - 4 * A * C), 0.5)), 4) * 1000;
            return p;
        }

        //水蒸汽--温度，压力-->焓
        private double ConculateH_PT_SSW(double p, double t)
        {
            double h;
            h = 2.326 * ((0.071533 * (t + 230) - 13.08426) * p * Math.Pow(10, -2) + (0.808956 * (t + 230) + 1075.18144));
            return h;
        }

        //水蒸汽--压力-->温度
        private double ConculateT_P_SSW(double p)
        {
            double t;
            double a = 9.3876;
            double b = 3826.36;
            double c = 227.68;
            t = b / (a - Math.Log(p / 1000)) - c;
            /* 
             t = 42.6776 - 3892.7 / (log(p / 1000) - 9.48654)
            */
            return t;
        }
        //水蒸汽--温度-->密度
        private double ConculateM_T_SSW(double t)
        {
            double m;
            m = 0.0001 * (0.02487 * Math.Pow(t, 3) - 4.9318 * Math.Pow(t, 2) + 442.021 * t - 13761.2);
            return m;
        }
        //过热蒸汽--压力，温度-->焓
        private double ConculateH_P_T_SHS( double p, double t)
        {
            double h;
            h = 4.02086 * (466.69 + 0.47 * (t + 273 * 2) - 202.96 * p * Math.Pow(10, -6) / Math.Pow((t + 2 * 273) / 100, (10 / 3)) - 2224800 * Math.Pow(p * Math.Pow(10, -6), 3) / Math.Pow((t + 2 * 273) / 100, 14));
            return h;
        }

        //水的物性参数计算&&按钮
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (textBox2.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox7.Text = ConculateH_P_SW(Double.Parse(textBox2.Text)).ToString();
                        label12.Text = "kJ/kg";
                        break;
                    }
                case 1:
                    if (textBox1.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox7.Text = ConculateH_T_SW(Double.Parse(textBox1.Text)).ToString();
                        label12.Text = "kJ/kg";
                        break;
                    }
                case 2:
                    if (textBox1.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox7.Text = ConculateP_T_SW(Double.Parse(textBox1.Text)).ToString();
                        label12.Text = "℃";
                        break;
                    }
                default:
                    SelectModelMessage();
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    if (textBox5.Text == String.Empty | textBox6.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox8.Text = ConculateH_PT_SSW(Double.Parse(textBox5.Text), Double.Parse(textBox6.Text)).ToString();
                        label13.Text = "kJ/kg";
                        break;
                    }
                case 1:
                    if (textBox5.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox8.Text = ConculateT_P_SSW(Double.Parse(textBox5.Text)).ToString();
                        label13.Text = "℃";
                        break;
                    }
                case 2:
                    if (textBox6.Text == String.Empty)
                    {
                        NoEmptyInput();
                        break;
                    }
                    else
                    {
                        textBox8.Text = ConculateM_T_SSW(Double.Parse(textBox6.Text)).ToString();
                        label13.Text = "";
                        break;
                    }
                default:
                    SelectModelMessage();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox11.Text != String.Empty| textBox12.Text != String.Empty)
            {
                textBox9.Text = ConculateH_P_T_SHS(Double.Parse(textBox11.Text), Double.Parse(textBox12.Text)).ToString();
                label15.Text = "kJ/kg";
            }
            else
            {
                NoEmptyInput();
            }
        }

        private void NoEmptyInput()
        {
            string message = "请正确输入数据";
            string caption = "提示";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }

        private void SelectModelMessage()
        {
            string message = "请选择计算模式！";
            string caption = "提示";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Displays the MessageBox.
            MessageBox.Show(message, caption, buttons);
        }


    }
}
