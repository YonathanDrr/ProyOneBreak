namespace Presentation
{
    partial class Form1
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridListado = new System.Windows.Forms.DataGridView();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.TxtRutCli = new System.Windows.Forms.TextBox();
            this.TxtRazonSo = new System.Windows.Forms.TextBox();
            this.TxtDireccionCli = new System.Windows.Forms.TextBox();
            this.TxtTelefonoCli = new System.Windows.Forms.TextBox();
            this.TxtNombreCli = new System.Windows.Forms.TextBox();
            this.TxtEmailCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TxtActividad = new System.Windows.Forms.TextBox();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Location = new System.Drawing.Point(1, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Administrador de clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GridListado
            // 
            this.GridListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListado.Location = new System.Drawing.Point(25, 269);
            this.GridListado.Name = "GridListado";
            this.GridListado.Size = new System.Drawing.Size(878, 226);
            this.GridListado.TabIndex = 38;
            this.GridListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListado_CellContentClick);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.ForeColor = System.Drawing.Color.White;
            this.btnAgregarC.Location = new System.Drawing.Point(726, 53);
            this.btnAgregarC.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(177, 42);
            this.btnAgregarC.TabIndex = 39;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnEditarC
            // 
            this.btnEditarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(114)))), ((int)(((byte)(31)))));
            this.btnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarC.ForeColor = System.Drawing.Color.White;
            this.btnEditarC.Location = new System.Drawing.Point(726, 125);
            this.btnEditarC.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(177, 42);
            this.btnEditarC.TabIndex = 40;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.UseVisualStyleBackColor = false;
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarC.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.ForeColor = System.Drawing.Color.White;
            this.btnEliminarC.Location = new System.Drawing.Point(726, 201);
            this.btnEliminarC.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(177, 42);
            this.btnEliminarC.TabIndex = 41;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            // 
            // TxtRutCli
            // 
            this.TxtRutCli.Location = new System.Drawing.Point(146, 60);
            this.TxtRutCli.Name = "TxtRutCli";
            this.TxtRutCli.Size = new System.Drawing.Size(194, 23);
            this.TxtRutCli.TabIndex = 42;
            this.TxtRutCli.TextChanged += new System.EventHandler(this.TxtRutCli_TextChanged);
            // 
            // TxtRazonSo
            // 
            this.TxtRazonSo.Location = new System.Drawing.Point(146, 105);
            this.TxtRazonSo.Name = "TxtRazonSo";
            this.TxtRazonSo.Size = new System.Drawing.Size(194, 23);
            this.TxtRazonSo.TabIndex = 43;
            this.TxtRazonSo.TextChanged += new System.EventHandler(this.TxtRazonSo_TextChanged);
            // 
            // TxtDireccionCli
            // 
            this.TxtDireccionCli.Location = new System.Drawing.Point(492, 201);
            this.TxtDireccionCli.Name = "TxtDireccionCli";
            this.TxtDireccionCli.Size = new System.Drawing.Size(171, 23);
            this.TxtDireccionCli.TabIndex = 49;
            this.TxtDireccionCli.TextChanged += new System.EventHandler(this.TxtDireccionCli_TextChanged);
            // 
            // TxtTelefonoCli
            // 
            this.TxtTelefonoCli.Location = new System.Drawing.Point(492, 155);
            this.TxtTelefonoCli.Name = "TxtTelefonoCli";
            this.TxtTelefonoCli.Size = new System.Drawing.Size(171, 23);
            this.TxtTelefonoCli.TabIndex = 48;
            this.TxtTelefonoCli.TextChanged += new System.EventHandler(this.TxtTelefonoCli_TextChanged);
            // 
            // TxtNombreCli
            // 
            this.TxtNombreCli.Location = new System.Drawing.Point(492, 108);
            this.TxtNombreCli.Name = "TxtNombreCli";
            this.TxtNombreCli.Size = new System.Drawing.Size(171, 23);
            this.TxtNombreCli.TabIndex = 47;
            this.TxtNombreCli.TextChanged += new System.EventHandler(this.TxtNombreCli_TextChanged);
            // 
            // TxtEmailCli
            // 
            this.TxtEmailCli.Location = new System.Drawing.Point(492, 63);
            this.TxtEmailCli.Name = "TxtEmailCli";
            this.TxtEmailCli.Size = new System.Drawing.Size(171, 23);
            this.TxtEmailCli.TabIndex = 46;
            this.TxtEmailCli.TextChanged += new System.EventHandler(this.TxtEmailCli_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Rut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Razon Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(400, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(416, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Email:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Tipo Empresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Actividad Empresa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(394, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(391, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Direccion:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 58;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(165, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 59;
            // 
            // TxtActividad
            // 
            this.TxtActividad.Location = new System.Drawing.Point(146, 198);
            this.TxtActividad.Name = "TxtActividad";
            this.TxtActividad.Size = new System.Drawing.Size(100, 23);
            this.TxtActividad.TabIndex = 60;
            this.TxtActividad.TextChanged += new System.EventHandler(this.TxtActividad_TextChanged);
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(146, 155);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(100, 23);
            this.TxtEmpresa.TabIndex = 61;
            this.TxtEmpresa.TextChanged += new System.EventHandler(this.TxtEmpresa_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.ControlBox = false;
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtActividad);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDireccionCli);
            this.Controls.Add(this.TxtTelefonoCli);
            this.Controls.Add(this.TxtNombreCli);
            this.Controls.Add(this.TxtEmailCli);
            this.Controls.Add(this.TxtRazonSo);
            this.Controls.Add(this.TxtRutCli);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.GridListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "modulo clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridListado;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.TextBox TxtRutCli;
        private System.Windows.Forms.TextBox TxtRazonSo;
        private System.Windows.Forms.TextBox TxtDireccionCli;
        private System.Windows.Forms.TextBox TxtTelefonoCli;
        private System.Windows.Forms.TextBox TxtNombreCli;
        private System.Windows.Forms.TextBox TxtEmailCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox TxtActividad;
        private System.Windows.Forms.TextBox TxtEmpresa;
    }
}

