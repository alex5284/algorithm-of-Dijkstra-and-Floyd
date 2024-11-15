using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dg.AllowUserToAddRows = false;
            listBox1.HorizontalScrollbar = true;
        }
        int n = 0, firstpoint = 0;
        double[,] matrix;
        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void CreateMatrix2()
        {
            cb1.Items.Clear();
            n = Convert.ToInt32(tbn.Text);
            dg.Rows.Clear();
            dg.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                cb1.Items.Add("x" + (i+1).ToString());
                dg.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }
            cb1.SelectedIndex = 0;
            dg.Rows.Add(n);
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].HeaderCell.Value = "x" + (i + 1).ToString();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j) dg.Rows[i].Cells[i].Style.BackColor = Color.LightGray;
                    dg.Rows[i].Cells[j].Value = "0";
                }
            }
        }
        void CreateMatrixTest()
        {
            cb1.Items.Clear();
            n = 6;
            tbn.Text = n.ToString();
            dg.Rows.Clear();
            dg.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                cb1.Items.Add("x" + (i + 1).ToString());
                dg.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }
            cb1.SelectedIndex = 0;
            dg.Rows.Add(n);
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].HeaderCell.Value = "x" + (i + 1).ToString();
            }
            double[,] M = new double[n, n];
            M[0, 1] = M[1, 0] = 7;
            M[0, 2] = M[2, 0] = 9;
            M[0, 5] = M[5, 0] = 14;
            M[1, 2] = M[2, 1] = 10;
            M[1, 3] = M[3, 1] = 15;
            M[2, 3] = M[3, 2] = 11;
            M[2, 5] = M[5, 2] = 2;
            M[4, 3] = M[3, 4] = 6;
            M[4, 5] = M[5, 4] = 9;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) dg.Rows[i].Cells[i].Style.BackColor = Color.LightGray;
                    dg.Rows[i].Cells[j].Value = M[i,j].ToString();
                }
            }
        }
        void CreateMatrixTest2()
        {
            cb1.Items.Clear();
            n = 5;
            tbn.Text = n.ToString();
            dg.Rows.Clear();
            dg.Columns.Clear();
            for (int i = 0; i < n; i++)
            {
                cb1.Items.Add("x" + (i + 1).ToString());
                dg.Columns.Add("x" + (i + 1).ToString(), "x" + (i + 1).ToString());
            }
            cb1.SelectedIndex = 0;
            dg.Rows.Add(n);
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                dg.Rows[i].HeaderCell.Value = "x" + (i + 1).ToString();
            }
            double[,] M = new double[n, n];
            M[0, 1] = M[1, 0] = 3;
            M[0, 2] = M[2, 0] = 10;
            M[1, 3] = M[3, 1] = 5;
            M[2, 3] = M[3, 2] = 6;
            M[4, 3] = M[3, 4] = 4;
            M[2, 4] = 15;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) dg.Rows[i].Cells[i].Style.BackColor = Color.LightGray;
                    dg.Rows[i].Cells[j].Value = M[i, j].ToString();
                }
            }
        }
        private void dg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dg.Columns.Count > 0 && dg.Rows.Count > 0)
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                    {
                        var newValue = dg[e.ColumnIndex, e.RowIndex].Value;

                        dg[e.RowIndex, e.ColumnIndex].Value = newValue;
                    }
                }
            }
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMatrix2();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrixTest();
        }
        void Read()
        {
            n = Convert.ToInt32(tbn.Text);
            matrix = new double[n,n];
            firstpoint = cb1.SelectedIndex;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToDouble(dg.Rows[i].Cells[j].Value);
                }
            }
        }
        void Deikstru()
        {
            listBox1.Items.Clear();
            Read();
            List<Tuple<double, int, bool>> All = new List<Tuple<double, int, bool>>();
            for(int i = 0; i < n; i++)
            {
                if (i == firstpoint) All.Add(new Tuple<double, int, bool>(0, firstpoint, true));
                else All.Add(new Tuple<double, int, bool>(100000000000000, -1, false));
            }

            int nextpoint = firstpoint;
            do
            {
                List<int> index = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    if (matrix[nextpoint, i] != 0 && All[i].Item3 == false) index.Add(i);
                }

                for (int i = 0; i < index.Count; i++)
                {
                    double temp = matrix[nextpoint, index[i]] + All[nextpoint].Item1;
                    List<double> temp2 = new List<double>();
                    if (temp < All[index[i]].Item1) All[index[i]] = new Tuple<double, int, bool>(temp, nextpoint, false);
                }

                double min = All.Where(item => !item.Item3).Min(item => item.Item1);
                int minIndex = All.FindIndex(item => item.Item1 == min && !item.Item3);
                if (matrix[minIndex, nextpoint] != 0 && All[minIndex].Item1 > All[nextpoint].Item1 && (All.Count - All.Count(item => item.Item3)) > 1) All[minIndex] = new Tuple<double, int, bool>(All[minIndex].Item1, nextpoint, true);
                else All[minIndex] = new Tuple<double, int, bool>(All[minIndex].Item1, All[minIndex].Item2, true);
                nextpoint = minIndex;

                if (All.Count == All.Count(item => item.Item3)) break;
            } while (true);
            
            for(int i = 0; i < n; i++)
            {
                if(i != firstpoint)
                {
                    listBox1.Items.Add("З " + (firstpoint + 1).ToString() + " вершини у " + (i + 1).ToString() + " становить - " + All[i].Item1.ToString());
                }
            }
            listBox1.Items.Add("--------------------------------------");
            listBox1.Items.Add("Вершини з'єднані таким чином:");
            listBox1.Items.Add("");
            for (int i = 0; i < n; i++)
            {
                if (i != firstpoint)
                {
                    listBox1.Items.Add((All[i].Item2 + 1).ToString() + " ---> " + (i + 1).ToString());
                }
            }
        }

        void Floida()
        {
            listBox1.Items.Clear();
            Read();
            double[,] D = new double[n, n];
            double[,] S = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        D[i, j] = -1;
                        S[i, j] = -1;
                    }
                    else if (matrix[i, j] == 0)
                    {
                        D[i, j] = 100000000000;
                        S[i, j] = j;
                    }
                    else
                    {
                        D[i, j] = matrix[i, j];
                        S[i, j] = j;
                    }
                }
            }

            for(int k = 0; k < n; k++)
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        if(i != j && j != k && i != k)
                        {
                            if (D[i,k] + D[k,j] < D[i, j])
                            {
                                D[i, j] = D[i, k] + D[k, j];
                                S[i, j] = k;
                            }
                        }
                    }
                }
            }

            Form2 form = new Form2(D, S, n);
            form.ShowDialog();
        }

        private void btnFloida_Click(object sender, EventArgs e)
        {
            Floida();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            CreateMatrixTest2();
        }

        private void btnDeikstru_Click(object sender, EventArgs e)
        {
            Deikstru();
        }
    }
}
