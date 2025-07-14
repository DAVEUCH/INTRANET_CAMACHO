using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMovimientosSole
    {
        public string GrupoVenta { get; set; } = null!;
        public int IdCliente { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string NumCp { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public decimal? ValorVenta { get; set; }
        public bool Anulado { get; set; }
        public int Idmoneda { get; set; }
        public int Pkid { get; set; }
        public string Vta { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public int IdtipoCaracteristica1 { get; set; }
        public decimal? Cantidad { get; set; }
        public int PkidAlmacen { get; set; }
    }
}
