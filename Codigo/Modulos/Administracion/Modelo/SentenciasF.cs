using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace ComprasModelo
{
    public class SentenciasF
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());

            return datatable;
        }

        public OdbcDataAdapter cargardatos()
        {

            string sql = "select pk_id_trabajador from tbl_trabajador order by pk_id_trabajador asc";

            OdbcDataAdapter cmd = new OdbcDataAdapter(sql, con.conexion());
            
            return cmd;

        }
    }
}
