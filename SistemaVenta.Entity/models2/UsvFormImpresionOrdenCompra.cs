using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvFormImpresionOrdenCompra
    {
        public int Pkid { get; set; }
        public int ProveedorId { get; set; }
        public string Proveedornombre { get; set; } = null!;
        public string? Proveedorruc { get; set; }
        public string Sucursalnombre { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string NumeroOc { get; set; } = null!;
        public DateTime FechaOc { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string Productocod { get; set; } = null!;
        public string Productodes { get; set; } = null!;
        public string Productound { get; set; } = null!;
        public decimal Productocant { get; set; }
        public decimal? Productocu { get; set; }
        public decimal Total { get; set; }
        public string Vendedornombre { get; set; } = null!;
    }
}
