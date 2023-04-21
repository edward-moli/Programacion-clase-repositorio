namespace Proyecto0503
{
    partial class Form1
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
            this.dygProductos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lblinformacion = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dygProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dygProductos
            // 
            this.dygProductos.AllowUserToOrderColumns = true;
            this.dygProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dygProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.bombre,
            this.precio});
            this.dygProductos.Location = new System.Drawing.Point(3, 232);
            this.dygProductos.Name = "dygProductos";
            this.dygProductos.RowHeadersWidth = 51;
            this.dygProductos.RowTemplate.Height = 24;
            this.dygProductos.Size = new System.Drawing.Size(368, 206);
            this.dygProductos.TabIndex = 3;
            this.dygProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dygProductos_CellClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo  producto";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.Width = 125;
            // 
            // bombre
            // 
            this.bombre.HeaderText = "nombre producto";
            this.bombre.MinimumWidth = 6;
            this.bombre.Name = "bombre";
            this.bombre.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio producto";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(12, 15);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(49, 16);
            this.lblcodigo.TabIndex = 4;
            this.lblcodigo.Text = "codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(67, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.txtcodigo.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(67, 40);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 6;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(12, 72);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(45, 16);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "precio";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 46);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 16);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "nombre";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(67, 72);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 9;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(203, 11);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 10;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.Location = new System.Drawing.Point(101, 200);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(28, 16);
            this.lblinformacion.TabIndex = 11;
            this.lblinformacion.Text = "info";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(203, 46);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 12;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.lblinformacion);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.dygProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dygProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dygProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lblinformacion;
        private System.Windows.Forms.Button btnborrar;
    }
}

