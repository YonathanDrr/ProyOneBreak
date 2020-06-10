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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
