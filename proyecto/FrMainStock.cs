using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FrMainStock : Form
    {


        public FrMainStock()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //se ulitiza para agregar productos con sus valores
            string nombre = Nombree.Text;
            int cantidad = 0;

            if (string.IsNullOrEmpty(Nombree.Text))
            {
                // El Nombre está vacío, mostrar aviso.
                MessageBox.Show("Debes ingresar un nombre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (decimal.TryParse(Precio.Text, out decimal precio))
            {

            }
            else if (string.IsNullOrEmpty(Precio.Text))
            {
                // El TextBox está vacío, mostrar aviso.
                MessageBox.Show("Debes ingresar un precio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // El valor ingresado no es un número decimal válido, mostrar aviso.
                MessageBox.Show("El precio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //proceso de introduccion de datos en la lista(reutilizable)
            if (int.TryParse(Cantidad.Text, out cantidad))
            {
                string producto = $" {nombre}   Cantidad:  {cantidad}  Precio:  ${precio} ";

                lstProductos.Items.Add(producto);

                LimpiarCampos();
            }
            else
                MessageBox.Show("ingrese una cantidad valida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void listProductos(object sender, EventArgs e)
        {

        }



        private void BBorrar_Click_1(object sender, EventArgs e)
        {
            //retira productos de la lista
            if (lstProductos.SelectedIndex != -1)
            {
                lstProductos.Items.RemoveAt(lstProductos.SelectedIndex);
                LimpiarCampos();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            Nombree.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";
            lstProductos.ClearSelected();
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nombree_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrMainStock_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //permite moverse entre interfaces
            this.Hide();
            FrPedidos z = new FrPedidos();
            z.Show();
            this.Hide();



        }
    }
}
