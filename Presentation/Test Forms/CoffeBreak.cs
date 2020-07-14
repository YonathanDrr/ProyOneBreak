using System;

using System.Data;

using System.Windows.Forms;

using System.Data.SqlClient;


namespace Presentation.Test_Forms
{
    public partial class CoffeBreak : Form
    {
        private string nrocontrato;
        public CoffeBreak()
        {
            InitializeComponent();
        }

        public CoffeBreak( string m1)
        {
            InitializeComponent();

            NroContratoCoffe.Text = m1;


        }
        public string Nrocontrato
        {
            set 
            {
                nrocontrato = value;
                NroContratoCoffe.Text = nrocontrato;
            }
          
        }



        public void btnAdd_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (BoxVegetariana.Text != "")
                {




                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarCoffeBreak", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Numero", NroContratoCoffe.Text);
                    cmd.Parameters.AddWithValue("@Condicion", BoxVegetariana.Text);
              

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

        private void NroContratoCoffe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSalirCoffe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
