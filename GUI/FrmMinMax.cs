using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMinMax : Form
    {
        public FrmMinMax()
        {
            InitializeComponent();
        }

        private void InputValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private int FindMin(int numA, int numB)
        {
            return (numA > numB) ? numB : numA;
        }

        private int FindMax(int numA, int numB)
        {
            return (numA > numB) ? numA : numB;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numA = int.Parse(txtNumA.Text);
            int numB = int.Parse(txtNumB.Text);
            int numC = int.Parse(txtNumC.Text);

            int max = FindMax(numA, FindMax(numB, numC));
            int min = FindMin(numA, FindMin(numB, numC));

            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation(sender, e);
        }
    }
}
