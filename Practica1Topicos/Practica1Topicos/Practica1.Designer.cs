namespace Practica1Topicos
{
    partial class Practica1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnAgragar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lstLista = new ListBox();
            menuStrip1 = new MenuStrip();
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 33);
            label1.Name = "label1";
            label1.Size = new Size(223, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de contactos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(139, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(188, 82);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(139, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(345, 82);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(161, 23);
            txtCorreo.TabIndex = 3;
            // 
            // btnAgragar
            // 
            btnAgragar.Location = new Point(55, 130);
            btnAgragar.Name = "btnAgragar";
            btnAgragar.Size = new Size(109, 24);
            btnAgragar.TabIndex = 4;
            btnAgragar.Text = "Agregar";
            btnAgragar.UseVisualStyleBackColor = true;
            btnAgragar.Click += btnAgragar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(218, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(109, 24);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(397, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 24);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(25, 179);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(481, 79);
            lstLista.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { salirToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(527, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(74, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de ";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingresa tu nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 64);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 10;
            label3.Text = "Ingresa tu telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 64);
            label4.Name = "label4";
            label4.Size = new Size(161, 15);
            label4.TabIndex = 11;
            label4.Text = "Ingresa tu correo electronico:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(527, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstLista);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgragar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Gestion de contactos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnAgragar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private ListBox lstLista;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
