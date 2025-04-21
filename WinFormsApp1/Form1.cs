using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Declarar las variables globales



        public Form1()
        {
            InitializeComponent();
            OcultarTodosLosPaneles();
            panelIngreso.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OcultarTodosLosPaneles()
        {
            panelIngreso.Visible = false;
            panelSalida.Visible = false;
            panelTabla.Visible = false;

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedItem.ToString() == "Otra")
            {
                txtOtraMarca.Enabled = true;  // Habilitar caja de texto
                txtOtraMarca.Focus();         // Poner el cursor en la caja de texto
            }
            else
            {
                txtOtraMarca.Enabled = false; // Deshabilitar la caja de texto si no es "Otra"
                txtOtraMarca.Text = "";       // Limpiar el texto
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            OcultarTodosLosPaneles();
            panelIngreso.Visible = true;

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            OcultarTodosLosPaneles();
            panelSalida.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=RegistroDiademas;Trusted_Connection=True;";

            DateTime fecha = dtpFecha.Value;
            int cantidad = (int)nudCantidad.Value;
            string marca;
            if (cmbMarca.SelectedItem?.ToString() == "Otra")
            {
                marca = txtOtraMarca.Text.Trim();

                if (string.IsNullOrWhiteSpace(marca))
                {
                    MessageBox.Show("Por favor específicar la marca en el campo adicional");
                    return;
                }
            }
            else
            {
                marca = cmbMarca.SelectedItem?.ToString() ?? "Sin marca";
            }
            string serial = txtSerial.Text.Trim();
            string estado = cmbEstado.SelectedItem?.ToString() ?? "Sin estado";

            if (string.IsNullOrWhiteSpace(serial))
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.");
                return;
            }

            dgvInventario.Rows.Add(fecha, cantidad, marca, serial, estado);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DiademasRegistro (Fecha, Cantidad, Marca, Serial, Estado) VALUES (@fecha, @cantidad, @marca, @serial, @estado)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@cantidad", cantidad);
                command.Parameters.AddWithValue("@marca", marca);
                command.Parameters.AddWithValue("@serial", serial);
                command.Parameters.AddWithValue("@estado", estado);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Diadema guardada con éxito");
            }


        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTablaRegistro_Click(object sender, EventArgs e)
        {
            OcultarTodosLosPaneles();
            panelTabla.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudCantidad.Value = 0;
            cmbMarca.Text = String.Empty;
            txtOtraMarca.Clear();
            txtSerial.Clear();
            cmbEstado.Text = String.Empty;

        }
    }
}
