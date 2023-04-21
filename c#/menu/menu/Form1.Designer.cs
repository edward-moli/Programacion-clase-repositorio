namespace menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.CmenutxtA = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.tstOperaciones = new System.Windows.Forms.ToolStrip();
            this.tstbSuma = new System.Windows.Forms.ToolStripButton();
            this.tstresta = new System.Windows.Forms.ToolStripButton();
            this.tstmulti = new System.Windows.Forms.ToolStripButton();
            this.tstdivision = new System.Windows.Forms.ToolStripButton();
            this.stsinformacion = new System.Windows.Forms.StatusStrip();
            this.slblvalores = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbloperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblresultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.CmenutxtA.SuspendLayout();
            this.tstOperaciones.SuspendLayout();
            this.stsinformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operaionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.ToolTipText = "\r\n";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AutoToolTip = true;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Quitar la aplicacion";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operaionesToolStripMenuItem
            // 
            this.operaionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.operaionesToolStripMenuItem.Name = "operaionesToolStripMenuItem";
            this.operaionesToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.operaionesToolStripMenuItem.Text = "Operaiones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.restaToolStripMenuItem.Text = "resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.multiplicacionToolStripMenuItem.Text = "multiplicacion";
            this.multiplicacionToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.divisionToolStripMenuItem.Text = "division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.ayudaToolStripMenuItem.Text = "ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.acercaDeToolStripMenuItem.Text = "acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.CmenutxtA;
            this.txtA.Location = new System.Drawing.Point(0, 69);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CmenutxtA
            // 
            this.CmenutxtA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmenutxtA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.aleatorioToolStripMenuItem});
            this.CmenutxtA.Name = "CmenutxtA";
            this.CmenutxtA.Size = new System.Drawing.Size(141, 52);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.borrarToolStripMenuItem.Text = "borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(0, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(12, 132);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(63, 16);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "resultado";
            // 
            // tstOperaciones
            // 
            this.tstOperaciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tstOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbSuma,
            this.tstresta,
            this.tstmulti,
            this.tstdivision});
            this.tstOperaciones.Location = new System.Drawing.Point(0, 28);
            this.tstOperaciones.Name = "tstOperaciones";
            this.tstOperaciones.Size = new System.Drawing.Size(453, 27);
            this.tstOperaciones.TabIndex = 5;
            this.tstOperaciones.Text = "toolStrip1";
            // 
            // tstbSuma
            // 
            this.tstbSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbSuma.Image = ((System.Drawing.Image)(resources.GetObject("tstbSuma.Image")));
            this.tstbSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbSuma.Name = "tstbSuma";
            this.tstbSuma.Size = new System.Drawing.Size(29, 24);
            this.tstbSuma.Text = "suma";
            this.tstbSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // tstresta
            // 
            this.tstresta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstresta.Image = ((System.Drawing.Image)(resources.GetObject("tstresta.Image")));
            this.tstresta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstresta.Name = "tstresta";
            this.tstresta.Size = new System.Drawing.Size(29, 28);
            this.tstresta.Text = "resta";
            this.tstresta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // tstmulti
            // 
            this.tstmulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstmulti.Image = ((System.Drawing.Image)(resources.GetObject("tstmulti.Image")));
            this.tstmulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstmulti.Name = "tstmulti";
            this.tstmulti.Size = new System.Drawing.Size(29, 28);
            this.tstmulti.Text = "nultiplicacion";
            this.tstmulti.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // tstdivision
            // 
            this.tstdivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstdivision.Image = ((System.Drawing.Image)(resources.GetObject("tstdivision.Image")));
            this.tstdivision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstdivision.Name = "tstdivision";
            this.tstdivision.Size = new System.Drawing.Size(29, 28);
            this.tstdivision.Text = "dividir";
            this.tstdivision.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // stsinformacion
            // 
            this.stsinformacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsinformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblvalores,
            this.slbloperacion,
            this.slblresultado});
            this.stsinformacion.Location = new System.Drawing.Point(0, 320);
            this.stsinformacion.Name = "stsinformacion";
            this.stsinformacion.Size = new System.Drawing.Size(453, 30);
            this.stsinformacion.TabIndex = 6;
            this.stsinformacion.Text = "statusStrip1";
            // 
            // slblvalores
            // 
            this.slblvalores.AutoSize = false;
            this.slblvalores.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblvalores.Name = "slblvalores";
            this.slblvalores.Size = new System.Drawing.Size(100, 24);
            this.slblvalores.Text = "A=0,B=0";
            // 
            // slbloperacion
            // 
            this.slbloperacion.AutoSize = false;
            this.slbloperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slbloperacion.Name = "slbloperacion";
            this.slbloperacion.Size = new System.Drawing.Size(90, 24);
            this.slbloperacion.Text = "Sin selccionar";
            // 
            // slblresultado
            // 
            this.slblresultado.AutoSize = false;
            this.slblresultado.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblresultado.Name = "slblresultado";
            this.slblresultado.Size = new System.Drawing.Size(50, 24);
            this.slblresultado.Text = "R=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 350);
            this.Controls.Add(this.stsinformacion);
            this.Controls.Add(this.tstOperaciones);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CmenutxtA.ResumeLayout(false);
            this.tstOperaciones.ResumeLayout(false);
            this.tstOperaciones.PerformLayout();
            this.stsinformacion.ResumeLayout(false);
            this.stsinformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CmenutxtA;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tstOperaciones;
        private System.Windows.Forms.ToolStripButton tstbSuma;
        private System.Windows.Forms.ToolStripButton tstresta;
        private System.Windows.Forms.ToolStripButton tstmulti;
        private System.Windows.Forms.ToolStripButton tstdivision;
        private System.Windows.Forms.StatusStrip stsinformacion;
        private System.Windows.Forms.ToolStripStatusLabel slblvalores;
        private System.Windows.Forms.ToolStripStatusLabel slbloperacion;
        private System.Windows.Forms.ToolStripStatusLabel slblresultado;
    }
}

