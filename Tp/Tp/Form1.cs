using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtLimp_Click(object sender, EventArgs e)
        {
            //boton de limpiar
            txtN.Clear();
            txtP.Clear();
            lbl1.Text = "0";
            lbl2.Text = " ";
        }

        private void BtCarg_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3;//variables
            try//correccion de errores
            {
                numero1 = int.Parse(txtN.Text);
                numero3 = numero1;
                numero2 = int.Parse(txtP.Text);
                for (int i = 1; i < numero2; i++)
                {
                    numero1 = numero1 * numero3;
                }
                lbl1.Text = numero1.ToString();
            }
            catch (Exception error)
            {
                lbl2.Text = error.Message;
                lbl2.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
