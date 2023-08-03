using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FrProductosV2 : Form
    {
        public FrProductosV2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ElDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ElBAgregar_Click(object sender, EventArgs e)
        {
            int Cantidad = 0;
            //Agrega nuevos productos
            int n = ElDGV.Rows.Add();

            //Agrega la informacion de los antes mencionados
            ElDGV.Rows[n].Cells[0].Value = ElCPedido.Text;
            ElDGV.Rows[n].Cells[0].Value = ElCAmount.Text;
            ElDGV.Rows[n].Cells[0].Value = ElCPreferencias.Text;
            ElDGV.Rows[n].Cells[0].Value = ElCMesaDireccion.Text;
            ElDGV.Rows[n].Cells[0].Value = ElCPrecio.Text;

            //Limpieza de campos de texto
            ElCPedido.Text = "";
            ElCAmount.Text = "";
            ElCPreferencias.Text = "";
            ElCMesaDireccion.Text = "";
            ElCPrecio.Text = "";

            if (String.IsNullOrEmpty(ElCPedido.Text))
            {
                //nombre del pedido vacio
                MessageBox.Show("Debes ingresar un pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (String.IsNullOrEmpty(ElCAmount.Text))
            {
                //nombre del pedido vacio
                MessageBox.Show("Debes ingresar una cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(ElCAmount.Text))
            {
                // El valor ingresado no es un número válido, mostrar aviso.
                MessageBox.Show("La Cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(ElCPreferencias.Text))

            {
                MessageBox.Show("La Preferencia ingresada no es válida, si el cliente no tiene preferencias solo escriba N/A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (String.IsNullOrEmpty(ElCMesaDireccion.Text))
            {

            }
        }
    }
}
