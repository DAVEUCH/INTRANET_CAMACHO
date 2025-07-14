using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptMargenesporTiendaDetallado2
    {
        public DateTime FechaEmision { get; set; }
        public string NumCp { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Expr1 { get; set; } = null!;
        public int Idsucursal { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Pkid { get; set; }
        public int Expr2 { get; set; }
        public int Idproducto { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
        public decimal CostoReferenciaDolares { get; set; }
        public int Factor { get; set; }
        public decimal Total { get; set; }
        public int Idmoneda { get; set; }
        public bool PreciosIncImpto { get; set; }
    }
}
