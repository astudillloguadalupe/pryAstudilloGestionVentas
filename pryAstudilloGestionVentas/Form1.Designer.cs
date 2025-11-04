namespace pryAstudilloGestionVentas
{
    partial class frmContactos
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
            lblAgenda = new Label();
            btnSalir = new Button();
            btnAtras = new Button();
            btnSiguiente = new Button();
            lstContactos = new ListBox();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.Location = new Point(157, 32);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(48, 15);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "Agenda";
            lblAgenda.Click += label1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(146, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(29, 257);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Átras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(264, 257);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(29, 111);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(310, 94);
            lstContactos.TabIndex = 4;
            // 
            // frmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 357);
            Controls.Add(lstContactos);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(btnSalir);
            Controls.Add(lblAgenda);
            Name = "frmContactos";
            Text = "Contactos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
        private Button btnSalir;
        private Button btnAtras;
        private Button btnSiguiente;
        private ListBox lstContactos;
    }
}