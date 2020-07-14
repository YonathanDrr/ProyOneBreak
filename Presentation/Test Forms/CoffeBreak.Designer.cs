namespace Presentation.Test_Forms
{
    partial class CoffeBreak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeBreak));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.BoxVegetariana = new System.Windows.Forms.ComboBox();
            this.Vegetariano = new System.Windows.Forms.Label();
            this.NroContratoCoffe = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.BtnSalirCoffe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(67)))), ((int)(((byte)(205)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(280, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 42);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BoxVegetariana
            // 
            this.BoxVegetariana.FormattingEnabled = true;
            this.BoxVegetariana.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.BoxVegetariana.Location = new System.Drawing.Point(123, 60);
            this.BoxVegetariana.Name = "BoxVegetariana";
            this.BoxVegetariana.Size = new System.Drawing.Size(53, 21);
            this.BoxVegetariana.TabIndex = 67;
            // 
            // Vegetariano
            // 
            this.Vegetariano.AutoSize = true;
            this.Vegetariano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vegetariano.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vegetariano.Location = new System.Drawing.Point(21, 61);
            this.Vegetariano.Name = "Vegetariano";
            this.Vegetariano.Size = new System.Drawing.Size(96, 20);
            this.Vegetariano.TabIndex = 68;
            this.Vegetariano.Text = "Vegetariano";
            // 
            // NroContratoCoffe
            // 
            this.NroContratoCoffe.Location = new System.Drawing.Point(123, 34);
            this.NroContratoCoffe.Name = "NroContratoCoffe";
            this.NroContratoCoffe.Size = new System.Drawing.Size(100, 20);
            this.NroContratoCoffe.TabIndex = 69;
            this.NroContratoCoffe.TextChanged += new System.EventHandler(this.NroContratoCoffe_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl1.Location = new System.Drawing.Point(23, 34);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 20);
            this.lbl1.TabIndex = 70;
            this.lbl1.Text = "NroContrato";
            // 
            // BtnSalirCoffe
            // 
            this.BtnSalirCoffe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalirCoffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.BtnSalirCoffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirCoffe.ForeColor = System.Drawing.Color.White;
            this.BtnSalirCoffe.Location = new System.Drawing.Point(402, 12);
            this.BtnSalirCoffe.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnSalirCoffe.Name = "BtnSalirCoffe";
            this.BtnSalirCoffe.Size = new System.Drawing.Size(96, 42);
            this.BtnSalirCoffe.TabIndex = 71;
            this.BtnSalirCoffe.Text = "Salir";
            this.BtnSalirCoffe.UseVisualStyleBackColor = false;
            this.BtnSalirCoffe.Click += new System.EventHandler(this.BtnSalirCoffe_Click);
            // 
            // CoffeBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(67)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(664, 216);
            this.Controls.Add(this.BtnSalirCoffe);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.NroContratoCoffe);
            this.Controls.Add(this.Vegetariano);
            this.Controls.Add(this.BoxVegetariana);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CoffeBreak";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox BoxVegetariana;
        private System.Windows.Forms.Label Vegetariano;
        private System.Windows.Forms.TextBox NroContratoCoffe;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button BtnSalirCoffe;
    }
}