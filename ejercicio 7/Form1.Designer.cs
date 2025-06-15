namespace ejercicio_7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnFinalizar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnConvertir);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(773, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 318);
            this.panel1.TabIndex = 4;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinalizar.Image = global::ejercicio_7.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 212);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(163, 102);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpiar.Image = global::ejercicio_7.Properties.Resources.icons8_limpiar_32;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 106);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(163, 106);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConvertir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertir.Image = global::ejercicio_7.Properties.Resources.icons8_convertir_32;
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertir.Location = new System.Drawing.Point(0, 0);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(163, 106);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.txtConversion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Location = new System.Drawing.Point(36, 48);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(659, 340);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conversión dolares a pesos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(205, 98);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(279, 32);
            this.txtCantidad.TabIndex = 11;
            this.tlpAyuda.SetToolTip(this.txtCantidad, "Ingresa una cantidad de dinero en dolares");
            // 
            // txtConversion
            // 
            this.txtConversion.Location = new System.Drawing.Point(287, 233);
            this.txtConversion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.ReadOnly = true;
            this.txtConversion.Size = new System.Drawing.Size(301, 32);
            this.txtConversion.TabIndex = 10;
            this.tlpAyuda.SetToolTip(this.txtConversion, "Convierte la cantidad de dolares a pesos");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conversion a pesos:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ejercicio_7.Properties.Resources.icons8_dinero_64;
            this.pictureBox2.Location = new System.Drawing.Point(53, 167);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresa la cantidad de dolares:";
            // 
            // tlpAyuda
            // 
            this.tlpAyuda.ToolTipTitle = "Ayuda";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.lblError);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox2.Location = new System.Drawing.Point(36, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblError.Location = new System.Drawing.Point(72, 27);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(68, 23);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Error:";
            this.tlpAyuda.SetToolTip(this.lblError, "Muestra un error que ocurrio al momento de ingreso los datos");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Conversion de dinero";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tlpAyuda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblError;
    }
}

