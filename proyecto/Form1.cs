using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String datos = "";
            String Usuario = User.Text;
            String Contraseña = Contra.Text;

            String CadenaDatos = "Usuario" + User + "; password" + Contra + "; database=mysql;";

            MySqlConnection ConexionBD = new MySqlConnection(CadenaDatos);

            try
            {
                ConexionBD.Open();

                MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", ConexionBD);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            MessageBox.Show(datos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrMainStock frmS = new FrMainStock();
            frmS.Show();

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

