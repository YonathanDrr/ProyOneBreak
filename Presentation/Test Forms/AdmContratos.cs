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
namespace Presentation
{
    public partial class Form2 : Form
    {
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

        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            Random();



        }

        private void Random() 
        {


            int random1, random2, random3;
            string l1, l2, l3;
            Random ran = new Random();
            random1 = ran.Next();
            //random2 = ran.Next(97,123);
            //random3 = ran.Next();
            l1 = Convert.ToString(random1);
            //l2 = Convert.ToString(random2);
            TxtNroContrato.Text = l1.ToString();
            //xtNroContrato.Text = l2.ToString();


        }
    }
}
