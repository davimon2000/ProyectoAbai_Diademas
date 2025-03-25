namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Declarar las variables globales
        
        

        public Form1()
        {
            InitializeComponent();
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
    }
}
