namespace CapaPresentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLocalHost = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.RdMSSQL = new System.Windows.Forms.RadioButton();
            this.RbMYSQL = new System.Windows.Forms.RadioButton();
            this.RbORACLE = new System.Windows.Forms.RadioButton();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnProbar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LocalHost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // TxtLocalHost
            // 
            this.TxtLocalHost.Location = new System.Drawing.Point(98, 54);
            this.TxtLocalHost.Name = "TxtLocalHost";
            this.TxtLocalHost.Size = new System.Drawing.Size(179, 22);
            this.TxtLocalHost.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(99, 100);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(179, 22);
            this.TxtUsuario.TabIndex = 4;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(99, 144);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(179, 22);
            this.TxtContraseña.TabIndex = 5;
            // 
            // RdMSSQL
            // 
            this.RdMSSQL.AutoSize = true;
            this.RdMSSQL.Location = new System.Drawing.Point(26, 183);
            this.RdMSSQL.Name = "RdMSSQL";
            this.RdMSSQL.Size = new System.Drawing.Size(77, 21);
            this.RdMSSQL.TabIndex = 6;
            this.RdMSSQL.TabStop = true;
            this.RdMSSQL.Text = "MSSQL";
            this.RdMSSQL.UseVisualStyleBackColor = true;
            // 
            // RbMYSQL
            // 
            this.RbMYSQL.AutoSize = true;
            this.RbMYSQL.Location = new System.Drawing.Point(109, 183);
            this.RbMYSQL.Name = "RbMYSQL";
            this.RbMYSQL.Size = new System.Drawing.Size(77, 21);
            this.RbMYSQL.TabIndex = 7;
            this.RbMYSQL.TabStop = true;
            this.RbMYSQL.Text = "MYSQL";
            this.RbMYSQL.UseVisualStyleBackColor = true;
            // 
            // RbORACLE
            // 
            this.RbORACLE.AutoSize = true;
            this.RbORACLE.Location = new System.Drawing.Point(192, 183);
            this.RbORACLE.Name = "RbORACLE";
            this.RbORACLE.Size = new System.Drawing.Size(85, 21);
            this.RbORACLE.TabIndex = 8;
            this.RbORACLE.TabStop = true;
            this.RbORACLE.Text = "ORACLE";
            this.RbORACLE.UseVisualStyleBackColor = true;
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(360, 43);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(150, 33);
            this.BtnConectar.TabIndex = 9;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            // 
            // BtnProbar
            // 
            this.BtnProbar.Location = new System.Drawing.Point(360, 88);
            this.BtnProbar.Name = "BtnProbar";
            this.BtnProbar.Size = new System.Drawing.Size(150, 34);
            this.BtnProbar.TabIndex = 10;
            this.BtnProbar.Text = "Probar";
            this.BtnProbar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(360, 132);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(150, 35);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 291);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnProbar);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.RbORACLE);
            this.Controls.Add(this.RbMYSQL);
            this.Controls.Add(this.RdMSSQL);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtLocalHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conexion a base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLocalHost;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.RadioButton RdMSSQL;
        private System.Windows.Forms.RadioButton RbMYSQL;
        private System.Windows.Forms.RadioButton RbORACLE;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnProbar;
        private System.Windows.Forms.Button BtnSalir;
    }
}

