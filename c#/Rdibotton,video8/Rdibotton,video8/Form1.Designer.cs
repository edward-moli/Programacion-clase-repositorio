namespace Rdibotton_video8
{
    partial class Gboxoperaciones
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.gboxoperacion = new System.Windows.Forms.GroupBox();
            this.rbsuma = new System.Windows.Forms.RadioButton();
            this.rbresta = new System.Windows.Forms.RadioButton();
            this.rbmultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbdivicion = new System.Windows.Forms.RadioButton();
            this.lblresultado = new System.Windows.Forms.Label();
            this.gboxoperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(125, 12);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(0, 22);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(0, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gboxoperacion
            // 
            this.gboxoperacion.Controls.Add(this.rbdivicion);
            this.gboxoperacion.Controls.Add(this.rbmultiplicacion);
            this.gboxoperacion.Controls.Add(this.rbresta);
            this.gboxoperacion.Controls.Add(this.rbsuma);
            this.gboxoperacion.Location = new System.Drawing.Point(0, 118);
            this.gboxoperacion.Name = "gboxoperacion";
            this.gboxoperacion.Size = new System.Drawing.Size(200, 130);
            this.gboxoperacion.TabIndex = 3;
            this.gboxoperacion.TabStop = false;
            this.gboxoperacion.Text = "operaciones";
            // 
            // rbsuma
            // 
            this.rbsuma.AutoSize = true;
            this.rbsuma.Checked = true;
            this.rbsuma.Location = new System.Drawing.Point(3, 18);
            this.rbsuma.Name = "rbsuma";
            this.rbsuma.Size = new System.Drawing.Size(61, 20);
            this.rbsuma.TabIndex = 0;
            this.rbsuma.TabStop = true;
            this.rbsuma.Text = "suma";
            this.rbsuma.UseVisualStyleBackColor = true;
            // 
            // rbresta
            // 
            this.rbresta.AutoSize = true;
            this.rbresta.Location = new System.Drawing.Point(3, 44);
            this.rbresta.Name = "rbresta";
            this.rbresta.Size = new System.Drawing.Size(58, 20);
            this.rbresta.TabIndex = 1;
            this.rbresta.Text = "resta";
            this.rbresta.UseVisualStyleBackColor = true;
            // 
            // rbmultiplicacion
            // 
            this.rbmultiplicacion.AutoSize = true;
            this.rbmultiplicacion.Location = new System.Drawing.Point(3, 70);
            this.rbmultiplicacion.Name = "rbmultiplicacion";
            this.rbmultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.rbmultiplicacion.TabIndex = 2;
            this.rbmultiplicacion.Text = "multiplicacion";
            this.rbmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbdivicion
            // 
            this.rbdivicion.AutoSize = true;
            this.rbdivicion.Location = new System.Drawing.Point(6, 96);
            this.rbdivicion.Name = "rbdivicion";
            this.rbdivicion.Size = new System.Drawing.Size(64, 20);
            this.rbdivicion.TabIndex = 4;
            this.rbdivicion.Text = "dividir";
            this.rbdivicion.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(122, 99);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(63, 16);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "resultado";
            // 
            // Gboxoperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 256);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.gboxoperacion);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btncalcular);
            this.Name = "Gboxoperaciones";
            this.Text = "Operaciones";
            this.gboxoperacion.ResumeLayout(false);
            this.gboxoperacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.GroupBox gboxoperacion;
        private System.Windows.Forms.RadioButton rbdivicion;
        private System.Windows.Forms.RadioButton rbmultiplicacion;
        private System.Windows.Forms.RadioButton rbresta;
        private System.Windows.Forms.RadioButton rbsuma;
        private System.Windows.Forms.Label lblresultado;
    }
}

