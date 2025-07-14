using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCompra
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public decimal BalanceNotaCredito { get; set; }
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public string EstadoDescuento { get; set; } = null!;
        public int TipoItem { get; set; }
        public int Idincoterm { get; set; }
        public bool Importacion { get; set; }
        public string NumeroReferencia { get; set; } = null!;

        public virtual Cp Pk { get; set; } = null!;
    }
}
