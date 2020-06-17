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
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // BuscarClientes();
        }

        private void BuscarClientes()
        {
           


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

                // ListarGridCliente.Columns[1].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnListarCli_Click(object sender, EventArgs e)
        {

            MostrarClientes();

        }
    }
}
