using System;
using System.Data;
using System.Windows.Forms;
using Common.Cache;
using System.Data.SqlClient;
namespace Presentation
{
    public partial class Form2 : Form
    {

        public const Double UF = 28697;
        public Form2()
        {
            
            InitializeComponent();
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random();
            ///Manage Permissions
            if (UserCache.Position == Positions.Recepcionista) 
            {                            
                btnRemove.Enabled = false;
            }
            if (UserCache.Position == Positions.Contabilidad)
            {
                btnRemove.Enabled = false;
            }                
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnAuxListar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (RutClienteContrato.Text != "")
                {




                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = Connect.Connection.conexion;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();

                    cmd = new SqlCommand("InsertarContrato", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Numero", TxtNroContrato.Text);
                    cmd.Parameters.AddWithValue("@RutCliente", RutClienteContrato.Text);
                    cmd.Parameters.AddWithValue("@IdModalidad", BoxModalidad.Text);
                    cmd.Parameters.AddWithValue("@IdTipoEvento", BoxEvento.Text);
                    cmd.Parameters.AddWithValue("@FechaHoraInicio", TxtHoraInicio.Text);
                    cmd.Parameters.AddWithValue("@FechaHoraTermino", TxtHoraFin.Text);
                    cmd.Parameters.AddWithValue("@Asistentes", TxtAsistentes.Text);
                    cmd.Parameters.AddWithValue("@PersonalAdicional", TxtMasPersonal.Text);
                    cmd.Parameters.AddWithValue("@Realizado", BoxRealizado.Text);
                    cmd.Parameters.AddWithValue("@ValorTotalContrato", TxtValorTotal.Text);
                    cmd.Parameters.AddWithValue("@Observaciones", TxtObservaciones.Text);
                    cmd.Parameters.AddWithValue("@CreacionC", TimeInicio.Text);
                    cmd.Parameters.AddWithValue("@TerminoC", TimeFin.Text);


                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Contrato Registrado correctamente");

                }
                else
                {

                    MessageBox.Show("Rut es Obligatorio!!!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            Random();



        }

        private void ValorContrato() 
        {
            int   coffe  =10;
            int   cocktail = 20;
            int   cenas = 30;
            Double Totalcoffe = 0;
            Double Totalcocktail = 0;
            Double Totalcenas = 0;

            Double TotalNoUf = 0;
            Double TotalUf = 0;




            if (BoxEvento.Text == "Cenas") 
            {
                int ParseAsistentes = Int16.Parse(TxtAsistentes.Text);
                if (ParseAsistentes >= 1 || ParseAsistentes <= 20)
                {
                    Double recargoPersonal = 0;
                    var recargoCenas = 3;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);

                    if (ParsePersonal == 2)
                    {

                        recargoPersonal = 2;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 3)
                    {

                        recargoPersonal = 3;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 4)
                    {

                        recargoPersonal = 3.5;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal > 4)
                    {
                        var adicional = 0.5;
                        Double recargoPersonalA = 3.5;
                        Totalcenas = adicional * ParsePersonal;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonalA + Totalcenas;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                }
                if (ParseAsistentes >= 21 || ParseAsistentes <= 50)
                {

                    Double recargoPersonal = 0;
                    var recargoCenas = 5;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);


                    if (ParsePersonal == 2)
                    {

                        recargoPersonal = 2;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 3)
                    {

                        recargoPersonal = 3;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 4)
                    {

                        recargoPersonal = 3.5;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal > 4)
                    {
                        var adicional = 0.5;
                        Double recargoPersonalA = 3.5;
                        Totalcenas = adicional * ParsePersonal;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonalA + Totalcenas;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                }
                if (ParseAsistentes > 50)
                {
                    Double recargoPersonal = 0;
                    var recargoCenas = 5;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);


                    if (ParsePersonal == 2)
                    {

                        recargoPersonal = 2;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 3)
                    {

                        recargoPersonal = 3;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal == 4)
                    {

                        recargoPersonal = 3.5;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonal;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                    if (ParsePersonal > 4)
                    {
                        var adicional = 0.5;
                        double recargoPersonalA = 3.5;
                        Totalcenas = adicional * ParsePersonal;
                        TotalNoUf = cenas + ParseAsistentes + ParsePersonal;
                        TotalUf = (TotalNoUf * UF) + recargoCenas + recargoPersonalA + Totalcenas;
                        TxtValorTotal.Text = TotalUf.ToString();

                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////
            if (BoxEvento.Text == "Cocktail")
            {
                int ParseAsistentes = Int16.Parse(TxtAsistentes.Text);
                if (ParseAsistentes >= 1 || ParseAsistentes <= 20)
                {

                    var recargoCocktail = 4;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = cocktail + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCocktail;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
                if (ParseAsistentes >= 21 || ParseAsistentes <= 50)
                {
                    //int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);

                    var recargoCocktail = 6;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = cocktail + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCocktail;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
                if (ParseAsistentes > 50)
                {
                    //int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);  

                    var recargoCenas = 2 * (ParseAsistentes / 20);
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = cocktail + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCenas;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
            }
            if (BoxEvento.Text == "Coffee Break")
            {
                int ParseAsistentes = Int16.Parse(TxtAsistentes.Text);
                if (ParseAsistentes >= 1 || ParseAsistentes <= 20)
                {

                    var recargoCocktail = 1.5;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = coffe + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCocktail;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
                if (ParseAsistentes >= 21 || ParseAsistentes <= 50)
                {
                    //int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);

                    var recargoCocktail = 1.2;
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = coffe + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCocktail;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
                if (ParseAsistentes > 50)
                {
                    //int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);  

                    var recargoCenas = 1 * (ParseAsistentes / 20);
                    int ParsePersonal = Int16.Parse(TxtMasPersonal.Text);
                    TotalNoUf = coffe + ParseAsistentes + ParsePersonal;

                    TotalUf = (TotalNoUf * UF) + recargoCenas;

                    TxtValorTotal.Text = TotalUf.ToString();

                }
            }

        }

        private void Random() 
        {


            int random1;
            string l1;
            Random ran = new Random();
            random1 = ran.Next();
            l1 = Convert.ToString(random1);
            TxtNroContrato.Text = l1.ToString();
       


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            ValorContrato();
        }

     

      
    }
}
