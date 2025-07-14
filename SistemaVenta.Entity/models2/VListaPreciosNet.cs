using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VListaPreciosNet
    {
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public int Factor { get; set; }
        public int Desde { get; set; }
        public int Hasta { get; set; }
        public decimal PrecioIncImpto { get; set; }
        public bool Referencia { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal? Cpr { get; set; }
        public decimal? Cuc { get; set; }
        public string Sucursal { get; set; } = null!;
        public bool Activo { get; set; }
        public string Linea { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
    }
}
