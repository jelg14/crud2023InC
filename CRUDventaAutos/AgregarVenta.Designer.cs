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
            SuspendLayout();
            // 
            // dtmFechaVenta
            // 
            dtmFechaVenta.Location = new Point(119, 70);
            dtmFechaVenta.Name = "dtmFechaVenta";
            dtmFechaVenta.Size = new Size(200, 23);
            dtmFechaVenta.TabIndex = 35;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(248, 99);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(101, 48);
            Agregar.TabIndex = 34;
            Agregar.Text = "Guardar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(119, 157);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 163);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 32;
            label4.Text = "Total de la venta";
            // 
            // txtIDcliente
            // 
            txtIDcliente.Location = new Point(119, 128);
            txtIDcliente.Name = "txtIDcliente";
            txtIDcliente.Size = new Size(121, 23);
            txtIDcliente.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 134);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 30;
            label3.Text = "ID Cliente";
            // 
            // txtIDauto
            // 
            txtIDauto.Location = new Point(119, 99);
            txtIDauto.Name = "txtIDauto";
            txtIDauto.Size = new Size(121, 23);
            txtIDauto.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 105);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 28;
            label2.Text = "ID automovil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 76);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 27;
            label1.Text = "Fecha de venta";
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(108, 15);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(54, 23);
            txtIDVenta.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 18);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 36;
            label5.Text = "ID de venta";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(249, 15);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 23);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(168, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
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
            button1.Location = new Point(359, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 40;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AgregarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 227);
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
            Name = "AgregarVenta";
            Text = "Operaciones de Venta";
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
    }
}