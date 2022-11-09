using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMultiplication
{
    public partial class MatrixMultiplication : Form
    {
        private int N;
        private int P;
        Multiplication multiplication;
        public MatrixMultiplication()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (parseValues())
            {
                multiplication = new Multiplication(N, dgvMatrixA, dgvMatrixB, dgvMatrixC);
                multiplication.Create();
            }
        }

        private bool parseValues()
        {
            return int.TryParse(tbN.Text, out N) && int.TryParse(tbProc.Text, out P);
        }
        

        //
        // universal for matrix NxN
        //
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doMultiplication();
        }


        private void btnMultParCSOpt_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doParralellForMultiplication();
        }


        //
        // Test 4x4
        //
        private void btnCreateTestMatrix_Click(object sender, EventArgs e)
        {
            if (parseValues())
            {
                multiplication = new Multiplication(N, dgvMatrixA, dgvMatrixB, dgvMatrixC);
                multiplication.CreateTest();
            }
        }

        private void btnCannonMultiplication_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doMultiplicationCannon();
        }

        private void btrnCannonNonCreate_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doMultiplicationCannonNonCreateMatr();
        }

        private void btnMultParCannon_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doParralelCannon(P);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            multiplication.Show();
        }

        private void tbProc_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbProc.Text, out P);
        }

        private void btnMultParCannonOther_Click(object sender, EventArgs e)
        {
            lblTime.Text = multiplication.doParralelCannonOther(P);
        }
    }
}
