namespace Presentation.Test_Forms
{
    partial class ListadoClientes
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
            this.TxtBuscarRutCli = new System.Windows.Forms.TextBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnListarCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBuscarRutCli
            // 
            this.TxtBuscarRutCli.Location = new System.Drawing.Point(99, 68);
            this.TxtBuscarRutCli.Name = "TxtBuscarRutCli";
            this.TxtBuscarRutCli.Size = new System.Drawing.Size(100, 20);
            this.TxtBuscarRutCli.TabIndex = 46;
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(114)))), ((int)(((byte)(31)))));
            this.btnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCli.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCli.Location = new System.Drawing.Point(214, 58);
            this.btnBuscarCli.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(104, 30);
            this.btnBuscarCli.TabIndex = 45;
            this.btnBuscarCli.Text = "Buscar Clientes";
            this.btnBuscarCli.UseVisualStyleBackColor = false;
            // 
            // btnListarCli
            // 
            this.btnListarCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnListarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarCli.ForeColor = System.Drawing.Color.White;
            this.btnListarCli.Location = new System.Drawing.Point(332, 58);
            this.btnListarCli.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnListarCli.Name = "btnListarCli";
            this.btnListarCli.Size = new System.Drawing.Size(104, 30);
            this.btnListarCli.TabIndex = 44;
            this.btnListarCli.Text = "Listar Clientes";
            this.btnListarCli.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Listado de Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rut Cliente";
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(895, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBuscarRutCli);
            this.Controls.Add(this.btnBuscarCli);
            this.Controls.Add(this.btnListarCli);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoClientes";
            this.Text = "ListadoClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBuscarRutCli;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnListarCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}