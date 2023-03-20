namespace calculadora
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
            this.textresultado = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnsigno = new System.Windows.Forms.Button();
            this.btnraizcuadrada = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textresultado
            // 
            this.textresultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresultado.Location = new System.Drawing.Point(0, 0);
            this.textresultado.MaxLength = 21;
            this.textresultado.Multiline = true;
            this.textresultado.Name = "textresultado";
            this.textresultado.ReadOnly = true;
            this.textresultado.Size = new System.Drawing.Size(322, 47);
            this.textresultado.TabIndex = 0;
            this.textresultado.Text = "0";
            this.textresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(11, 261);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 45);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(113, 261);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 45);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(62, 261);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 45);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(62, 200);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(45, 45);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(113, 200);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(45, 45);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(11, 200);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 45);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(63, 139);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(45, 45);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(114, 139);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(45, 45);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 139);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(45, 45);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrartodo.Location = new System.Drawing.Point(62, 76);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(45, 45);
            this.btnborrartodo.TabIndex = 13;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_click);
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(113, 76);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(45, 45);
            this.btnquitar.TabIndex = 12;
            this.btnquitar.Text = "<-";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(11, 76);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(45, 45);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(62, 322);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(45, 45);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpunto.Location = new System.Drawing.Point(113, 322);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(45, 45);
            this.btnpunto.TabIndex = 15;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_click);
            // 
            // btnsigno
            // 
            this.btnsigno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsigno.Location = new System.Drawing.Point(11, 322);
            this.btnsigno.Name = "btnsigno";
            this.btnsigno.Size = new System.Drawing.Size(45, 45);
            this.btnsigno.TabIndex = 14;
            this.btnsigno.Text = "+/-";
            this.btnsigno.UseVisualStyleBackColor = true;
            this.btnsigno.Click += new System.EventHandler(this.btnsigno_click);
            // 
            // btnraizcuadrada
            // 
            this.btnraizcuadrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraizcuadrada.Location = new System.Drawing.Point(223, 76);
            this.btnraizcuadrada.Name = "btnraizcuadrada";
            this.btnraizcuadrada.Size = new System.Drawing.Size(45, 45);
            this.btnraizcuadrada.TabIndex = 18;
            this.btnraizcuadrada.Tag = "√";
            this.btnraizcuadrada.Text = "√";
            this.btnraizcuadrada.UseVisualStyleBackColor = true;
            this.btnraizcuadrada.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btncuadrado
            // 
            this.btncuadrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuadrado.Location = new System.Drawing.Point(274, 76);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(45, 45);
            this.btncuadrado.TabIndex = 17;
            this.btncuadrado.Tag = "²";
            this.btncuadrado.Text = "X²";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(223, 139);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(45, 45);
            this.btndividir.TabIndex = 20;
            this.btndividir.Tag = "/";
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(274, 139);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(45, 45);
            this.btnmultiplicar.TabIndex = 19;
            this.btnmultiplicar.Tag = "x";
            this.btnmultiplicar.Text = "x";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(223, 203);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(45, 45);
            this.btnsuma.TabIndex = 22;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(274, 203);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(45, 45);
            this.btnresta.TabIndex = 21;
            this.btnresta.Tag = "-";
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.ClikOperador);
            // 
            // btnresultado
            // 
            this.btnresultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(223, 261);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(96, 45);
            this.btnresultado.TabIndex = 23;
            this.btnresultado.Tag = "=";
            this.btnresultado.Text = "=";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 396);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnraizcuadrada);
            this.Controls.Add(this.btncuadrado);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnsigno);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.textresultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textresultado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnsigno;
        private System.Windows.Forms.Button btnraizcuadrada;
        private System.Windows.Forms.Button btncuadrado;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnresultado;
    }
}

