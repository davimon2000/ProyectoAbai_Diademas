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
            dtpFecha = new DateTimePicker();
            fecha = new Label();
            label1 = new Label();
            nudCantidad = new NumericUpDown();
            marca = new Label();
            cmbMarca = new ComboBox();
            txtOtraMarca = new TextBox();
            lblSerial = new Label();
            txtSerial = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            panelIngreso = new Panel();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            panelSalida = new Panel();
            btnIngreso = new Button();
            btnSalida = new Button();
            panelTabla = new Panel();
            txtDiademasRegistradas = new TextBox();
            dgvInventario = new DataGridView();
            clmFecha = new DataGridViewTextBoxColumn();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmMarca = new DataGridViewTextBoxColumn();
            clmSerial = new DataGridViewTextBoxColumn();
            clmEstado = new DataGridViewTextBoxColumn();
            btnTablaRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panelIngreso.SuspendLayout();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // tituloRegistro
            // 
            tituloRegistro.Anchor = AnchorStyles.Top;
            tituloRegistro.AutoSize = true;
            tituloRegistro.BackColor = SystemColors.Window;
            tituloRegistro.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloRegistro.ForeColor = Color.Navy;
            tituloRegistro.Location = new Point(91, 20);
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
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Location = new Point(153, 107);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(44, 107);
            fecha.Name = "fecha";
            fecha.Size = new Size(49, 15);
            fecha.TabIndex = 3;
            fecha.Text = "FECHA: ";
            fecha.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 193);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "CANTIDAD:";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(154, 185);
            nudCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(200, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // marca
            // 
            marca.AutoSize = true;
            marca.Location = new Point(44, 267);
            marca.Name = "marca";
            marca.Size = new Size(52, 15);
            marca.TabIndex = 6;
            marca.Text = "MARCA:";
            // 
            // cmbMarca
            // 
            cmbMarca.DisplayMember = "Seleccione";
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "PRACTICA", "XKIM", "SE200U", "LOGITECH", "JABRA BIZ", "JABRA GN", "Otra" });
            cmbMarca.Location = new Point(154, 264);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(200, 23);
            cmbMarca.TabIndex = 7;
            cmbMarca.Text = "Seleccione";
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // txtOtraMarca
            // 
            txtOtraMarca.Enabled = false;
            txtOtraMarca.Location = new Point(154, 293);
            txtOtraMarca.Name = "txtOtraMarca";
            txtOtraMarca.Size = new Size(200, 23);
            txtOtraMarca.TabIndex = 8;
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(44, 367);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(49, 15);
            lblSerial.TabIndex = 9;
            lblSerial.Text = "SERIAL:";
            // 
            // txtSerial
            // 
            txtSerial.Location = new Point(154, 359);
            txtSerial.Name = "txtSerial";
            txtSerial.Size = new Size(199, 23);
            txtSerial.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(44, 441);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(55, 15);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "ESTADO:";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Buena", "Dañado", "Disponible" });
            cmbEstado.Location = new Point(154, 433);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(200, 23);
            cmbEstado.TabIndex = 12;
            // 
            // panelIngreso
            // 
            panelIngreso.Controls.Add(btnLimpiar);
            panelIngreso.Controls.Add(btnRegistrar);
            panelIngreso.Controls.Add(tituloRegistro);
            panelIngreso.Controls.Add(cmbEstado);
            panelIngreso.Controls.Add(dtpFecha);
            panelIngreso.Controls.Add(lblEstado);
            panelIngreso.Controls.Add(fecha);
            panelIngreso.Controls.Add(txtSerial);
            panelIngreso.Controls.Add(label1);
            panelIngreso.Controls.Add(lblSerial);
            panelIngreso.Controls.Add(nudCantidad);
            panelIngreso.Controls.Add(txtOtraMarca);
            panelIngreso.Controls.Add(marca);
            panelIngreso.Controls.Add(cmbMarca);
            panelIngreso.Location = new Point(183, 87);
            panelIngreso.Name = "panelIngreso";
            panelIngreso.Size = new Size(427, 585);
            panelIngreso.TabIndex = 13;
            panelIngreso.Paint += panel1_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ButtonShadow;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(44, 500);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(135, 33);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.MediumAquamarine;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(214, 498);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 33);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // panelSalida
            // 
            panelSalida.Location = new Point(136, 678);
            panelSalida.Name = "panelSalida";
            panelSalida.Size = new Size(524, 409);
            panelSalida.TabIndex = 13;
            panelSalida.Visible = false;
            // 
            // btnIngreso
            // 
            btnIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngreso.Location = new Point(711, 156);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(89, 29);
            btnIngreso.TabIndex = 14;
            btnIngreso.Text = "Ingreso";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // btnSalida
            // 
            btnSalida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalida.Location = new Point(711, 203);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(89, 29);
            btnSalida.TabIndex = 15;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(txtDiademasRegistradas);
            panelTabla.Controls.Add(dgvInventario);
            panelTabla.Location = new Point(76, 90);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(658, 261);
            panelTabla.TabIndex = 16;
            // 
            // txtDiademasRegistradas
            // 
            txtDiademasRegistradas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiademasRegistradas.Location = new Point(212, 15);
            txtDiademasRegistradas.Name = "txtDiademasRegistradas";
            txtDiademasRegistradas.Size = new Size(244, 33);
            txtDiademasRegistradas.TabIndex = 1;
            txtDiademasRegistradas.Text = "DIADEMAS REGISTRADAS";
            // 
            // dgvInventario
            // 
            dgvInventario.BackgroundColor = SystemColors.Control;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { clmFecha, clmCantidad, clmMarca, clmSerial, clmEstado });
            dgvInventario.Location = new Point(22, 54);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(593, 201);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "Fecha";
            clmFecha.Name = "clmFecha";
            // 
            // clmCantidad
            // 
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.Name = "clmCantidad";
            // 
            // clmMarca
            // 
            clmMarca.HeaderText = "Marca";
            clmMarca.Name = "clmMarca";
            // 
            // clmSerial
            // 
            clmSerial.HeaderText = "Serial";
            clmSerial.Name = "clmSerial";
            // 
            // clmEstado
            // 
            clmEstado.HeaderText = "Estado";
            clmEstado.Name = "clmEstado";
            // 
            // btnTablaRegistro
            // 
            btnTablaRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTablaRegistro.Location = new Point(711, 249);
            btnTablaRegistro.Name = "btnTablaRegistro";
            btnTablaRegistro.Size = new Size(89, 28);
            btnTablaRegistro.TabIndex = 18;
            btnTablaRegistro.Text = "Tabla Registro";
            btnTablaRegistro.UseVisualStyleBackColor = true;
            btnTablaRegistro.Click += btnTablaRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 749);
            Controls.Add(btnSalida);
            Controls.Add(btnIngreso);
            Controls.Add(btnTablaRegistro);
            Controls.Add(panelTabla);
            Controls.Add(panelIngreso);
            Controls.Add(pictureBox1);
            Controls.Add(panelSalida);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panelIngreso.ResumeLayout(false);
            panelIngreso.PerformLayout();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);



        }

        #endregion

        private Label tituloRegistro;
        private PictureBox pictureBox1;
        private DateTimePicker dtpFecha;
        private Label fecha;
        private Label label1;
        private NumericUpDown nudCantidad;
        private Label label2;
        private Label marca;
        private ComboBox cmbMarca;
        private TextBox txtOtraMarca;
        private Label lblSerial;
        private TextBox txtSerial;
        private Label lblEstado;
        private ComboBox cmbEstado;
        private Panel panelIngreso;
        private Panel panelSalida;
        private Button btnIngreso;
        private Button btnSalida;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Panel panelTabla;
        private DataGridView dgvInventario;
        private TextBox txtDiademasRegistradas;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmMarca;
        private DataGridViewTextBoxColumn clmSerial;
        private DataGridViewTextBoxColumn clmEstado;
        private Button btnTablaRegistro;
    }
}
