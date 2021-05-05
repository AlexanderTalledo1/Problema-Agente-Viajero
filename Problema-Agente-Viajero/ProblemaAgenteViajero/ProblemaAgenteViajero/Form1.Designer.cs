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
            this.btnNodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.textFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxInicio = new System.Windows.Forms.ComboBox();
            this.cbxFinal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1079, 362);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(164, 42);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnDistancia
            // 
            this.btnDistancia.Location = new System.Drawing.Point(1079, 639);
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
            this.pbxImagen.Size = new System.Drawing.Size(615, 688);
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
            this.listboxGrafos.Location = new System.Drawing.Point(679, 521);
            this.listboxGrafos.Name = "listboxGrafos";
            this.listboxGrafos.Size = new System.Drawing.Size(361, 160);
            this.listboxGrafos.TabIndex = 3;
            // 
            // btnNodo
            // 
            this.btnNodo.Location = new System.Drawing.Point(1079, 501);
            this.btnNodo.Name = "btnNodo";
            this.btnNodo.Size = new System.Drawing.Size(164, 42);
            this.btnNodo.TabIndex = 6;
            this.btnNodo.Text = "NodoANodo";
            this.btnNodo.UseVisualStyleBackColor = true;
            this.btnNodo.Click += new System.EventHandler(this.btnNodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(961, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(961, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Final";
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(873, 85);
            this.textInicio.Name = "textInicio";
            this.textInicio.Size = new System.Drawing.Size(202, 20);
            this.textInicio.TabIndex = 11;
            // 
            // textFinal
            // 
            this.textFinal.Location = new System.Drawing.Point(873, 249);
            this.textFinal.Name = "textFinal";
            this.textFinal.Size = new System.Drawing.Size(202, 20);
            this.textFinal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inicio";
            // 
            // cbxInicio
            // 
            this.cbxInicio.FormattingEnabled = true;
            this.cbxInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxInicio.Location = new System.Drawing.Point(673, 84);
            this.cbxInicio.Name = "cbxInicio";
            this.cbxInicio.Size = new System.Drawing.Size(121, 21);
            this.cbxInicio.TabIndex = 15;
            // 
            // cbxFinal
            // 
            this.cbxFinal.FormattingEnabled = true;
            this.cbxFinal.Location = new System.Drawing.Point(673, 210);
            this.cbxFinal.Name = "cbxFinal";
            this.cbxFinal.Size = new System.Drawing.Size(121, 21);
            this.cbxFinal.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Final";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1294, 725);
            this.Controls.Add(this.cbxFinal);
            this.Controls.Add(this.cbxInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFinal);
            this.Controls.Add(this.textInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNodo);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ListBox listboxGrafos;
        private System.Windows.Forms.Button btnNodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.TextBox textFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxInicio;
        private System.Windows.Forms.ComboBox cbxFinal;
        private System.Windows.Forms.Label label4;
    }
}

