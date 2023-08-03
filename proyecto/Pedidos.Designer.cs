namespace proyecto
{
    partial class FrPedidos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Camp_Mesa_Dir = new System.Windows.Forms.TextBox();
            this.CampPreferencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CampCantidad = new System.Windows.Forms.TextBox();
            this.BAgregarPed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BBorrarPed = new System.Windows.Forms.Button();
            this.CampPedido = new System.Windows.Forms.TextBox();
            this.CampPrecio_Total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LstPedidos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Mesa/Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Preferencias";
            // 
            // Camp_Mesa_Dir
            // 
            this.Camp_Mesa_Dir.Location = new System.Drawing.Point(418, 384);
            this.Camp_Mesa_Dir.Name = "Camp_Mesa_Dir";
            this.Camp_Mesa_Dir.Size = new System.Drawing.Size(100, 20);
            this.Camp_Mesa_Dir.TabIndex = 56;
            // 
            // CampPreferencias
            // 
            this.CampPreferencias.Location = new System.Drawing.Point(286, 384);
            this.CampPreferencias.Name = "CampPreferencias";
            this.CampPreferencias.Size = new System.Drawing.Size(100, 20);
            this.CampPreferencias.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Precio Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Pedido";
            // 
            // CampCantidad
            // 
            this.CampCantidad.Location = new System.Drawing.Point(157, 384);
            this.CampCantidad.Name = "CampCantidad";
            this.CampCantidad.Size = new System.Drawing.Size(100, 20);
            this.CampCantidad.TabIndex = 51;
            // 
            // BAgregarPed
            // 
            this.BAgregarPed.BackColor = System.Drawing.Color.Blue;
            this.BAgregarPed.ForeColor = System.Drawing.Color.White;
            this.BAgregarPed.Location = new System.Drawing.Point(579, 410);
            this.BAgregarPed.Name = "BAgregarPed";
            this.BAgregarPed.Size = new System.Drawing.Size(75, 28);
            this.BAgregarPed.TabIndex = 46;
            this.BAgregarPed.Text = "agregar";
            this.BAgregarPed.UseVisualStyleBackColor = false;
            this.BAgregarPed.Click += new System.EventHandler(this.BAgregarPed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstPedidos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 341);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos";
            // 
            // BBorrarPed
            // 
            this.BBorrarPed.BackColor = System.Drawing.Color.Crimson;
            this.BBorrarPed.ForeColor = System.Drawing.Color.Transparent;
            this.BBorrarPed.Location = new System.Drawing.Point(12, 410);
            this.BBorrarPed.Name = "BBorrarPed";
            this.BBorrarPed.Size = new System.Drawing.Size(75, 28);
            this.BBorrarPed.TabIndex = 47;
            this.BBorrarPed.Text = "eliminar";
            this.BBorrarPed.UseVisualStyleBackColor = false;
            this.BBorrarPed.Click += new System.EventHandler(this.BBorrarPed_Click);
            // 
            // CampPedido
            // 
            this.CampPedido.Location = new System.Drawing.Point(25, 384);
            this.CampPedido.Name = "CampPedido";
            this.CampPedido.Size = new System.Drawing.Size(100, 20);
            this.CampPedido.TabIndex = 49;
            // 
            // CampPrecio_Total
            // 
            this.CampPrecio_Total.Location = new System.Drawing.Point(554, 384);
            this.CampPrecio_Total.Name = "CampPrecio_Total";
            this.CampPrecio_Total.Size = new System.Drawing.Size(100, 20);
            this.CampPrecio_Total.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 59;
            this.button1.Text = "Inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LstPedidos
            // 
            this.LstPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.LstPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPedidos.FormattingEnabled = true;
            this.LstPedidos.ItemHeight = 16;
            this.LstPedidos.Location = new System.Drawing.Point(3, 16);
            this.LstPedidos.Name = "LstPedidos";
            this.LstPedidos.Size = new System.Drawing.Size(794, 324);
            this.LstPedidos.TabIndex = 0;
            // 
            // FrPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Camp_Mesa_Dir);
            this.Controls.Add(this.CampPreferencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampCantidad);
            this.Controls.Add(this.BAgregarPed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BBorrarPed);
            this.Controls.Add(this.CampPedido);
            this.Controls.Add(this.CampPrecio_Total);
            this.Name = "FrPedidos";
            this.Text = "Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Camp_Mesa_Dir;
        private System.Windows.Forms.TextBox CampPreferencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampCantidad;
        private System.Windows.Forms.Button BAgregarPed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BBorrarPed;
        private System.Windows.Forms.TextBox CampPedido;
        private System.Windows.Forms.TextBox CampPrecio_Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LstPedidos;
    }
}