using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidosconComisionExterna
    {
        public string Sucursal { get; set; } = null!;
        public string NroPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public string? Cliente { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal TotalPedido { get; set; }
        public string TipoCompVenta { get; set; } = null!;
        public string NroCompVenta { get; set; } = null!;
        public DateTime FechaCompVenta { get; set; }
        public decimal TotalCompVenta { get; set; }
        public decimal? MontoComision { get; set; }
        public string? Responsable { get; set; }
    }
}
