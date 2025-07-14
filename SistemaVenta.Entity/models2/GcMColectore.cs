using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcMColectore
    {
        public int Pkid { get; set; }
        public string? Empresa { get; set; }
        public string? Almacen { get; set; }
        public string? Ubicacion { get; set; }
        public string? Producto { get; set; }
        public string? CodigoBd { get; set; }
        public string? ExisteBd { get; set; }
        public int? Cantidad { get; set; }
        public string? Fecha { get; set; }
        public string? IdProducto { get; set; }
    }
}
