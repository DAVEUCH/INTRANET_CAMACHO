using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptMargenesporTiendum
    {
        public DateTime? FechaEmision { get; set; }
        public string? NumCp { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public string? UnidadDeVenta { get; set; }
        public int? Idsucursal { get; set; }
        public string? NombreDeSucursal { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Pkid { get; set; }
        public int? Expr2 { get; set; }
        public int? Idproducto { get; set; }
        public decimal? CostoReferenciaSoles { get; set; }
        public decimal? CostoReferenciaDolares { get; set; }
        public int? Factor { get; set; }
        public decimal? Total { get; set; }
        public int? Idmoneda { get; set; }
        public bool? PreciosIncImpto { get; set; }
        public string? TipoDocumento { get; set; }
        public bool? Anulado { get; set; }
        public int? IdmonedaCp { get; set; }
        public bool? MonedaCp { get; set; }
        public int? IdmonedaProducto { get; set; }
        public bool? MonedaProducto { get; set; }
        public bool? ArticuloInventario { get; set; }
        public bool? Inafecto { get; set; }
    }
}
