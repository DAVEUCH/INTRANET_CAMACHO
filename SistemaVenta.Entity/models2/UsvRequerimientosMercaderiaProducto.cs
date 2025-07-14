using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRequerimientosMercaderiaProducto
    {
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Sucursal { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public string Aentrada { get; set; } = null!;
        public string Asalida { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public int? Idproducto { get; set; }
        public string? CodProducto { get; set; }
        public string? DesProducto { get; set; }
        public int? StockProducto { get; set; }
    }
}
