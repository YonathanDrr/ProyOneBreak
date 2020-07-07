using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Test_Forms
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
            MostrarClientes();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarCliente();
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
                ListarCliente2.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BuscarCliente()
        {
            try
            {
                if (TxtBuscarRutCli.Text != "")
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da;
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    da = new SqlDataAdapter("BuscarCliente", conn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@buscar", TxtBuscarRutCli.Text);
                    da.Fill(dt);
                    ListarCliente2.DataSource = dt;
                    conn.Close();



                }
                else

                {
                    MessageBox.Show("Los Clientes solo se pueden buscar por RUT o Correo");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex+"No existe un usuario con ese rut");
            }

        }

        private void btnListarCli_Click(object sender, EventArgs e)
        {

            MostrarClientes();

        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
    }
}
