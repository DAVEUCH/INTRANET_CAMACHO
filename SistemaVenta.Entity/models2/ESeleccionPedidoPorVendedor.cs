using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESeleccionPedidoPorVendedor
    {
        public int Id { get; set; }
        public int Idresponsable { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
    }
}
