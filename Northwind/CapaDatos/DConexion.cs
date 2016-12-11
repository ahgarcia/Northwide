using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DConexion
    {
        public static String CnBD = "Data Source=ZEUS\\SQL2012; Initial Catalog=BDEmpresa; Integrated Security=SSPI;";
        public static String CnMaster = "Data Source=ZEUS\\SQL2012; Initial Catalog=master; Integrated Security=SSPI;";

        public String ChequearConexion()
        {
            String mensaje = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBD;
                SqlConexion.Open();
                mensaje = "Y";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                SqlConexion.Close();
            }

            return mensaje;
        }
    }
}
