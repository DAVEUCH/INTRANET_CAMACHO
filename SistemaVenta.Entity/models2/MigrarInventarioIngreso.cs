using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MigrarInventarioIngreso
    {
        public int Pkid { get; set; }
        public string? Resul { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? Producto { get; set; }
        public string? Unidad { get; set; }
        public string? Factor { get; set; }
        public string? Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public string? TipoCp { get; set; }
        public string? Almacen { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Responsable { get; set; }
        public string? Moneda { get; set; }
        public string? CptoOperacion { get; set; }
    }
}
