namespace programa0805
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVentana1ToolStripMenuItem,
            this.adicionarVentana2ToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // adicionarVentana1ToolStripMenuItem
            // 
            this.adicionarVentana1ToolStripMenuItem.Name = "adicionarVentana1ToolStripMenuItem";
            this.adicionarVentana1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adicionarVentana1ToolStripMenuItem.Text = "Adicionar ventana1";
            this.adicionarVentana1ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana1ToolStripMenuItem_Click);
            // 
            // adicionarVentana2ToolStripMenuItem
            // 
            this.adicionarVentana2ToolStripMenuItem.Name = "adicionarVentana2ToolStripMenuItem";
            this.adicionarVentana2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adicionarVentana2ToolStripMenuItem.Text = "Adicionar ventana2";
            this.adicionarVentana2ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 350);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

