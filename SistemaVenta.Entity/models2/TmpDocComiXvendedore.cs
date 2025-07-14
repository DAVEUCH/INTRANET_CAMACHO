using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpDocComiXvendedore
    {
        public DateTime Fecha { get; set; }
        public string NumeroComprobante { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? ChCodCatVende { get; set; }
        public decimal? TotalVentaSoles { get; set; }
        public decimal? PorcVentaSoles { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ClaseProductoDescripcion { get; set; }
        public string? Marca { get; set; }
        public decimal? PorcenRango { get; set; }
        public decimal? PorcenComi { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? ComisionVentaSoles { get; set; }
        public string EsCompraCp { get; set; } = null!;
    }
}
