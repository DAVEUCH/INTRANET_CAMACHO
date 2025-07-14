using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCotizacion
    {
        public int Pkid { get; set; }
        public decimal BalanceFacturacion { get; set; }
        public bool EscalaPreferencial { get; set; }
        public decimal PrecioLista { get; set; }
        public bool AplicaDescuentoConVale { get; set; }
        public decimal DescuentoAplicado { get; set; }
        public bool DescuentoFijo { get; set; }
        public int IddefinicionBonificacion { get; set; }
        public decimal BalanceAtencion { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
