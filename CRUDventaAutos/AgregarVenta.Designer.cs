namespace CRUDventaAutos
{
    partial class AgregarVenta
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
            dtmFechaVenta = new DateTimePicker();
            Agregar = new Button();
            txtTotal = new TextBox();
            label4 = new Label();
            txtIDcliente = new TextBox();
            label3 = new Label();
            txtIDauto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtIDVenta = new TextBox();
            label5 = new Label();
            btnEditar = new Button();
            btnBuscar = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtmFechaVenta
            // 
            dtmFechaVenta.Location = new Point(170, 117);
            dtmFechaVenta.Margin = new Padding(4, 5, 4, 5);
            dtmFechaVenta.Name = "dtmFechaVenta";
            dtmFechaVenta.Size = new Size(284, 31);
            dtmFechaVenta.TabIndex = 35;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(368, 175);
            Agregar.Margin = new Padding(4, 5, 4, 5);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(144, 80);
            Agregar.TabIndex = 34;
            Agregar.Text = "Guardar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(170, 262);
            txtTotal.Margin = new Padding(4, 5, 4, 5);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(171, 31);
            txtTotal.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 272);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 32;
            label4.Text = "Total de la venta";
            // 
            // txtIDcliente
            // 
            txtIDcliente.Location = new Point(170, 213);
            txtIDcliente.Margin = new Padding(4, 5, 4, 5);
            txtIDcliente.Name = "txtIDcliente";
            txtIDcliente.Size = new Size(171, 31);
            txtIDcliente.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 30;
            label3.Text = "ID Cliente";
            // 
            // txtIDauto
            // 
            txtIDauto.Location = new Point(170, 165);
            txtIDauto.Margin = new Padding(4, 5, 4, 5);
            txtIDauto.Name = "txtIDauto";
            txtIDauto.Size = new Size(171, 31);
            txtIDauto.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 175);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 28;
            label2.Text = "ID automovil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 27;
            label1.Text = "Fecha de venta";
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(154, 25);
            txtIDVenta.Margin = new Padding(4, 5, 4, 5);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(75, 31);
            txtIDVenta.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 36;
            label5.Text = "ID de Venta";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(356, 25);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(113, 38);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(240, 25);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 38);
            btnBuscar.TabIndex = 39;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.No;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(585, 229);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 53);
            button1.TabIndex = 40;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(537, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(537, 26);
            button2.Name = "button2";
            button2.Size = new Size(184, 34);
            button2.TabIndex = 42;
            button2.Text = "Cargar Imagen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 325);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(txtIDVenta);
            Controls.Add(label5);
            Controls.Add(dtmFechaVenta);
            Controls.Add(Agregar);
            Controls.Add(txtTotal);
            Controls.Add(label4);
            Controls.Add(txtIDcliente);
            Controls.Add(label3);
            Controls.Add(txtIDauto);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarVenta";
            Text = "Operaciones de Venta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtmFechaVenta;
        private Button Agregar;
        private TextBox txtTotal;
        private Label label4;
        private TextBox txtIDcliente;
        private Label label3;
        private TextBox txtIDauto;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtIDVenta;
        private Label label5;
        private Button btnEditar;
        private Button btnBuscar;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
    }
}