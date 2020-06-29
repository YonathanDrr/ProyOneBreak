using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using System.Data.SqlClient;

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
            MessageBox.Show("Para editar el cliente debe ingresar primero el rut al cual desea hacer cambio \n " +
                "no se puede editar un rut, para realizarlo debe comunicarse con el DB a cargo");
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
     

        private void btnAgregarC_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtRutCli.Text != "" )
                {
                    



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
                    cmd.Parameters.AddWithValue("@ActiEmpresa", BoxActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", BoxTipEmp.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Registrado correctamente");

                    LimpiarTxt();
                    MostrarClientes();




                }
                else {

                    MessageBox.Show("Rut es Obligatorio!!!");
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
            catch (Exception )
            {
             
                MessageBox.Show("Usuario registra contrato Imposible Eliminar");
            }

        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (TxtRutCli.Text != "" && TxtRazonSo.Text != "" && TxtEmailCli.Text != "" && TxtDireccionCli.Text != "" && TxtTelefonoCli.Text != "" &&
                    BoxActividad.Text != "" && BoxTipEmp.Text != "" )
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                 

                    cmd = new SqlCommand("ActualizarCliente", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutCli.Text);
                    cmd.Parameters.AddWithValue("@RazonSocial", TxtRazonSo.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", TxtNombreCli.Text);
                    cmd.Parameters.AddWithValue("@MailContacto", TxtEmailCli.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TxtDireccionCli.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TxtTelefonoCli.Text);
                    cmd.Parameters.AddWithValue("@ActiEmpresa", BoxActividad.Text);
                    cmd.Parameters.AddWithValue("@TipoEmpresa", BoxTipEmp.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente actualizado");

                    LimpiarTxt();
                    MostrarClientes();



                }
                else

                {
                    MessageBox.Show("Todos los campos son Obligatorios ");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void ListarClient1_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void ListarGridCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


           /*

            TxtRutCli.Text = ListarGridCliente.SelectedCells[1].Value.ToString();
            TxtRazonSo.Text = ListarGridCliente.SelectedCells[2].Value.ToString();
            TxtNombreCli.Text = ListarGridCliente.SelectedCells[3].Value.ToString();
            TxtEmailCli.Text = ListarGridCliente.SelectedCells[4].Value.ToString();
            TxtDireccionCli.Text = ListarGridCliente.SelectedCells[5].Value.ToString();
            TxtTelefonoCli.Text = ListarGridCliente.SelectedCells[6].Value.ToString();
            BoxActividad.Text = ListarGridCliente.SelectedCells[7].Value.ToString();
            BoxTipEmp.Text = ListarGridCliente.SelectedCells[8].Value.ToString();
          */


        }

        private void boxTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void BoxTipEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


