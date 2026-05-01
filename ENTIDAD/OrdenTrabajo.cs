using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class OrdenTrabajo
    {
        public int IdOrden;
        public int IdPedido;
        public int AsignadoA; // Id del usuario (costurero)
        public string EstadoProduccion;
    }
}
