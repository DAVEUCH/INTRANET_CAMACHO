using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMovientosSolesCompra
    {
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public int Factor { get; set; }
        public decimal? CantPor { get; set; }
        public decimal? ValorVenta { get; set; }
        public string Sucursal { get; set; } = null!;
    }
}
