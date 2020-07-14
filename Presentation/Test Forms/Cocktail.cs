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
    public partial class Cocktail : Form
    {
        public Cocktail()
        {
            InitializeComponent();
        }

        private void btnAgregarCocktail_Click(object sender, EventArgs e)
        {

            try
            {
                if (NroContratoCoktail.Text != "")
                {




                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCoktail", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Numero", NroContratoCoktail.Text);
                    cmd.Parameters.AddWithValue("@Ambientacion", BoxAmbientacion.Text);
                    cmd.Parameters.AddWithValue("@MusicaAmbiental", TxtMusica.Text);
                    cmd.Parameters.AddWithValue("@MusicaCliente", TxtMusicaCliente.Text);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Registrado correctamente");
                    this.Close();

                }
                else
                {

                    MessageBox.Show("Contrato no existe!!!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


   
















        private void Vegetariano_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtMusicaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMusica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxAmbientacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
