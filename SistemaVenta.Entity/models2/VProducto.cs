using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProducto
    {
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string CodigoFabrica { get; set; } = null!;
        public bool Activo { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string? Caracteristica01 { get; set; }
        public string? Caracteristica02 { get; set; }
        public string? Caracteristica03 { get; set; }
        public string? Caracteristica04 { get; set; }
        public int Pkidproducto { get; set; }
        public string Empaque { get; set; } = null!;
        public int? Factor { get; set; }
        public string? Ean13 { get; set; }
        public string? Dum14 { get; set; }
        public int FactorReferencia { get; set; }
    }
}
