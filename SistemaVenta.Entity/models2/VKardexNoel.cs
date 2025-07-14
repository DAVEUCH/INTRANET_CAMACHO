using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VKardexNoel
    {
        public int Pkid { get; set; }
        public int Idpersona { get; set; }
        public string Ruc { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? OrdenDeCompraRelacionada { get; set; }
        public DateTime FechaEmision { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string DesTipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public decimal Importe { get; set; }
        public string Mone { get; set; } = null!;
        public decimal? ImporteNuevosSoles { get; set; }
        public string ReferenciaDeImportacion { get; set; } = null!;
        public string TipoCpInventario { get; set; } = null!;
    }
}
