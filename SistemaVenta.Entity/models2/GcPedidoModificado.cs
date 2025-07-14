using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcPedidoModificado
    {
        public int? Idpedido { get; set; }
        public int? Idusuario { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Anulaped { get; set; }
    }
}
