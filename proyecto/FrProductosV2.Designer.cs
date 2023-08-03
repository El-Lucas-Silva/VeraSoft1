namespace proyecto
{
    partial class FrProductosV2
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
            this.ElDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ElBAgregar = new System.Windows.Forms.Button();
            this.ElBEliminar = new System.Windows.Forms.Button();
            this.ElCPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ElCAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ElCPreferencias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ElCMesaDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ElCPrecio = new System.Windows.Forms.TextBox();
            this.Pedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesaDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ElDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ElDGV
            // 
            this.ElDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ElDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElDGV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ElDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.ElDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedidos,
            this.Cantidad,
            this.Preferencia,
            this.MesaDireccion,
            this.Precio});
            this.ElDGV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ElDGV.Location = new System.Drawing.Point(24, 29);
            this.ElDGV.Name = "ElDGV";
            this.ElDGV.Size = new System.Drawing.Size(753, 282);
            this.ElDGV.TabIndex = 0;
            this.ElDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Pedidos.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ElBAgregar
            // 
            this.ElBAgregar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ElBAgregar.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElBAgregar.ForeColor = System.Drawing.Color.Green;
            this.ElBAgregar.Location = new System.Drawing.Point(619, 317);
            this.ElBAgregar.Name = "ElBAgregar";
            this.ElBAgregar.Size = new System.Drawing.Size(95, 46);
            this.ElBAgregar.TabIndex = 3;
            this.ElBAgregar.Text = "Agregar";
            this.ElBAgregar.UseVisualStyleBackColor = false;
            this.ElBAgregar.Click += new System.EventHandler(this.ElBAgregar_Click);
            // 
            // ElBEliminar
            // 
            this.ElBEliminar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ElBEliminar.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElBEliminar.ForeColor = System.Drawing.Color.Red;
            this.ElBEliminar.Location = new System.Drawing.Point(619, 369);
            this.ElBEliminar.Name = "ElBEliminar";
            this.ElBEliminar.Size = new System.Drawing.Size(95, 46);
            this.ElBEliminar.TabIndex = 4;
            this.ElBEliminar.Text = "Eliminar";
            this.ElBEliminar.UseVisualStyleBackColor = false;
            // 
            // ElCPedido
            // 
            this.ElCPedido.Location = new System.Drawing.Point(81, 343);
            this.ElCPedido.Name = "ElCPedido";
            this.ElCPedido.Size = new System.Drawing.Size(159, 20);
            this.ElCPedido.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // ElCAmount
            // 
            this.ElCAmount.Location = new System.Drawing.Point(252, 343);
            this.ElCAmount.Name = "ElCAmount";
            this.ElCAmount.Size = new System.Drawing.Size(159, 20);
            this.ElCAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preferencias";
            // 
            // ElCPreferencias
            // 
            this.ElCPreferencias.Location = new System.Drawing.Point(424, 343);
            this.ElCPreferencias.Name = "ElCPreferencias";
            this.ElCPreferencias.Size = new System.Drawing.Size(159, 20);
            this.ElCPreferencias.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mesa/Direccion";
            // 
            // ElCMesaDireccion
            // 
            this.ElCMesaDireccion.Location = new System.Drawing.Point(145, 395);
            this.ElCMesaDireccion.Name = "ElCMesaDireccion";
            this.ElCMesaDireccion.Size = new System.Drawing.Size(159, 20);
            this.ElCMesaDireccion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio";
            // 
            // ElCPrecio
            // 
            this.ElCPrecio.Location = new System.Drawing.Point(362, 395);
            this.ElCPrecio.Name = "ElCPrecio";
            this.ElCPrecio.Size = new System.Drawing.Size(159, 20);
            this.ElCPrecio.TabIndex = 14;
            // 
            // Pedidos
            // 
            this.Pedidos.HeaderText = "Pedidos";
            this.Pedidos.Name = "Pedidos";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Preferencia
            // 
            this.Preferencia.HeaderText = "Preferencia";
            this.Preferencia.Name = "Preferencia";
            // 
            // MesaDireccion
            // 
            this.MesaDireccion.HeaderText = "Mesa/Direccion";
            this.MesaDireccion.Name = "MesaDireccion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // FrProductosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ElCPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ElCMesaDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ElCPreferencias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElCAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ElCPedido);
            this.Controls.Add(this.ElBEliminar);
            this.Controls.Add(this.ElBAgregar);
            this.Controls.Add(this.ElDGV);
            this.Controls.Add(this.label1);
            this.Name = "FrProductosV2";
            this.Text = "FrProductosV2";
            ((System.ComponentModel.ISupportInitialize)(this.ElDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ElDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ElBAgregar;
        private System.Windows.Forms.Button ElBEliminar;
        private System.Windows.Forms.TextBox ElCPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ElCAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ElCPreferencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ElCMesaDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ElCPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesaDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}