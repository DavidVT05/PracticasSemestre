namespace LibreriaPractica3
{
    partial class Boton
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClick
            // 
            this.BtnClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClick.Location = new System.Drawing.Point(0, 0);
            this.BtnClick.Name = "BtnClick";
            this.BtnClick.Size = new System.Drawing.Size(150, 58);
            this.BtnClick.TabIndex = 0;
            this.BtnClick.Text = "Click";
            this.BtnClick.UseVisualStyleBackColor = true;
            // 
            // Boton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnClick);
            this.Name = "Boton";
            this.Size = new System.Drawing.Size(150, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClick;
    }
}
