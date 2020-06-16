using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using System.Windows.Forms;
using Domain;
using System.Runtime.InteropServices;


namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///Manage Permissions
            if (UserCache.Position == Positions.Recepcionista) {            
                btnAgregarC.Enabled = false;
                btnEditarC.Enabled = false;
                btnEliminarC.Enabled = false;
            }
            if (UserCache.Position == Positions.Contabilidad) {
                btnEliminarC.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void GridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*
        private void btnAgregarC_Click(object sender, EventArgs e)
        { }*/
          
            private void btnAgregarC_Click(object sender, EventArgs e)
            {
                if (TxtRutCli.Text.Trim() == "")
                {

                    var userClient = new UserClient(
                           rutCliente: TxtRutCli.Text,
                           razonSocial:TxtRazonSo.Text,
                           nombreCli: TxtNombreCli.Text,
                           email: TxtEmailCli.Text,
                           direccion: TxtDireccionCli.Text,
                           telefono: TxtTelefonoCli.Text,
                           actividadEmp: TxtActividad.Text,
                           tipoEmp: TxtEmpresa.Text
                        );
                    string result = userClient.registerCliente();
                    MessageBox.Show(result);
                    if (userClient.validUser == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        TxtRutCli.Focus();
                    }
                }

            }
             
            private void TxtRutCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRazonSo_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void TxtEmailCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccionCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtActividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
