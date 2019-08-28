using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(txtCen.Text) * 1.8 + 32;
                    txtFar.Text = string.Format("{0:F2}", grados);
                }
                if (bandera == 2)
                {
                    grados = Convert.ToDouble(txtFar.Text) * 9 / 5 + 35;
                    txtCen.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (Exception)
            {
                txtCen.Text = "0.0";
                txtFar.Text = "32.00";
            }
        }

        private void TxtCen_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
        }
    }
}
