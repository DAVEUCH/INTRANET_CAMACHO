using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ViewVentaAlmapo
    {
        public string Sucursal { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Doc { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public decimal Total { get; set; }
        public string Cliente { get; set; } = null!;
        public string CodCliente { get; set; } = null!;
        public string CodPcto { get; set; } = null!;
        public decimal Cant { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal? Precio { get; set; }
        public int Factor { get; set; }
        public decimal Expr1 { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Tercero { get; set; }
        public string Expr2 { get; set; } = null!;
        public string Expr3 { get; set; } = null!;
    }
}
