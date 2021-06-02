using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Calcualte_Z(object sender, EventArgs e)
        {
            Z_box.Text = Calcualte();
        }
        private string Calcualte()
        {
            int M1, N1, R1;
            double X1, a1, b1, Z1 = 0;
            if (Equaiton1.Checked)
                try
                {
                    M1 = Convert.ToInt32(M_input.Text);
                    X1 = Convert.ToDouble(X_input.Text);
                    for (int i = 1; i <= M1; i++)
                    {
                        Z1 += Math.Pow(-1 * X1, i) / Factorial(i + 1);
                    }
                    return Convert.ToString(Z1);
                }
                catch
                {
                    return "Errrror";
                }
            else if (Equation2.Checked)
            {
                N1 = Convert.ToInt32(N_select.SelectedItem);
                R1 = Convert.ToInt32(R_select.SelectedItem);
                try
                {
                    a1 = Convert.ToInt32(A_input.Text);
                    b1 = Convert.ToInt32(B_input.Text);
                    for (int i = 1; i <= N1; i++)
                    {
                        for (int j = 1; j <= R1; j++)
                        {
                            Z1 += (a1 * Math.Pow(i, 2)) / (Math.Pow(i, 3) + b1 * Math.Pow(j, 3));
                        }
                    }
                    return Convert.ToString(Z1);
                }
                catch
                {
                    return "Err0r";
                }
            }
            else
                return "Error";
        }
        long Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}