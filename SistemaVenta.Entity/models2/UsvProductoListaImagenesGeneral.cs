using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductoListaImagenesGeneral
    {
        public string CodigoProducto { get; set; } = null!;
        public string LineaProducto { get; set; } = null!;
        public int IdclaseProductoServicio { get; set; }
        public string LineaPadre { get; set; } = null!;
        public string Oem { get; set; } = null!;
        public int Idmarca { get; set; }
        public string MarcaProducto { get; set; } = null!;
        public string? UnidMed { get; set; }
        public decimal Precio { get; set; }
        public int? Stock { get; set; }
        public int? StockFijo { get; set; }
        public string CodLp { get; set; } = null!;
        public string? Grupodeimpresion { get; set; }
        public string? AplicaProducto { get; set; }
        public string ImagenProducto { get; set; } = null!;
        public string RutaImagenProducto { get; set; } = null!;
    }
}
