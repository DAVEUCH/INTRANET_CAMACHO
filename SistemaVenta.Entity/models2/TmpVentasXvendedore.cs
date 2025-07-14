using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpVentasXvendedore
    {
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? Categoria { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? PorcVentaSoles { get; set; }
        public decimal? DePorceVenta { get; set; }
        public decimal? CuotaVenta { get; set; }
        public decimal? DeCuotaVentaMax { get; set; }
    }
}
