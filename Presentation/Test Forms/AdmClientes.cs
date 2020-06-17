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
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Presentation
{
    public partial class Form1 : Form
    {



        private string spa="1";
        private string eirl = "2";
        private string Ltda = "3";
        private string sa = "4";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MostrarClientes();
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
        SPA
        EIRL
        Limitada
        Sociedad Anónima
        */

        private void btnAgregarC_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtRutCli.Text != "" && boxTipoEmpresa.Text == "SPA")
                {
                    boxTipoEmpresa.Text = spa;




                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSo.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", TxtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@MailContacto", TxtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccionCli.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoCli.Text);
                    cmd.Parameters.AddWithValue("@ActiEmpresa", TxtActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", spa);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Registrado correctamente");

                    LimpiarTxt();
                    MostrarClientes();




                }
                if (TxtRutCli.Text != "" && boxTipoEmpresa.Text == "EIRL")
                {
                    boxTipoEmpresa.Text = eirl;




                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSo.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", TxtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@MailContacto", TxtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccionCli.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoCli.Text);
                    cmd.Parameters.AddWithValue("@ActiEmpresa", TxtActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", eirl);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Registrado correctamente");

                    LimpiarTxt();
                    MostrarClientes();








                }
                if (TxtRutCli.Text != "" && boxTipoEmpresa.Text == "Limitada")
                {
                    boxTipoEmpresa.Text = Ltda;





                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSo.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", TxtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@MailContacto", TxtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccionCli.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoCli.Text);
                    cmd.Parameters.AddWithValue("@ActiEmpresa", TxtActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", Ltda);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Registrado correctamente");

                    LimpiarTxt();
                    MostrarClientes();





                }
                if (TxtRutCli.Text != "" && boxTipoEmpresa.Text == "Sociedad Anónima")
                {
                    boxTipoEmpresa.Text = sa;








                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSo.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", TxtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@MailContacto", TxtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccionCli.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoCli.Text);
                    cmd.Parameters.AddWithValue("@ActiEmpresa", TxtActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", sa);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Registrado correctamente");

                    LimpiarTxt();
                    MostrarClientes();






                }
                else

                {
                    MessageBox.Show("Todos los valores son obligatorios");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  

        }

        private void LimpiarTxt() 
        {
            TxtRutCli.Clear();
            TxtRazonSo.Clear();
            TxtNombreCli.Clear();
            TxtEmailCli.Clear();
            TxtDireccionCli.Clear();
            TxtTelefonoCli.Clear();
            TxtActividad.Clear();
            TxtEmpresa.Clear();
           
        }

        private void MostrarClientes() 
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Connect.Connection.conexion;
                conn.Open();
                da = new SqlDataAdapter("ListarCliente", conn);
                da.Fill(dt);
                ListarGridCliente.DataSource = dt;
                conn.Close();

               // ListarGridCliente.Columns[1].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtRutCli.Text != "")
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("EliminarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Eliminado");
                    MostrarClientes();


                }
                else

                {
                    MessageBox.Show("Los Clientes solo se pueden eliminar por RUT");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {

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

        private void ListarClient1_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void ListarGridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void boxTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}


