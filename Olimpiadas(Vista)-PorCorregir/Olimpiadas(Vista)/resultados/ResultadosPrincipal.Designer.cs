namespace Olimpiadas_Vista_.resultados
{
    partial class ResultadosPrincipal
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.lblmodificarparticipantes = new System.Windows.Forms.Label();
            this.btnnuevoresultado = new System.Windows.Forms.Button();
            this.lblnuevoparticipante = new System.Windows.Forms.Label();
            this.dtresultados = new System.Windows.Forms.DataGridView();
            this.numerodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreparticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreposicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblcedulaparticipante = new System.Windows.Forms.Label();
            this.cmbparticipantes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbposicion = new System.Windows.Forms.ComboBox();
            this.lblposicionactual = new System.Windows.Forms.Label();
            this.lblnombreparticipante = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtresultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(654, 9);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(335, 186);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 31);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Enabled = false;
            this.btnguardarcambios.Location = new System.Drawing.Point(143, 186);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(100, 31);
            this.btnguardarcambios.TabIndex = 21;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // lblmodificarparticipantes
            // 
            this.lblmodificarparticipantes.AutoSize = true;
            this.lblmodificarparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodificarparticipantes.Location = new System.Drawing.Point(219, 89);
            this.lblmodificarparticipantes.Name = "lblmodificarparticipantes";
            this.lblmodificarparticipantes.Size = new System.Drawing.Size(190, 16);
            this.lblmodificarparticipantes.TabIndex = 27;
            this.lblmodificarparticipantes.Text = "MODIFICAR RESULTADO:";
            this.lblmodificarparticipantes.Visible = false;
            // 
            // btnnuevoresultado
            // 
            this.btnnuevoresultado.Location = new System.Drawing.Point(37, 186);
            this.btnnuevoresultado.Name = "btnnuevoresultado";
            this.btnnuevoresultado.Size = new System.Drawing.Size(100, 31);
            this.btnnuevoresultado.TabIndex = 20;
            this.btnnuevoresultado.Text = "Guardar Nuevo";
            this.btnnuevoresultado.UseVisualStyleBackColor = true;
            this.btnnuevoresultado.Click += new System.EventHandler(this.btnnuevoresultado_Click);
            // 
            // lblnuevoparticipante
            // 
            this.lblnuevoparticipante.AutoSize = true;
            this.lblnuevoparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevoparticipante.Location = new System.Drawing.Point(34, 89);
            this.lblnuevoparticipante.Name = "lblnuevoparticipante";
            this.lblnuevoparticipante.Size = new System.Drawing.Size(161, 16);
            this.lblnuevoparticipante.TabIndex = 26;
            this.lblnuevoparticipante.Text = "NUEVO RESULTADO:";
            // 
            // dtresultados
            // 
            this.dtresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtresultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodocumento,
            this.nombreparticipante,
            this.nombreposicion,
            this.nombrepais});
            this.dtresultados.Location = new System.Drawing.Point(17, 277);
            this.dtresultados.Name = "dtresultados";
            this.dtresultados.ReadOnly = true;
            this.dtresultados.Size = new System.Drawing.Size(712, 150);
            this.dtresultados.TabIndex = 24;
            this.dtresultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtresultados_CellClick);
            // 
            // numerodocumento
            // 
            this.numerodocumento.DataPropertyName = "numerodocumento";
            this.numerodocumento.HeaderText = "NUMERO DOCUMENTO";
            this.numerodocumento.Name = "numerodocumento";
            this.numerodocumento.ReadOnly = true;
            this.numerodocumento.Width = 180;
            // 
            // nombreparticipante
            // 
            this.nombreparticipante.DataPropertyName = "nombreparticipante";
            this.nombreparticipante.HeaderText = "NOMBRE PARTICIPANTE";
            this.nombreparticipante.Name = "nombreparticipante";
            this.nombreparticipante.ReadOnly = true;
            this.nombreparticipante.Width = 250;
            // 
            // nombreposicion
            // 
            this.nombreposicion.DataPropertyName = "nombreposicion";
            this.nombreposicion.HeaderText = "POSICION";
            this.nombreposicion.Name = "nombreposicion";
            this.nombreposicion.ReadOnly = true;
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "PAIS";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.ReadOnly = true;
            // 
            // lblcedulaparticipante
            // 
            this.lblcedulaparticipante.AutoSize = true;
            this.lblcedulaparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblcedulaparticipante.Location = new System.Drawing.Point(503, 108);
            this.lblcedulaparticipante.Name = "lblcedulaparticipante";
            this.lblcedulaparticipante.Size = new System.Drawing.Size(244, 31);
            this.lblcedulaparticipante.TabIndex = 28;
            this.lblcedulaparticipante.Text = "CedulaParticipante";
            this.lblcedulaparticipante.Visible = false;
            // 
            // cmbparticipantes
            // 
            this.cmbparticipantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbparticipantes.FormattingEnabled = true;
            this.cmbparticipantes.Location = new System.Drawing.Point(37, 108);
            this.cmbparticipantes.Name = "cmbparticipantes";
            this.cmbparticipantes.Size = new System.Drawing.Size(247, 33);
            this.cmbparticipantes.TabIndex = 19;
            this.cmbparticipantes.SelectedIndexChanged += new System.EventHandler(this.cmbparticipantes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "Resultados";
            // 
            // cmbposicion
            // 
            this.cmbposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbposicion.FormattingEnabled = true;
            this.cmbposicion.Location = new System.Drawing.Point(37, 147);
            this.cmbposicion.Name = "cmbposicion";
            this.cmbposicion.Size = new System.Drawing.Size(206, 33);
            this.cmbposicion.TabIndex = 30;
            // 
            // lblposicionactual
            // 
            this.lblposicionactual.AutoSize = true;
            this.lblposicionactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblposicionactual.Location = new System.Drawing.Point(248, 147);
            this.lblposicionactual.Name = "lblposicionactual";
            this.lblposicionactual.Size = new System.Drawing.Size(193, 31);
            this.lblposicionactual.TabIndex = 31;
            this.lblposicionactual.Text = "PosicionActual";
            this.lblposicionactual.Visible = false;
            // 
            // lblnombreparticipante
            // 
            this.lblnombreparticipante.AutoSize = true;
            this.lblnombreparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblnombreparticipante.Location = new System.Drawing.Point(290, 110);
            this.lblnombreparticipante.Name = "lblnombreparticipante";
            this.lblnombreparticipante.Size = new System.Drawing.Size(110, 31);
            this.lblnombreparticipante.TabIndex = 32;
            this.lblnombreparticipante.Text = "Nombre";
            this.lblnombreparticipante.Visible = false;
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(249, 186);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(80, 31);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // ResultadosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblnombreparticipante);
            this.Controls.Add(this.lblposicionactual);
            this.Controls.Add(this.cmbposicion);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.lblmodificarparticipantes);
            this.Controls.Add(this.btnnuevoresultado);
            this.Controls.Add(this.lblnuevoparticipante);
            this.Controls.Add(this.dtresultados);
            this.Controls.Add(this.lblcedulaparticipante);
            this.Controls.Add(this.cmbparticipantes);
            this.Controls.Add(this.label1);
            this.Name = "ResultadosPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadosPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dtresultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Label lblmodificarparticipantes;
        private System.Windows.Forms.Button btnnuevoresultado;
        private System.Windows.Forms.Label lblnuevoparticipante;
        private System.Windows.Forms.DataGridView dtresultados;
        private System.Windows.Forms.Label lblcedulaparticipante;
        private System.Windows.Forms.ComboBox cmbparticipantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreparticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
        private System.Windows.Forms.ComboBox cmbposicion;
        private System.Windows.Forms.Label lblposicionactual;
        private System.Windows.Forms.Label lblnombreparticipante;
        private System.Windows.Forms.Button btneliminar;
    }
}