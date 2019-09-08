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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pgbcargainicial.Value < 100) {

                pgbcargainicial.Value++;

                label1.Text = "Cargando"  + pgbcargainicial.Value.ToString() +  "%";

            }


            else
            {
                timer1.Stop();
                //MessageBox.Show("El ProgressBar ya está completado");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }


        }
    }
}
