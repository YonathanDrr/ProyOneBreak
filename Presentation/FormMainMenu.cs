using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
namespace Presentation
{
    public partial class FormMainMenu : Form
    {


        public FormMainMenu()
        {
            InitializeComponent();
        }
        #region "FUNCIONALIDADES DEL FORMULARIO// FUNCTIONALITIES OF THE FORM"
        // 'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO//------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL/// 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR/ESQUINA//
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


      //MINIMIZAR, MAXIMIZAR, RESTAURAR EL FORMULARIO
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //ARRASTRAR/ MOVER EL FORMULARIO//
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }    

#endregion 
        #region OPEN AND CLOSE FORM METHODS
        //METODO DE ABRIR FORMULARIO EN EL PANEL CONTENEDOR//ABRIR VARIOS FORMULARIOS DENTRO DE PANEL 
        private void openFormOnPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca el formulario en la colecion.
            //si el formulario/instancia no existe/crea           
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(closedForm);
            }

            else {
                //si la Formulario / instancia existe, lo traemos a frente
                formulario.BringToFront();
            }
        }

        //METODO/EVENTO AL CERRAR FORMS//
        private void closedForm(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
            {
                btnPacient.BackColor = Color.FromArgb(37, 54, 75);
                //mas
            }
               
            if (Application.OpenForms["Form2"] == null){
                btnClinicalHistory.BackColor = Color.FromArgb(37, 54, 75);
                //mas

            }
            if (Application.OpenForms["Form3"] == null)
            {
               btnCalendar.BackColor = Color.FromArgb(37, 54, 75);
                //mas

            }
            if (Application.OpenForms["FormUserProfile"] == null)
            {
                timer1.Stop(); 
            //Detenemos el temporizador una vez que el usuario termine de editar su perfil y cierre el formulario
           
            }
        }

        #endregion
        #region LOGOUT AND APPLICATION EXIT

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de salir de la Aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar sesion?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        #endregion
        //LOAD
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            seecurity();
            LoadUserData();
            ManagePermissions();
        }

        private void LoadUserData()
        {
            lblUserName.Text = UserCache.LoginName;
            lblPosition.Text = UserCache.Position;
            lblEmail.Text = UserCache.Email;
        }

        private void seecurity() {
            var userModel = new UserModel();
            if (userModel.securityLogin() == false) {
                MessageBox.Show("Error Fatal, se detectó que está intentando acceder al sistema sin credenciales, por favor inicie sesion e indetifiquese\n");
                Application.Exit();
            }
        }
        private void ManagePermissions()
        {
            //Permisos
            if (UserCache.Position == Positions.Contabilidad) 
            {
                btnPacient.Enabled = false;
                btnClinicalHistory.Enabled = false;
            }
            if (UserCache.Position == Positions.Recepcionista)
            {
            
            }
            if (UserCache.Position == Positions.Administrador)
            {
                //Codes
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadUserData();   //actualizar los datos del usuario en el menu de este formulario, cada 1 segundo al momento de la edicion en el formulario perfil de usuario.
        }
        //"BUTTONS TO OPEN FORMS "
        private void btnPacient_Click(object sender, EventArgs e)
        {
            openFormOnPanel<Form1>();
            btnPacient.BackColor = Color.FromArgb(0, 100, 182);
        }

        private void btnClinicalHistory_Click(object sender, EventArgs e)
        {
            openFormOnPanel<Form2>();
            btnClinicalHistory.BackColor = Color.FromArgb(0, 100, 182);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            openFormOnPanel<Test_Forms.CrearEventos>();
            btnCalendar.BackColor = Color.FromArgb(0, 100, 182);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openFormOnPanel<FormCreateUser>();
            btnCalendar.BackColor = Color.FromArgb(0, 100, 182);

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormOnPanel<Test_Forms.ListadoContratos>();
            button2.BackColor = Color.FromArgb(0, 100, 182);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormOnPanel<Test_Forms.ListadoClientes>();
            button1.BackColor = Color.FromArgb(0, 100, 182);
        }

        private void ptbProfile_Click(object sender, EventArgs e)
        {
            openFormOnPanel<FormUserProfile>();
            timer1.Start();
        }

        private void linkProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFormOnPanel<FormUserProfile>();
            timer1.Start();
        }


    }
}
