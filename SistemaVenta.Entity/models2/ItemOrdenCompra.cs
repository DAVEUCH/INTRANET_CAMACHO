using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemOrdenCompra
    {
        public int Pkid { get; set; }
        public decimal PrecioLista { get; set; }
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal DescuentoC { get; set; }
        public decimal DescuentoD { get; set; }
        public decimal DescuentoE { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal BalanceFacturacion { get; set; }
        public bool ActualizarListaPreciosProveedor { get; set; }
        public decimal CantidadAentregar { get; set; }
        public decimal CostoParalelo { get; set; }
        public decimal CantidadPedida { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
