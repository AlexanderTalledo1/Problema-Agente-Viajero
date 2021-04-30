namespace ProblemaAgenteViajero
{
    partial class frmPrincipal
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnDistancia = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.listboxGrafos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(660, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(164, 42);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDistancia
            // 
            this.btnDistancia.Location = new System.Drawing.Point(660, 90);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(164, 42);
            this.btnDistancia.TabIndex = 1;
            this.btnDistancia.Text = "Distancia";
            this.btnDistancia.UseVisualStyleBackColor = true;
            this.btnDistancia.Click += new System.EventHandler(this.btnDistancia_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::ProblemaAgenteViajero.Properties.Resources.Mapa_peru;
            this.pbxImagen.Location = new System.Drawing.Point(12, 3);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(616, 687);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            this.pbxImagen.Click += new System.EventHandler(this.pbxImagen_Click);
            this.pbxImagen.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxImagen_Paint);
            this.pbxImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxImagen_MouseClick);
            this.pbxImagen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxImagen_MouseMove);
            // 
            // listboxGrafos
            // 
            this.listboxGrafos.FormattingEnabled = true;
            this.listboxGrafos.Location = new System.Drawing.Point(650, 244);
            this.listboxGrafos.Name = "listboxGrafos";
            this.listboxGrafos.Size = new System.Drawing.Size(189, 446);
            this.listboxGrafos.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 713);
            this.Controls.Add(this.listboxGrafos);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnDistancia);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ListBox listboxGrafos;
    }
}

