using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductoActivosAplicacione
    {
        public long? Item { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string DescripcionProducto { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string LineaProducto { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string LineaPadre { get; set; } = null!;
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Año { get; set; }
        public string? Motor { get; set; }
        public string? Cilindros { get; set; }
        public string? Litros { get; set; }
        public string? Medidas { get; set; }
        public string? Voltios { get; set; }
        public string? TipoEncendido { get; set; }
        public string? Lado { get; set; }
        public decimal Stock { get; set; }
    }
}
