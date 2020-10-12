namespace Olimpiadas_Vista_.posiciones
{
    partial class PosicionesPrincipal
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
            this.dtposiciones = new System.Windows.Forms.DataGridView();
            this.idposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblmodificarposicion = new System.Windows.Forms.Label();
            this.btnnuevaposicion = new System.Windows.Forms.Button();
            this.txtnombreposicion = new System.Windows.Forms.TextBox();
            this.lblnuevaposicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtposiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtposiciones
            // 
            this.dtposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtposiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idposicion,
            this.nombreposicion});
            this.dtposiciones.Location = new System.Drawing.Point(12, 243);
            this.dtposiciones.Name = "dtposiciones";
            this.dtposiciones.ReadOnly = true;
            this.dtposiciones.Size = new System.Drawing.Size(392, 150);
            this.dtposiciones.TabIndex = 11;
            this.dtposiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtposiciones_CellClick);
            // 
            // idposicion
            // 
            this.idposicion.DataPropertyName = "idposicion";
            this.idposicion.HeaderText = "CODIGO POSICION";
            this.idposicion.Name = "idposicion";
            this.idposicion.ReadOnly = true;
            this.idposicion.Width = 130;
            // 
            // nombreposicion
            // 
            this.nombreposicion.DataPropertyName = "nombreposicion";
            this.nombreposicion.HeaderText = "NOMBRE POSICION";
            this.nombreposicion.Name = "nombreposicion";
            this.nombreposicion.ReadOnly = true;
            this.nombreposicion.Width = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Posiciones";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(337, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 19;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(244, 186);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 31);
            this.btncancelar.TabIndex = 18;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Enabled = false;
            this.btnguardarcambios.Location = new System.Drawing.Point(138, 186);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(100, 31);
            this.btnguardarcambios.TabIndex = 17;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtcodigo.Location = new System.Drawing.Point(32, 111);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 32);
            this.txtcodigo.TabIndex = 16;
            this.txtcodigo.Visible = false;
            // 
            // lblmodificarposicion
            // 
            this.lblmodificarposicion.AutoSize = true;
            this.lblmodificarposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodificarposicion.Location = new System.Drawing.Point(154, 92);
            this.lblmodificarposicion.Name = "lblmodificarposicion";
            this.lblmodificarposicion.Size = new System.Drawing.Size(169, 16);
            this.lblmodificarposicion.TabIndex = 15;
            this.lblmodificarposicion.Text = "MODIFICAR POSICION:";
            this.lblmodificarposicion.Visible = false;
            // 
            // btnnuevaposicion
            // 
            this.btnnuevaposicion.Location = new System.Drawing.Point(32, 186);
            this.btnnuevaposicion.Name = "btnnuevaposicion";
            this.btnnuevaposicion.Size = new System.Drawing.Size(100, 31);
            this.btnnuevaposicion.TabIndex = 14;
            this.btnnuevaposicion.Text = "Guardar Nuevo";
            this.btnnuevaposicion.UseVisualStyleBackColor = true;
            this.btnnuevaposicion.Click += new System.EventHandler(this.btnnuevaposicion_Click);
            // 
            // txtnombreposicion
            // 
            this.txtnombreposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnombreposicion.Location = new System.Drawing.Point(32, 148);
            this.txtnombreposicion.Name = "txtnombreposicion";
            this.txtnombreposicion.Size = new System.Drawing.Size(247, 32);
            this.txtnombreposicion.TabIndex = 13;
            // 
            // lblnuevaposicion
            // 
            this.lblnuevaposicion.AutoSize = true;
            this.lblnuevaposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevaposicion.Location = new System.Drawing.Point(29, 92);
            this.lblnuevaposicion.Name = "lblnuevaposicion";
            this.lblnuevaposicion.Size = new System.Drawing.Size(139, 16);
            this.lblnuevaposicion.TabIndex = 12;
            this.lblnuevaposicion.Text = "NUEVA POSICION:";
            // 
            // PosicionesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 405);
            this.Controls.Add(this.dtposiciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblmodificarposicion);
            this.Controls.Add(this.btnnuevaposicion);
            this.Controls.Add(this.txtnombreposicion);
            this.Controls.Add(this.lblnuevaposicion);
            this.Name = "PosicionesPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PosicionesPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dtposiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtposiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblmodificarposicion;
        private System.Windows.Forms.Button btnnuevaposicion;
        private System.Windows.Forms.TextBox txtnombreposicion;
        private System.Windows.Forms.Label lblnuevaposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreposicion;
    }
}