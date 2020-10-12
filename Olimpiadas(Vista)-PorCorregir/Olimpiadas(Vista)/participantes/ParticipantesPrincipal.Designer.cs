namespace Olimpiadas_Vista_.participantes
{
    partial class ParticipantesPrincipal
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
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.lblmodificarparticipantes = new System.Windows.Forms.Label();
            this.btnnuevoparticipante = new System.Windows.Forms.Button();
            this.txtnombreparticipantes = new System.Windows.Forms.TextBox();
            this.lblnuevoparticipante = new System.Windows.Forms.Label();
            this.dtparticipantes = new System.Windows.Forms.DataGridView();
            this.numerodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreparticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbpaises = new System.Windows.Forms.ComboBox();
            this.lblpaisdelparticipante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtparticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(429, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(249, 223);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 31);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Enabled = false;
            this.btnguardarcambios.Location = new System.Drawing.Point(143, 223);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(100, 31);
            this.btnguardarcambios.TabIndex = 4;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnumerodocumento.Location = new System.Drawing.Point(37, 109);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(122, 32);
            this.txtnumerodocumento.TabIndex = 0;
            // 
            // lblmodificarparticipantes
            // 
            this.lblmodificarparticipantes.AutoSize = true;
            this.lblmodificarparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodificarparticipantes.Location = new System.Drawing.Point(219, 90);
            this.lblmodificarparticipantes.Name = "lblmodificarparticipantes";
            this.lblmodificarparticipantes.Size = new System.Drawing.Size(208, 16);
            this.lblmodificarparticipantes.TabIndex = 15;
            this.lblmodificarparticipantes.Text = "MODIFICAR PARTICIPANTE:";
            this.lblmodificarparticipantes.Visible = false;
            // 
            // btnnuevoparticipante
            // 
            this.btnnuevoparticipante.Location = new System.Drawing.Point(37, 223);
            this.btnnuevoparticipante.Name = "btnnuevoparticipante";
            this.btnnuevoparticipante.Size = new System.Drawing.Size(100, 31);
            this.btnnuevoparticipante.TabIndex = 3;
            this.btnnuevoparticipante.Text = "Guardar Nuevo";
            this.btnnuevoparticipante.UseVisualStyleBackColor = true;
            this.btnnuevoparticipante.Click += new System.EventHandler(this.btnnuevoparticipante_Click);
            // 
            // txtnombreparticipantes
            // 
            this.txtnombreparticipantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnombreparticipantes.Location = new System.Drawing.Point(37, 146);
            this.txtnombreparticipantes.Name = "txtnombreparticipantes";
            this.txtnombreparticipantes.Size = new System.Drawing.Size(247, 32);
            this.txtnombreparticipantes.TabIndex = 1;
            // 
            // lblnuevoparticipante
            // 
            this.lblnuevoparticipante.AutoSize = true;
            this.lblnuevoparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevoparticipante.Location = new System.Drawing.Point(34, 90);
            this.lblnuevoparticipante.Name = "lblnuevoparticipante";
            this.lblnuevoparticipante.Size = new System.Drawing.Size(179, 16);
            this.lblnuevoparticipante.TabIndex = 12;
            this.lblnuevoparticipante.Text = "NUEVO PARTICIPANTE:";
            // 
            // dtparticipantes
            // 
            this.dtparticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtparticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numerodocumento,
            this.nombreparticipante,
            this.nombrepais});
            this.dtparticipantes.Location = new System.Drawing.Point(17, 278);
            this.dtparticipantes.Name = "dtparticipantes";
            this.dtparticipantes.ReadOnly = true;
            this.dtparticipantes.Size = new System.Drawing.Size(487, 150);
            this.dtparticipantes.TabIndex = 7;
            this.dtparticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtparticipantes_CellClick);
            this.dtparticipantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtparticipantes_CellContentClick);
            // 
            // numerodocumento
            // 
            this.numerodocumento.DataPropertyName = "numerodocumento";
            this.numerodocumento.HeaderText = "NUMERO DOCUMENTO";
            this.numerodocumento.Name = "numerodocumento";
            this.numerodocumento.ReadOnly = true;
            this.numerodocumento.Width = 110;
            // 
            // nombreparticipante
            // 
            this.nombreparticipante.DataPropertyName = "nombreparticipante";
            this.nombreparticipante.HeaderText = "NOMBRE PARTICIPANTE";
            this.nombreparticipante.Name = "nombreparticipante";
            this.nombreparticipante.ReadOnly = true;
            this.nombreparticipante.Width = 230;
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "PAIS";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Participantes";
            // 
            // cmbpaises
            // 
            this.cmbpaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpaises.FormattingEnabled = true;
            this.cmbpaises.Location = new System.Drawing.Point(37, 185);
            this.cmbpaises.Name = "cmbpaises";
            this.cmbpaises.Size = new System.Drawing.Size(247, 33);
            this.cmbpaises.TabIndex = 2;
            // 
            // lblpaisdelparticipante
            // 
            this.lblpaisdelparticipante.AutoSize = true;
            this.lblpaisdelparticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblpaisdelparticipante.Location = new System.Drawing.Point(287, 186);
            this.lblpaisdelparticipante.Name = "lblpaisdelparticipante";
            this.lblpaisdelparticipante.Size = new System.Drawing.Size(172, 31);
            this.lblpaisdelparticipante.TabIndex = 16;
            this.lblpaisdelparticipante.Text = "Participantes";
            this.lblpaisdelparticipante.Visible = false;
            // 
            // ParticipantesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.lblpaisdelparticipante);
            this.Controls.Add(this.cmbpaises);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.txtnumerodocumento);
            this.Controls.Add(this.lblmodificarparticipantes);
            this.Controls.Add(this.btnnuevoparticipante);
            this.Controls.Add(this.txtnombreparticipantes);
            this.Controls.Add(this.lblnuevoparticipante);
            this.Controls.Add(this.dtparticipantes);
            this.Controls.Add(this.label1);
            this.Name = "ParticipantesPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParticipantesPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dtparticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.Label lblmodificarparticipantes;
        private System.Windows.Forms.Button btnnuevoparticipante;
        private System.Windows.Forms.TextBox txtnombreparticipantes;
        private System.Windows.Forms.Label lblnuevoparticipante;
        private System.Windows.Forms.DataGridView dtparticipantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbpaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreparticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
        private System.Windows.Forms.Label lblpaisdelparticipante;
    }
}