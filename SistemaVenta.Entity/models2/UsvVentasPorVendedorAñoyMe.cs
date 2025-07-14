using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorVendedorAñoyMe
    {
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public decimal? ValorVentaSoles { get; set; }
    }
}
