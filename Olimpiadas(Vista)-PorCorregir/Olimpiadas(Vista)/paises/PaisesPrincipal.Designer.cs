namespace Olimpiadas_Vista_.paises
{
    partial class PaisesPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpaises = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblnuevopais = new System.Windows.Forms.Label();
            this.txtnombrepais = new System.Windows.Forms.TextBox();
            this.btnnuevopais = new System.Windows.Forms.Button();
            this.lblmodificarpais = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paises";
            // 
            // dtpaises
            // 
            this.dtpaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nombrepais});
            this.dtpaises.Location = new System.Drawing.Point(12, 243);
            this.dtpaises.Name = "dtpaises";
            this.dtpaises.ReadOnly = true;
            this.dtpaises.Size = new System.Drawing.Size(392, 150);
            this.dtpaises.TabIndex = 1;
            this.dtpaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpaises_CellClick);
            this.dtpaises.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpaises_CellContentClick);
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "idpais";
            this.idpais.HeaderText = "CODIGO PAIS";
            this.idpais.Name = "idpais";
            this.idpais.ReadOnly = true;
            this.idpais.Width = 110;
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "NOMBRE DEL PAIS";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.ReadOnly = true;
            this.nombrepais.Width = 230;
            // 
            // lblnuevopais
            // 
            this.lblnuevopais.AutoSize = true;
            this.lblnuevopais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnuevopais.Location = new System.Drawing.Point(29, 92);
            this.lblnuevopais.Name = "lblnuevopais";
            this.lblnuevopais.Size = new System.Drawing.Size(103, 16);
            this.lblnuevopais.TabIndex = 2;
            this.lblnuevopais.Text = "NUEVO PAIS:";
            // 
            // txtnombrepais
            // 
            this.txtnombrepais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtnombrepais.Location = new System.Drawing.Point(32, 148);
            this.txtnombrepais.Name = "txtnombrepais";
            this.txtnombrepais.Size = new System.Drawing.Size(247, 32);
            this.txtnombrepais.TabIndex = 3;
            // 
            // btnnuevopais
            // 
            this.btnnuevopais.Location = new System.Drawing.Point(32, 186);
            this.btnnuevopais.Name = "btnnuevopais";
            this.btnnuevopais.Size = new System.Drawing.Size(100, 31);
            this.btnnuevopais.TabIndex = 4;
            this.btnnuevopais.Text = "Guardar Nuevo";
            this.btnnuevopais.UseVisualStyleBackColor = true;
            this.btnnuevopais.Click += new System.EventHandler(this.btnnuevopais_Click);
            // 
            // lblmodificarpais
            // 
            this.lblmodificarpais.AutoSize = true;
            this.lblmodificarpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodificarpais.Location = new System.Drawing.Point(154, 92);
            this.lblmodificarpais.Name = "lblmodificarpais";
            this.lblmodificarpais.Size = new System.Drawing.Size(132, 16);
            this.lblmodificarpais.TabIndex = 5;
            this.lblmodificarpais.Text = "MODIFICAR PAIS:";
            this.lblmodificarpais.Visible = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtcodigo.Location = new System.Drawing.Point(32, 111);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 32);
            this.txtcodigo.TabIndex = 6;
            this.txtcodigo.Visible = false;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Enabled = false;
            this.btnguardarcambios.Location = new System.Drawing.Point(138, 186);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(100, 31);
            this.btnguardarcambios.TabIndex = 7;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(244, 186);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 31);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaisesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 405);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblmodificarpais);
            this.Controls.Add(this.btnnuevopais);
            this.Controls.Add(this.txtnombrepais);
            this.Controls.Add(this.lblnuevopais);
            this.Controls.Add(this.dtpaises);
            this.Controls.Add(this.label1);
            this.Name = "PaisesPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaisesPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtpaises;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
        private System.Windows.Forms.Label lblnuevopais;
        private System.Windows.Forms.TextBox txtnombrepais;
        private System.Windows.Forms.Button btnnuevopais;
        private System.Windows.Forms.Label lblmodificarpais;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button button1;
    }
}