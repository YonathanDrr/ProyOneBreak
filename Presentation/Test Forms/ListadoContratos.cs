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
            ListarContratos();

        }

        private void btnListarContra_Click(object sender, EventArgs e)
        {
            ListarContratos();
        }

        private void btnBuscarContra_Click(object sender, EventArgs e)
        {
            BuscarContratoRut();



        }


        private void ListarContratos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Connect.Connection.conexion;
                conn.Open();
                da = new SqlDataAdapter("ListarContratos", conn);
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
                    DataTable dt = new DataTable();
                    SqlDataAdapter da;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    da = new SqlDataAdapter("BuscarContratoRut", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@RutCliente",TxtRutBuscarContrato.Text);
                    da.Fill(dt);
                    GridListadoContrato.DataSource = dt;
                    conn.Close();



                }
                else

                {
                    MessageBox.Show("Los Contratos solo se pueden buscar por RUT");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex+"No existe un usuario con ese rut");
            }

        }

        private void TxtRutBuscarContrato_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
