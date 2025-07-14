using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVrpteVentasPorVendedor
    {
        public DateTime Fecha { get; set; }
        public int SucursalId { get; set; }
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public decimal? ValorVentaSoles { get; set; }
    }
}
