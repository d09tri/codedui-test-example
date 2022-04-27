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
    public partial class FrmCalculator : Form
    {
        Calculator cal = new Calculator();

        public FrmCalculator()
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

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (pnlMain.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text) && t != txtResullt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cal.Num1 = float.Parse(txtNum1.Text);
            cal.Num2 = float.Parse(txtNum2.Text);

            txtResullt.Text = cal.Addition().ToString();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation(sender, e);

        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidation(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
