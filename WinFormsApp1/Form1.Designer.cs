namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tituloRegistro = new Label();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            fecha = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            marca = new Label();
            cmbMarca = new ComboBox();
            txtOtraMarca = new TextBox();
            lblSerial = new Label();
            textBox1 = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tituloRegistro
            // 
            tituloRegistro.Anchor = AnchorStyles.Top;
            tituloRegistro.AutoSize = true;
            tituloRegistro.BackColor = SystemColors.Window;
            tituloRegistro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloRegistro.ForeColor = Color.Navy;
            tituloRegistro.Location = new Point(283, 66);
            tituloRegistro.Name = "tituloRegistro";
            tituloRegistro.Size = new Size(253, 30);
            tituloRegistro.TabIndex = 0;
            tituloRegistro.Text = "REGISTRO DE DIADEMAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(336, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(226, 155);
            fecha.Name = "fecha";
            fecha.Size = new Size(49, 15);
            fecha.TabIndex = 3;
            fecha.Text = "FECHA: ";
            fecha.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 203);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "CANTIDAD:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(336, 201);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // marca
            // 
            marca.AutoSize = true;
            marca.Location = new Point(226, 256);
            marca.Name = "marca";
            marca.Size = new Size(52, 15);
            marca.TabIndex = 6;
            marca.Text = "MARCA:";
            // 
            // cmbMarca
            // 
            cmbMarca.DisplayMember = "Seleccione";
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "Marca1", "Marca2", "Marca3", "Marca4", "Marca5", "Otra" });
            cmbMarca.Location = new Point(336, 253);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(200, 23);
            cmbMarca.TabIndex = 7;
            cmbMarca.Text = "Seleccione";
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // txtOtraMarca
            // 
            txtOtraMarca.Enabled = false;
            txtOtraMarca.Location = new Point(336, 282);
            txtOtraMarca.Name = "txtOtraMarca";
            txtOtraMarca.Size = new Size(200, 23);
            txtOtraMarca.TabIndex = 8;
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(226, 346);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(49, 15);
            lblSerial.TabIndex = 9;
            lblSerial.Text = "SERIAL:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(226, 398);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(55, 15);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Nueva", "Usado-Bueno", "Dañado" });
            cmbEstado.Location = new Point(336, 390);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 23);
            cmbEstado.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 513);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(textBox1);
            Controls.Add(lblSerial);
            Controls.Add(txtOtraMarca);
            Controls.Add(cmbMarca);
            Controls.Add(marca);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(fecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(tituloRegistro);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloRegistro;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label fecha;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label marca;
        private ComboBox cmbMarca;
        private TextBox txtOtraMarca;
        private Label lblSerial;
        private TextBox textBox1;
        private Label lblEstado;
        private ComboBox cmbEstado;
    }
}
