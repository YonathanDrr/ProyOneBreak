﻿namespace Presentation.Test_Forms
{
    partial class ListadoContratos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoContratos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnListarContra = new System.Windows.Forms.Button();
            this.btnBuscarContra = new System.Windows.Forms.Button();
            this.TxtRutBuscarContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GridListadoContrato = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de contratos";
            // 
            // btnListarContra
            // 
            this.btnListarContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnListarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarContra.ForeColor = System.Drawing.Color.White;
            this.btnListarContra.Location = new System.Drawing.Point(309, 58);
            this.btnListarContra.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnListarContra.Name = "btnListarContra";
            this.btnListarContra.Size = new System.Drawing.Size(104, 30);
            this.btnListarContra.TabIndex = 40;
            this.btnListarContra.Text = "Listar Contratos";
            this.btnListarContra.UseVisualStyleBackColor = false;
            this.btnListarContra.Click += new System.EventHandler(this.btnListarContra_Click);
            // 
            // btnBuscarContra
            // 
            this.btnBuscarContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(114)))), ((int)(((byte)(31)))));
            this.btnBuscarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarContra.ForeColor = System.Drawing.Color.White;
            this.btnBuscarContra.Location = new System.Drawing.Point(191, 58);
            this.btnBuscarContra.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscarContra.Name = "btnBuscarContra";
            this.btnBuscarContra.Size = new System.Drawing.Size(104, 30);
            this.btnBuscarContra.TabIndex = 41;
            this.btnBuscarContra.Text = "Buscar Contratos";
            this.btnBuscarContra.UseVisualStyleBackColor = false;
            this.btnBuscarContra.Click += new System.EventHandler(this.btnBuscarContra_Click);
            // 
            // TxtRutBuscarContrato
            // 
            this.TxtRutBuscarContrato.Location = new System.Drawing.Point(65, 68);
            this.TxtRutBuscarContrato.Name = "TxtRutBuscarContrato";
            this.TxtRutBuscarContrato.Size = new System.Drawing.Size(100, 20);
            this.TxtRutBuscarContrato.TabIndex = 42;
            this.TxtRutBuscarContrato.TextChanged += new System.EventHandler(this.TxtRutBuscarContrato_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Rut";
            // 
            // GridListadoContrato
            // 
            this.GridListadoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListadoContrato.Location = new System.Drawing.Point(12, 145);
            this.GridListadoContrato.Name = "GridListadoContrato";
            this.GridListadoContrato.Size = new System.Drawing.Size(871, 286);
            this.GridListadoContrato.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(792, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(895, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridListadoContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRutBuscarContrato);
            this.Controls.Add(this.btnBuscarContra);
            this.Controls.Add(this.btnListarContra);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoContratos";
            this.Text = "ListadoContratos";
            ((System.ComponentModel.ISupportInitialize)(this.GridListadoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarContra;
        private System.Windows.Forms.Button btnBuscarContra;
        private System.Windows.Forms.TextBox TxtRutBuscarContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridListadoContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}