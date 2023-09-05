namespace CRUD2023
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            agregarAlumnoToolStripMenuItem = new ToolStripMenuItem();
            buscarAlumnoToolStripMenuItem = new ToolStripMenuItem();
            editarAlumnoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(610, 215);
            dataGridView1.TabIndex = 0;
            dataGridView1.KeyPress += dataGridView1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(300, 343);
            button1.Name = "button1";
            button1.Size = new Size(225, 55);
            button1.TabIndex = 1;
            button1.Text = "Guardar Información";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarAlumnoToolStripMenuItem, buscarAlumnoToolStripMenuItem, editarAlumnoToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            opcionesToolStripMenuItem.Click += opcionesToolStripMenuItem_Click;
            // 
            // agregarAlumnoToolStripMenuItem
            // 
            agregarAlumnoToolStripMenuItem.Name = "agregarAlumnoToolStripMenuItem";
            agregarAlumnoToolStripMenuItem.Size = new Size(162, 22);
            agregarAlumnoToolStripMenuItem.Text = "Agregar Alumno";
            agregarAlumnoToolStripMenuItem.Click += agregarAlumnoToolStripMenuItem_Click;
            // 
            // buscarAlumnoToolStripMenuItem
            // 
            buscarAlumnoToolStripMenuItem.Name = "buscarAlumnoToolStripMenuItem";
            buscarAlumnoToolStripMenuItem.Size = new Size(162, 22);
            buscarAlumnoToolStripMenuItem.Text = "Buscar Alumno";
            buscarAlumnoToolStripMenuItem.Click += buscarAlumnoToolStripMenuItem_Click;
            // 
            // editarAlumnoToolStripMenuItem
            // 
            editarAlumnoToolStripMenuItem.Name = "editarAlumnoToolStripMenuItem";
            editarAlumnoToolStripMenuItem.Size = new Size(162, 22);
            editarAlumnoToolStripMenuItem.Text = "Editar Alumno";
            editarAlumnoToolStripMenuItem.Click += editarAlumnoToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem agregarAlumnoToolStripMenuItem;
        private ToolStripMenuItem buscarAlumnoToolStripMenuItem;
        private ToolStripMenuItem editarAlumnoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}