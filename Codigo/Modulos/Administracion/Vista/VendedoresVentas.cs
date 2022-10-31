using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ComprasModelo;

namespace ComprasVista
{
    
    
    public partial class VendedoresVentas : Form
    {

        SentenciasF sn = new SentenciasF();

        public VendedoresVentas()
        {
            InitializeComponent();
            llenarcombobox();
        }

        public void llenarcombobox()
        {
            cbxIdv.DataSource = null;
            cbxIdv.Items.Clear();
            try
            {
                OdbcDataAdapter data = sn.cargardatos();
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbxIdv.ValueMember = "pk_id_trabajador";
                cbxIdv.DisplayMember = "pk_id_trabajador";
                cbxIdv.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar " + e.Message);
            }


        }


        private void VendedoresVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
