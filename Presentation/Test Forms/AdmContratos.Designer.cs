namespace Presentation
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.TxtNroContrato = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.TxtAsistentes = new System.Windows.Forms.TextBox();
            this.TxtHoraFin = new System.Windows.Forms.TextBox();
            this.TxtHoraInicio = new System.Windows.Forms.TextBox();
            this.RutClienteContrato = new System.Windows.Forms.TextBox();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxModalidad = new System.Windows.Forms.ComboBox();
            this.BoxEvento = new System.Windows.Forms.ComboBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtMasPersonal = new System.Windows.Forms.ComboBox();
            this.TimeInicio = new System.Windows.Forms.DateTimePicker();
            this.TimeFin = new System.Windows.Forms.DateTimePicker();
            this.BoxRealizado = new System.Windows.Forms.ComboBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.GridContrato = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAdiccional = new System.Windows.Forms.Button();
            this.BtnAdiccionalCoktail = new System.Windows.Forms.Button();
            this.BtnAdicionalCoffe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(297, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Administracion de contrato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(722, 133);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(177, 42);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Eliminar";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(114)))), ((int)(((byte)(31)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(722, 80);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 42);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // TxtNroContrato
            // 
            this.TxtNroContrato.Enabled = false;
            this.TxtNroContrato.Location = new System.Drawing.Point(114, 45);
            this.TxtNroContrato.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtNroContrato.Name = "TxtNroContrato";
            this.TxtNroContrato.ShortcutsEnabled = false;
            this.TxtNroContrato.Size = new System.Drawing.Size(81, 23);
            this.TxtNroContrato.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(722, 26);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 42);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Ebrima", 12F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // TxtAsistentes
            // 
            this.TxtAsistentes.Location = new System.Drawing.Point(496, 137);
            this.TxtAsistentes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtAsistentes.MaxLength = 2;
            this.TxtAsistentes.Name = "TxtAsistentes";
            this.TxtAsistentes.Size = new System.Drawing.Size(111, 23);
            this.TxtAsistentes.TabIndex = 31;
            // 
            // TxtHoraFin
            // 
            this.TxtHoraFin.Location = new System.Drawing.Point(496, 102);
            this.TxtHoraFin.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtHoraFin.MaxLength = 5;
            this.TxtHoraFin.Name = "TxtHoraFin";
            this.TxtHoraFin.Size = new System.Drawing.Size(111, 23);
            this.TxtHoraFin.TabIndex = 30;
            // 
            // TxtHoraInicio
            // 
            this.TxtHoraInicio.Location = new System.Drawing.Point(496, 67);
            this.TxtHoraInicio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtHoraInicio.MaxLength = 5;
            this.TxtHoraInicio.Name = "TxtHoraInicio";
            this.TxtHoraInicio.Size = new System.Drawing.Size(111, 23);
            this.TxtHoraInicio.TabIndex = 29;
            // 
            // RutClienteContrato
            // 
            this.RutClienteContrato.Location = new System.Drawing.Point(113, 147);
            this.RutClienteContrato.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RutClienteContrato.MaxLength = 10;
            this.RutClienteContrato.Name = "RutClienteContrato";
            this.RutClienteContrato.Size = new System.Drawing.Size(122, 23);
            this.RutClienteContrato.TabIndex = 32;
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Location = new System.Drawing.Point(496, 239);
            this.TxtValorTotal.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(111, 23);
            this.TxtValorTotal.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nro Contrato";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fecha.Location = new System.Drawing.Point(6, 78);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(95, 20);
            this.Fecha.TabIndex = 39;
            this.Fecha.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rut Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(391, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Modalidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(8, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tipo Evento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(389, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Valor Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(389, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Realizado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(389, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Mas personal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(389, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Asistentes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(389, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Hora Final";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(389, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 49;
            this.label13.Text = "Hora Inicio";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(722, 217);
            this.TxtObservaciones.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtObservaciones.MaxLength = 150;
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(179, 58);
            this.TxtObservaciones.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(718, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Observaciones";
            // 
            // BoxModalidad
            // 
            this.BoxModalidad.FormattingEnabled = true;
            this.BoxModalidad.Items.AddRange(new object[] {
            "Quick Cocktail",
            "Ambient Cocktail",
            "Ejecutiva",
            "Celebración",
            "Day Break",
            "Light Break",
            "Journal Break"});
            this.BoxModalidad.Location = new System.Drawing.Point(496, 34);
            this.BoxModalidad.Name = "BoxModalidad";
            this.BoxModalidad.Size = new System.Drawing.Size(111, 24);
            this.BoxModalidad.TabIndex = 52;
            this.BoxModalidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BoxEvento
            // 
            this.BoxEvento.FormattingEnabled = true;
            this.BoxEvento.Items.AddRange(new object[] {
            "Cenas",
            "Cocktail",
            "Coffee Break"});
            this.BoxEvento.Location = new System.Drawing.Point(113, 184);
            this.BoxEvento.Name = "BoxEvento";
            this.BoxEvento.Size = new System.Drawing.Size(122, 24);
            this.BoxEvento.TabIndex = 53;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerar.BackColor = System.Drawing.Color.Gray;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.ForeColor = System.Drawing.Color.White;
            this.BtnGenerar.Location = new System.Drawing.Point(224, 42);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(78, 26);
            this.BtnGenerar.TabIndex = 54;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // TxtMasPersonal
            // 
            this.TxtMasPersonal.FormattingEnabled = true;
            this.TxtMasPersonal.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.TxtMasPersonal.Location = new System.Drawing.Point(496, 169);
            this.TxtMasPersonal.Name = "TxtMasPersonal";
            this.TxtMasPersonal.Size = new System.Drawing.Size(111, 24);
            this.TxtMasPersonal.TabIndex = 55;
            // 
            // TimeInicio
            // 
            this.TimeInicio.Location = new System.Drawing.Point(114, 82);
            this.TimeInicio.Name = "TimeInicio";
            this.TimeInicio.Size = new System.Drawing.Size(200, 23);
            this.TimeInicio.TabIndex = 56;
            // 
            // TimeFin
            // 
            this.TimeFin.Location = new System.Drawing.Point(114, 117);
            this.TimeFin.Name = "TimeFin";
            this.TimeFin.Size = new System.Drawing.Size(200, 23);
            this.TimeFin.TabIndex = 57;
            // 
            // BoxRealizado
            // 
            this.BoxRealizado.FormattingEnabled = true;
            this.BoxRealizado.Items.AddRange(new object[] {
            "Realizado",
            "Aplazado",
            "Rechazado"});
            this.BoxRealizado.Location = new System.Drawing.Point(496, 204);
            this.BoxRealizado.Name = "BoxRealizado";
            this.BoxRealizado.Size = new System.Drawing.Size(111, 24);
            this.BoxRealizado.TabIndex = 58;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalcular.BackColor = System.Drawing.Color.Gray;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(630, 237);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(78, 26);
            this.BtnCalcular.TabIndex = 59;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // GridContrato
            // 
            this.GridContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContrato.Location = new System.Drawing.Point(5, 286);
            this.GridContrato.Name = "GridContrato";
            this.GridContrato.Size = new System.Drawing.Size(911, 229);
            this.GridContrato.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAdiccional
            // 
            this.BtnAdiccional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdiccional.BackColor = System.Drawing.Color.Gray;
            this.BtnAdiccional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdiccional.ForeColor = System.Drawing.Color.White;
            this.BtnAdiccional.Location = new System.Drawing.Point(12, 217);
            this.BtnAdiccional.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnAdiccional.Name = "BtnAdiccional";
            this.BtnAdiccional.Size = new System.Drawing.Size(140, 26);
            this.BtnAdiccional.TabIndex = 62;
            this.BtnAdiccional.Text = "Adicional Cenas";
            this.BtnAdiccional.UseVisualStyleBackColor = false;
            this.BtnAdiccional.Click += new System.EventHandler(this.BtnAdiccional_Click);
            // 
            // BtnAdiccionalCoktail
            // 
            this.BtnAdiccionalCoktail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdiccionalCoktail.BackColor = System.Drawing.Color.Gray;
            this.BtnAdiccionalCoktail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdiccionalCoktail.ForeColor = System.Drawing.Color.White;
            this.BtnAdiccionalCoktail.Location = new System.Drawing.Point(85, 255);
            this.BtnAdiccionalCoktail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnAdiccionalCoktail.Name = "BtnAdiccionalCoktail";
            this.BtnAdiccionalCoktail.Size = new System.Drawing.Size(140, 26);
            this.BtnAdiccionalCoktail.TabIndex = 63;
            this.BtnAdiccionalCoktail.Text = "Adicional Coktail";
            this.BtnAdiccionalCoktail.UseVisualStyleBackColor = false;
            this.BtnAdiccionalCoktail.Click += new System.EventHandler(this.BtnAdiccionalCoktail_Click);
            // 
            // BtnAdicionalCoffe
            // 
            this.BtnAdicionalCoffe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionalCoffe.BackColor = System.Drawing.Color.Gray;
            this.BtnAdicionalCoffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionalCoffe.ForeColor = System.Drawing.Color.White;
            this.BtnAdicionalCoffe.Location = new System.Drawing.Point(166, 217);
            this.BtnAdicionalCoffe.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnAdicionalCoffe.Name = "BtnAdicionalCoffe";
            this.BtnAdicionalCoffe.Size = new System.Drawing.Size(181, 26);
            this.BtnAdicionalCoffe.TabIndex = 65;
            this.BtnAdicionalCoffe.Text = "Adicional Coffee Break";
            this.BtnAdicionalCoffe.UseVisualStyleBackColor = false;
            this.BtnAdicionalCoffe.Click += new System.EventHandler(this.BtnAdicionalCoffe_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(928, 516);
            this.Controls.Add(this.BtnAdicionalCoffe);
            this.Controls.Add(this.BtnAdiccionalCoktail);
            this.Controls.Add(this.BtnAdiccional);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GridContrato);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BoxRealizado);
            this.Controls.Add(this.TimeFin);
            this.Controls.Add(this.TimeInicio);
            this.Controls.Add(this.TxtMasPersonal);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.BoxEvento);
            this.Controls.Add(this.BoxModalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtObservaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.RutClienteContrato);
            this.Controls.Add(this.TxtAsistentes);
            this.Controls.Add(this.TxtHoraFin);
            this.Controls.Add(this.TxtHoraInicio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.TxtNroContrato);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox TxtAsistentes;
        private System.Windows.Forms.TextBox TxtHoraFin;
        private System.Windows.Forms.TextBox TxtHoraInicio;
        private System.Windows.Forms.TextBox RutClienteContrato;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxModalidad;
        private System.Windows.Forms.ComboBox BoxEvento;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.ComboBox TxtMasPersonal;
        private System.Windows.Forms.DateTimePicker TimeInicio;
        private System.Windows.Forms.DateTimePicker TimeFin;
        private System.Windows.Forms.ComboBox BoxRealizado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridView GridContrato;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox TxtNroContrato;
        private System.Windows.Forms.Button BtnAdiccional;
        private System.Windows.Forms.Button BtnAdiccionalCoktail;
        private System.Windows.Forms.Button BtnAdicionalCoffe;
    }
}