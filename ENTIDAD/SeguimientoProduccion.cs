using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class SeguimientoProduccion
    {
        public int Id;
        public int IdPedido;
        public int IdEtapa;
        public string Estado; // Pendiente, En proceso, Completado
    }
}
