namespace LaPrueva
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
            this.label1 = new System.Windows.Forms.Label();
            this.boton11 = new BotonLibreria.Boton1();
            this.btnProbarNumeros = new System.Windows.Forms.Button();
            this.btnLetras = new System.Windows.Forms.Button();
            this.btnAlfa = new System.Windows.Forms.Button();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValRFC = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boton que al pasar el mouse sobre el, cambia de color:";
            // 
            // boton11
            // 
            this.boton11.Location = new System.Drawing.Point(62, 327);
            this.boton11.Name = "boton11";
            this.boton11.Size = new System.Drawing.Size(268, 38);
            this.boton11.TabIndex = 2;
            // 
            // btnProbarNumeros
            // 
            this.btnProbarNumeros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarNumeros.Location = new System.Drawing.Point(663, 26);
            this.btnProbarNumeros.Name = "btnProbarNumeros";
            this.btnProbarNumeros.Size = new System.Drawing.Size(136, 33);
            this.btnProbarNumeros.TabIndex = 3;
            this.btnProbarNumeros.Text = "Solo numeros";
            this.btnProbarNumeros.UseVisualStyleBackColor = true;
            this.btnProbarNumeros.Click += new System.EventHandler(this.btnProbarNumeros_Click);
            // 
            // btnLetras
            // 
            this.btnLetras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetras.Location = new System.Drawing.Point(663, 80);
            this.btnLetras.Name = "btnLetras";
            this.btnLetras.Size = new System.Drawing.Size(136, 32);
            this.btnLetras.TabIndex = 4;
            this.btnLetras.Text = "Solo letras";
            this.btnLetras.UseVisualStyleBackColor = true;
            this.btnLetras.Click += new System.EventHandler(this.btnLetras_Click);
            // 
            // btnAlfa
            // 
            this.btnAlfa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfa.Location = new System.Drawing.Point(663, 127);
            this.btnAlfa.Name = "btnAlfa";
            this.btnAlfa.Size = new System.Drawing.Size(136, 30);
            this.btnAlfa.TabIndex = 5;
            this.btnAlfa.Text = "Alfanumericos";
            this.btnAlfa.UseVisualStyleBackColor = true;
            this.btnAlfa.Click += new System.EventHandler(this.btnAlfa_Click);
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(818, 80);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(146, 20);
            this.txtValidar.TabIndex = 6;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(689, 274);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(199, 20);
            this.txtRFC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(687, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresa tu RFC";
            // 
            // btnValRFC
            // 
            this.btnValRFC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValRFC.Location = new System.Drawing.Point(689, 327);
            this.btnValRFC.Name = "btnValRFC";
            this.btnValRFC.Size = new System.Drawing.Size(107, 30);
            this.btnValRFC.TabIndex = 9;
            this.btnValRFC.Text = "Validar";
            this.btnValRFC.UseVisualStyleBackColor = true;
            this.btnValRFC.Click += new System.EventHandler(this.btnValRFC_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(688, 302);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado";
            // 
            // btnCorregir
            // 
            this.btnCorregir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorregir.Location = new System.Drawing.Point(817, 324);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(92, 33);
            this.btnCorregir.TabIndex = 11;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.UseVisualStyleBackColor = true;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 511);
            this.Controls.Add(this.btnCorregir);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.btnAlfa);
            this.Controls.Add(this.btnLetras);
            this.Controls.Add(this.btnProbarNumeros);
            this.Controls.Add(this.boton11);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private BotonLibreria.Boton1 boton11;
        private System.Windows.Forms.Button btnProbarNumeros;
        private System.Windows.Forms.Button btnLetras;
        private System.Windows.Forms.Button btnAlfa;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValRFC;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCorregir;
    }
}

