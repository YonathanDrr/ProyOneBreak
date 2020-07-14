namespace Presentation.Test_Forms
{
    partial class Cocktail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cocktail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BoxAmbientacion = new System.Windows.Forms.ComboBox();
            this.TxtMusicaCliente = new System.Windows.Forms.TextBox();
            this.Vegetariano = new System.Windows.Forms.Label();
            this.TxtMusica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NroContratoCoktail = new System.Windows.Forms.TextBox();
            this.btnAgregarCocktail = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // BoxAmbientacion
            // 
            this.BoxAmbientacion.FormattingEnabled = true;
            this.BoxAmbientacion.Items.AddRange(new object[] {
            "Básica",
            "Personalizada"});
            this.BoxAmbientacion.Location = new System.Drawing.Point(159, 81);
            this.BoxAmbientacion.Name = "BoxAmbientacion";
            this.BoxAmbientacion.Size = new System.Drawing.Size(121, 21);
            this.BoxAmbientacion.TabIndex = 65;
            this.BoxAmbientacion.SelectedIndexChanged += new System.EventHandler(this.BoxAmbientacion_SelectedIndexChanged);
            // 
            // TxtMusicaCliente
            // 
            this.TxtMusicaCliente.Location = new System.Drawing.Point(159, 159);
            this.TxtMusicaCliente.Name = "TxtMusicaCliente";
            this.TxtMusicaCliente.Size = new System.Drawing.Size(121, 20);
            this.TxtMusicaCliente.TabIndex = 67;
            this.TxtMusicaCliente.TextChanged += new System.EventHandler(this.TxtMusicaCliente_TextChanged);
            // 
            // Vegetariano
            // 
            this.Vegetariano.AutoSize = true;
            this.Vegetariano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vegetariano.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vegetariano.Location = new System.Drawing.Point(19, 79);
            this.Vegetariano.Name = "Vegetariano";
            this.Vegetariano.Size = new System.Drawing.Size(140, 20);
            this.Vegetariano.TabIndex = 69;
            this.Vegetariano.Text = "Tipo Ambientacion";
            this.Vegetariano.Click += new System.EventHandler(this.Vegetariano_Click);
            // 
            // TxtMusica
            // 
            this.TxtMusica.FormattingEnabled = true;
            this.TxtMusica.Items.AddRange(new object[] {
            "Regeton",
            "Bachata",
            "Cumbia",
            "Salsa",
            "Merengue",
            "Romantica",
            "80",
            "90",
            "Rock",
            "Pop",
            "Latin",
            "Trap",
            "Metal",
            "Ninguna"});
            this.TxtMusica.Location = new System.Drawing.Point(159, 121);
            this.TxtMusica.Name = "TxtMusica";
            this.TxtMusica.Size = new System.Drawing.Size(121, 21);
            this.TxtMusica.TabIndex = 70;
            this.TxtMusica.SelectedIndexChanged += new System.EventHandler(this.TxtMusica_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Musica Ambiental";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Musica Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "NroContrato";
            // 
            // NroContratoCoktail
            // 
            this.NroContratoCoktail.Location = new System.Drawing.Point(159, 39);
            this.NroContratoCoktail.Name = "NroContratoCoktail";
            this.NroContratoCoktail.Size = new System.Drawing.Size(121, 20);
            this.NroContratoCoktail.TabIndex = 74;
            // 
            // btnAgregarCocktail
            // 
            this.btnAgregarCocktail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCocktail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnAgregarCocktail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCocktail.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCocktail.Location = new System.Drawing.Point(329, 27);
            this.btnAgregarCocktail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAgregarCocktail.Name = "btnAgregarCocktail";
            this.btnAgregarCocktail.Size = new System.Drawing.Size(149, 42);
            this.btnAgregarCocktail.TabIndex = 75;
            this.btnAgregarCocktail.Text = "Agregar";
            this.btnAgregarCocktail.UseVisualStyleBackColor = false;
            this.btnAgregarCocktail.Click += new System.EventHandler(this.btnAgregarCocktail_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(329, 81);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(149, 42);
            this.BtnSalir.TabIndex = 76;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(67)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(664, 216);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnAgregarCocktail);
            this.Controls.Add(this.NroContratoCoktail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMusica);
            this.Controls.Add(this.Vegetariano);
            this.Controls.Add(this.TxtMusicaCliente);
            this.Controls.Add(this.BoxAmbientacion);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cocktail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cocktail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox BoxAmbientacion;
        private System.Windows.Forms.TextBox TxtMusicaCliente;
        private System.Windows.Forms.Label Vegetariano;
        private System.Windows.Forms.ComboBox TxtMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NroContratoCoktail;
        private System.Windows.Forms.Button btnAgregarCocktail;
        private System.Windows.Forms.Button BtnSalir;
    }
}