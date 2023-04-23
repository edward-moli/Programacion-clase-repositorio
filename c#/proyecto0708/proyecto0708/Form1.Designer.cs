namespace proyecto0708
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtnodo = new System.Windows.Forms.TextBox();
            this.btnadicionanodo = new System.Windows.Forms.Button();
            this.btnadicionaelemento = new System.Windows.Forms.Button();
            this.btneleminarnodo = new System.Windows.Forms.Button();
            this.btnlipiaArbol = new System.Windows.Forms.Button();
            this.txteelemento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 29);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(136, 266);
            this.treeView1.TabIndex = 0;
            // 
            // txtnodo
            // 
            this.txtnodo.Location = new System.Drawing.Point(162, 29);
            this.txtnodo.Name = "txtnodo";
            this.txtnodo.Size = new System.Drawing.Size(100, 22);
            this.txtnodo.TabIndex = 1;
            // 
            // btnadicionanodo
            // 
            this.btnadicionanodo.Location = new System.Drawing.Point(324, 29);
            this.btnadicionanodo.Name = "btnadicionanodo";
            this.btnadicionanodo.Size = new System.Drawing.Size(126, 39);
            this.btnadicionanodo.TabIndex = 2;
            this.btnadicionanodo.Text = "adiciona nodo";
            this.btnadicionanodo.UseVisualStyleBackColor = true;
            this.btnadicionanodo.Click += new System.EventHandler(this.btnadicionanodo_Click);
            // 
            // btnadicionaelemento
            // 
            this.btnadicionaelemento.Location = new System.Drawing.Point(324, 74);
            this.btnadicionaelemento.Name = "btnadicionaelemento";
            this.btnadicionaelemento.Size = new System.Drawing.Size(127, 41);
            this.btnadicionaelemento.TabIndex = 3;
            this.btnadicionaelemento.Text = "adiciona elemento";
            this.btnadicionaelemento.UseVisualStyleBackColor = true;
            this.btnadicionaelemento.Click += new System.EventHandler(this.btnadicionaelemento_Click);
            // 
            // btneleminarnodo
            // 
            this.btneleminarnodo.Location = new System.Drawing.Point(325, 163);
            this.btneleminarnodo.Name = "btneleminarnodo";
            this.btneleminarnodo.Size = new System.Drawing.Size(126, 41);
            this.btneleminarnodo.TabIndex = 4;
            this.btneleminarnodo.Text = "elimina nodo";
            this.btneleminarnodo.UseVisualStyleBackColor = true;
            this.btneleminarnodo.Click += new System.EventHandler(this.btneleminarnodo_Click);
            // 
            // btnlipiaArbol
            // 
            this.btnlipiaArbol.Location = new System.Drawing.Point(324, 120);
            this.btnlipiaArbol.Name = "btnlipiaArbol";
            this.btnlipiaArbol.Size = new System.Drawing.Size(126, 37);
            this.btnlipiaArbol.TabIndex = 5;
            this.btnlipiaArbol.Text = "Limpia arbol";
            this.btnlipiaArbol.UseVisualStyleBackColor = true;
            this.btnlipiaArbol.Click += new System.EventHandler(this.btnlipiaArbol_Click);
            // 
            // txteelemento
            // 
            this.txteelemento.Location = new System.Drawing.Point(162, 57);
            this.txteelemento.Name = "txteelemento";
            this.txteelemento.Size = new System.Drawing.Size(100, 22);
            this.txteelemento.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txteelemento);
            this.Controls.Add(this.btnlipiaArbol);
            this.Controls.Add(this.btneleminarnodo);
            this.Controls.Add(this.btnadicionaelemento);
            this.Controls.Add(this.btnadicionanodo);
            this.Controls.Add(this.txtnodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtnodo;
        private System.Windows.Forms.Button btnadicionanodo;
        private System.Windows.Forms.Button btnadicionaelemento;
        private System.Windows.Forms.Button btneleminarnodo;
        private System.Windows.Forms.Button btnlipiaArbol;
        private System.Windows.Forms.TextBox txteelemento;
    }
}

