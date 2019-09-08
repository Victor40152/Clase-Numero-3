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
    public partial class OpcionGroupBox : Form
    {
        public OpcionGroupBox()
        {
            InitializeComponent();
        }

        private void gbgenero_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = true;
            gbnacionalidad.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = false;
            gbnacionalidad.Visible = true;

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
            this.Dispose();

        }
    }
}
