using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HiloYEleganciaDB;Integrated Security=True"
            );
        }
    }
}
