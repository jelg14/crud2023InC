namespace CRUDventaAutos
{
    partial class AgregarAutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            label2 = new Label();
            txtAnio = new TextBox();
            label3 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbEstado = new ComboBox();
            button2 = new Button();
            btnBuscar = new Button();
            btnEditar = new Button();
            txtIDAuto = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            label1.Click += label1_Click;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(115, 98);
            txtMarca.Margin = new Padding(4, 5, 4, 5);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(293, 31);
            txtMarca.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(117, 146);
            txtModelo.Margin = new Padding(4, 5, 4, 5);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(293, 31);
            txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(107, 194);
            txtAnio.Margin = new Padding(4, 5, 4, 5);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(96, 31);
            txtAnio.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 194);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(107, 243);
            txtColor.Margin = new Padding(4, 5, 4, 5);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(171, 31);
            txtColor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 243);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 6;
            label4.Text = "Color";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 291);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(171, 31);
            txtPrecio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 291);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 294);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Nuevo", "Usado" });
            cmbEstado.Location = new Point(372, 291);
            cmbEstado.Margin = new Padding(4, 5, 4, 5);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(171, 33);
            cmbEstado.TabIndex = 11;
            cmbEstado.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(512, 39);
            button2.Name = "button2";
            button2.Size = new Size(184, 34);
            button2.TabIndex = 47;
            button2.Text = "Cargar Imagen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(256, 38);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 46;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(372, 38);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 38);
            btnEditar.TabIndex = 45;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtIDAuto
            // 
            txtIDAuto.Location = new Point(170, 38);
            txtIDAuto.Margin = new Padding(4, 5, 4, 5);
            txtIDAuto.Name = "txtIDAuto";
            txtIDAuto.Size = new Size(75, 31);
            txtIDAuto.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 43);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 25);
            label7.TabIndex = 43;
            label7.Text = "ID de Auto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(512, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.No;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(638, 279);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 53);
            button1.TabIndex = 48;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(317, 188);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(144, 80);
            button3.TabIndex = 50;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AgregarAutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 347);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(txtIDAuto);
            Controls.Add(label7);
            Controls.Add(cmbEstado);
            Controls.Add(label6);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(txtAnio);
            Controls.Add(label3);
            Controls.Add(txtModelo);
            Controls.Add(label2);
            Controls.Add(txtMarca);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarAutos";
            Text = "AgregarAutos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private Label label2;
        private TextBox txtAnio;
        private Label label3;
        private TextBox txtColor;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private Label label6;
        private ComboBox cmbEstado;
        private Button button2;
        private Button btnBuscar;
        private Button btnEditar;
        private TextBox txtIDAuto;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
    }
}