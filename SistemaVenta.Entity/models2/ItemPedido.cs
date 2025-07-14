using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemPedido
    {
        public int Pkid { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal BalanceFacturacion { get; set; }
        public decimal PrecioLista { get; set; }
        public bool AplicaDescuentoConVale { get; set; }
        public bool EscalaPreferencial { get; set; }
        public decimal? DescuentoAplicado { get; set; }
        public bool DescuentoFijo { get; set; }
        public decimal CantidadPedida { get; set; }
        public decimal CantidadAentregar { get; set; }
        public int? IddefinicionBonificacion { get; set; }
        public int? IddefinicionDescuento { get; set; }
        public bool VentaEspecial { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
