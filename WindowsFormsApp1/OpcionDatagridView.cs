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
    public partial class OpcionDatagridView : Form
    {
        public OpcionDatagridView()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dtregistro.Rows.Add(txtcedula.Text, txtnombre.Text, txtedad.Text);
            MessageBox.Show("Registro guardado Exitosamente");
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtedad.Text = "";
            txtcedula.Focus();

        }

        private void dtregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dtregistro.Rows[dtregistro.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dtregistro.Rows[dtregistro.CurrentRow.Index].Cells[1].Value.ToString();
            txtedad.Text = dtregistro.Rows[dtregistro.CurrentRow.Index].Cells[2].Value.ToString();

            dtregistro.Rows.RemoveAt(dtregistro.CurrentRow.Index);

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int fila = int.Parse(txtfila.Text);
            dtregistro.CurrentCell = dtregistro.Rows[(fila - 1)].Cells[0];


            DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminar?", "Validación de respuesta",
                
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes) {

                dtregistro.Rows.RemoveAt(dtregistro.CurrentRow.Index);
                txtfila.Text = "";
                txtfila.Focus();

            }

            else
            {
                txtfila.Focus();

             
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();

        }
    }
}
