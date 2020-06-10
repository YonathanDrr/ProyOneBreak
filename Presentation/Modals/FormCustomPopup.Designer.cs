namespace Presentation
{
    partial class FormCustomPopup
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
            this.Label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Location = new System.Drawing.Point(90, 199);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(348, 17);
            this.Label2.TabIndex = 16;
            this.Label2.Text = " Por razones de seguridad y para proteger su cuenta,";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Tomato;
            this.lblResult.Location = new System.Drawing.Point(30, 87);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(199, 19);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = " introduce tu contraseña actual";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label1.Location = new System.Drawing.Point(29, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(196, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Ingrese su contraseña";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(84, 142);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(350, 45);
            this.btnAccept.TabIndex = 13;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(34, 56);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(427, 26);
            this.txtPass.TabIndex = 12;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(90, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = " le pedimos que ingrese su contraseña actual.";
            // 
            // FormCustomPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCustomPopup";
            this.Load += new System.EventHandler(this.FormCustomPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblResult;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnAccept;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.Label label3;
    }
}