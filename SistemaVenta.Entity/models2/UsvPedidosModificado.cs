using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidosModificado
    {
        public string? Sucursal { get; set; }
        public string? Usuario { get; set; }
        public string Operacion { get; set; } = null!;
        public string Pc { get; set; } = null!;
        public DateTime FechaAuditoriaPedido { get; set; }
        public string? Cliente { get; set; }
        public string? Vendedor { get; set; }
        public string NumeroPedido { get; set; } = null!;
        public DateTime FecEmiPedido { get; set; }
        public decimal TotalPedido { get; set; }
        public string Anulado { get; set; } = null!;
    }
}
