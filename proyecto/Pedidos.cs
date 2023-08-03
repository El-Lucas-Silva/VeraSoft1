using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FrPedidos : Form
    {
        public FrPedidos()
        {
            InitializeComponent();
        }

        private void BAgregarPed_Click(object sender, EventArgs e)
        {
            //Asignacion de variables
            String Pedido = CampPedido.Text;
            int cantidad = 0;
            String Preferencias = CampPreferencias.Text;
            String Mesa_Dire = Camp_Mesa_Dir.Text;
            int PrecioTotal = 0;


            if (String.IsNullOrEmpty(CampPedido.Text))
            {
                //nombre del pedido vacio
                MessageBox.Show("Debes ingresar un pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            if (int.TryParse(CampCantidad.Text, out cantidad))
            {
                // La cantidad está vacía, mostrar aviso.
                MessageBox.Show("Debes ingresar una Cantidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(CampCantidad.Text))
            {
                // El valor ingresado no es un número válido, mostrar aviso.
                MessageBox.Show("La Cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (String.IsNullOrEmpty(CampPreferencias.Text))
            {
                MessageBox.Show("La Preferencia ingresada no es válida, si el cliente no tiene preferencias solo escriba N/A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (String.IsNullOrEmpty(Camp_Mesa_Dir.Text))
            {

            }

            //proceso de introduccion de datos en la lista
            if (int.TryParse(CampPrecio_Total.Text, out cantidad))
            {
                string Pedidos = $" {Pedido}   Cantidad:  {cantidad}  Precio:  ${PrecioTotal} ";

                LstPedidos.Items.Add(Pedidos);

                LimpiarCampos();
            }
            else
            {

            }




        }
        private void BBorrarPed_Click(object sender, EventArgs e)
        {
            // remueve pedidos
            if (LstPedidos.SelectedIndex != -1)
            {
                LstPedidos.Items.RemoveAt(LstPedidos.SelectedIndex);
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            //limpia los campos de texto
            CampPedido.Text = "";
            CampCantidad.Text = "";
            CampPrecio_Total.Text = "";
            CampPreferencias.Text = "";
            Camp_Mesa_Dir.Text = "";
            LstPedidos.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //al utilizar el  boton te envia al interface indicado
            this.Hide();
            FrMainStock frm = new FrMainStock();
            frm.Show();
            this.Hide();




        }

        private void LstPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
