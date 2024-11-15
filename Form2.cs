using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        int n = 0;
        double[,] D, S;
        public Form2(double[,] D1, double[,] S1, int N)
        {
            InitializeComponent();
            dgD.AllowUserToAddRows = false;
            dgS.AllowUserToAddRows = false;
            D = D1;
            S = S1;
            n = N;
            Calc();
        }
        void Calc()
        {
            dgD.Rows.Clear();
            dgD.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                dgD.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }
            dgD.Rows.Add(n);
            for (int i = 0; i < dgD.Rows.Count; i++)
            {
                dgD.Rows[i].HeaderCell.Value = "x" + (i + 1).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j) dgD.Rows[i].Cells[i].Style.BackColor = Color.LightGray;
                    dgD.Rows[i].Cells[j].Value = D[i, j].ToString();
                }
            }

            dgS.Rows.Clear();
            dgS.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                dgS.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }
            dgS.Rows.Add(n);
            for (int i = 0; i < dgS.Rows.Count; i++)
            {
                dgS.Rows[i].HeaderCell.Value = "x" + (i + 1).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        dgS.Rows[i].Cells[j].Value = "-1";
                        dgS.Rows[i].Cells[i].Style.BackColor = Color.LightGray;
                    }
                    else dgS.Rows[i].Cells[j].Value = (S[i, j] + 1).ToString();
                }
            }
        }
    }
}
