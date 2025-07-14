using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoSeguimientoPedido
    {
        public string Nombre { get; set; } = null!;
        public int? NroVendedores { get; set; }
        public int? TotalVendedores { get; set; }
        public int? Porcentaje { get; set; }
        public int? NroPedidos { get; set; }
        public decimal? Importe { get; set; }
    }
}
