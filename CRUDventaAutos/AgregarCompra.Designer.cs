﻿namespace CRUDventaAutos
{
    partial class AgregarCompra
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
            Agregar = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // Agregar
            // 
            Agregar.Location = new Point(136, 142);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(105, 42);
            Agregar.TabIndex = 25;
            Agregar.Text = "button1";
            Agregar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(120, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 19;
            label4.Text = "Precio de Compra";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 17;
            label3.Text = "ID auto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 15;
            label2.Text = "ID proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 13;
            label1.Text = "Fecha de compra";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // AgregarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 218);
            Controls.Add(dateTimePicker1);
            Controls.Add(Agregar);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarCompra";
            Text = "AgregarCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Agregar;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}