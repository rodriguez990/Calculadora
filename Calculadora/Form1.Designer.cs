namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbHistorial = new System.Windows.Forms.Label();
            this.btnSiete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(34, 70);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(255, 197);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 30);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(255, 245);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 29);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 2;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbHistorial
            // 
            this.lbHistorial.AutoSize = true;
            this.lbHistorial.Location = new System.Drawing.Point(52, 31);
            this.lbHistorial.Name = "lbHistorial";
            this.lbHistorial.Size = new System.Drawing.Size(0, 13);
            this.lbHistorial.TabIndex = 3;
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(34, 149);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(53, 42);
            this.btnSiete.TabIndex = 1;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-167, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label1";
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(34, 197);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(53, 42);
            this.btnCuatro.TabIndex = 1;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(34, 245);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(53, 42);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(93, 245);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(53, 42);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(93, 197);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(53, 42);
            this.btnCinco.TabIndex = 1;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(93, 149);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(53, 42);
            this.btnOcho.TabIndex = 1;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(152, 149);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(53, 42);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "9";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(152, 197);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(53, 42);
            this.btnSeis.TabIndex = 1;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(152, 245);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(53, 42);
            this.btnTres.TabIndex = 1;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(34, 293);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(53, 37);
            this.btnCero.TabIndex = 1;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(152, 298);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 85);
            this.button15.TabIndex = 1;
            this.button15.Text = "=";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.Location = new System.Drawing.Point(255, 149);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(75, 30);
            this.btnDivicion.TabIndex = 1;
            this.btnDivicion.Text = "/";
            this.btnDivicion.UseVisualStyleBackColor = true;
            this.btnDivicion.Click += new System.EventHandler(this.btnDivicion_Click);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(255, 298);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 32);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(255, 346);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 32);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(93, 294);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(53, 36);
            this.btnPunto.TabIndex = 2;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 469);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbHistorial);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbHistorial;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnDivicion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnPunto;
    }
}

