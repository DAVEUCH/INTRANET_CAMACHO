using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpVentum
    {
        public int Pkid { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal PrecioLista { get; set; }
        public bool AplicaDescuentoConVale { get; set; }
        public decimal BalanceDevolucion { get; set; }
        public decimal BalanceEntregaDevolucion { get; set; }
        public decimal BalanceDescuento { get; set; }
        public bool EscalaPreferencial { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public bool DescuentoFijo { get; set; }
        public int? IddefinicionBonificacion { get; set; }
        public int? IddefinicionDescuento { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Amortizacion { get; set; }
        public bool VentaEspecial { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
