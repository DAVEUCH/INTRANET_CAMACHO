using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TVentasProducto
    {
        public string? TipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? ClienteId { get; set; }
        public int? VendedorId { get; set; }
        public int? ProductoId { get; set; }
        public int? MarcaId { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public decimal? ValorUnitario { get; set; }
        public decimal? TotalDolares { get; set; }
    }
}
