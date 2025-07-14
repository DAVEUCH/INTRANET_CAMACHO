using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInventarioProductoUnidad
    {
        public int Pkid { get; set; }
        public int? Idproveedor { get; set; }
        public int Idmarca { get; set; }
        public int? IdclaseProductoServicioPadre2 { get; set; }
        public int IdclaseProductoServicioPadre1 { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public string? ClaseProductoServicioPadre2Descripcion { get; set; }
        public string? ClaseProductoServicioPadre1Descripcion { get; set; }
        public string ClaseProductoServicioDescripcion { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string MarcaDescripcion { get; set; } = null!;
        public string UnidadDescripcion { get; set; } = null!;
        public string UnidadAbreviacion { get; set; } = null!;
        public int UnidadFactor { get; set; }
    }
}
