using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VControlVta
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int PkidAlmacen { get; set; }
        public string GrupoVenta { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Linea { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string CodProducto { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public decimal? Vtas { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
