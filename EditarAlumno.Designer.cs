namespace CRUD2023
{
    partial class EditarAlumno
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
            txtTelefonoCasa = new TextBox();
            label7 = new Label();
            txtCelular = new TextBox();
            label6 = new Label();
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label2 = new Label();
            txtCarne = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCargar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTelefonoCasa
            // 
            txtTelefonoCasa.Location = new Point(175, 325);
            txtTelefonoCasa.Name = "txtTelefonoCasa";
            txtTelefonoCasa.Size = new Size(175, 23);
            txtTelefonoCasa.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 325);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 26;
            label7.Text = "Telefono Casa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(175, 271);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(175, 23);
            txtCelular.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 271);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 24;
            label6.Text = "Celular";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(175, 224);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(175, 23);
            txtSegundoApellido.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 224);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 22;
            label5.Text = "Segundo Apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(175, 175);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(175, 23);
            txtPrimerApellido.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 175);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 20;
            label4.Text = "Primer Apellido";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(175, 130);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(175, 23);
            txtSegundoNombre.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 130);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 18;
            label3.Text = "Segundo Nombre";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(175, 85);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(175, 23);
            txtPrimerNombre.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 16;
            label2.Text = "Primer Nombre";
            // 
            // txtCarne
            // 
            txtCarne.Location = new Point(175, 37);
            txtCarne.Name = "txtCarne";
            txtCarne.Size = new Size(175, 23);
            txtCarne.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "Carne";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(425, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 23);
            btnBuscar.TabIndex = 28;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(425, 66);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 23);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(425, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(425, 130);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(123, 23);
            btnCargar.TabIndex = 31;
            btnCargar.Text = "Cargar Imagen";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(383, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 169);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // EditarAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 404);
            Controls.Add(pictureBox1);
            Controls.Add(btnCargar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(txtTelefonoCasa);
            Controls.Add(label7);
            Controls.Add(txtCelular);
            Controls.Add(label6);
            Controls.Add(txtSegundoApellido);
            Controls.Add(label5);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label4);
            Controls.Add(txtSegundoNombre);
            Controls.Add(label3);
            Controls.Add(txtPrimerNombre);
            Controls.Add(label2);
            Controls.Add(txtCarne);
            Controls.Add(label1);
            Name = "EditarAlumno";
            Text = "EditarAlumno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefonoCasa;
        private Label label7;
        private TextBox txtCelular;
        private Label label6;
        private TextBox txtSegundoApellido;
        private Label label5;
        private TextBox txtPrimerApellido;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label2;
        private TextBox txtCarne;
        private Label label1;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCargar;
        private PictureBox pictureBox1;
    }
}