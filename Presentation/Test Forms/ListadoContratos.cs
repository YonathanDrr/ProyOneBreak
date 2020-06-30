using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation.Test_Forms
{
    public partial class ListadoContratos : Form
    {
        public ListadoContratos()
        {
            InitializeComponent();
            
        }

        private void btnListarContra_Click(object sender, EventArgs e)
        {
            MostrarContratos();
        }

        private void btnBuscarContra_Click(object sender, EventArgs e)
        {
            BuscarContratoRut();



        }


        private void MostrarContratos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Connect.Connection.conexion;
                conn.Open();
                da = new SqlDataAdapter("BuscarContratoRut", conn);
                da.Fill(dt);
                GridListadoContrato.DataSource = dt;
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BuscarContratoRut ()
        {
            try
            {
                if (TxtRutBuscarContrato.Text != "")
                {

                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("BuscarContratoRut", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RutCliente", TxtRutBuscarContrato.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cliente Encontrado");
                    


                }
                else

                {
                    MessageBox.Show("Los Clientes solo se pueden buscar por RUT");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("No existe un usuario con ese rut");
            }

        }

    }
}
