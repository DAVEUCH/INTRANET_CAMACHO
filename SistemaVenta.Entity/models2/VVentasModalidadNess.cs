using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VVentasModalidadNess
    {
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }
        public decimal? Contado { get; set; }
        public decimal? Credito { get; set; }
        public string Modalidad { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public int Sucursalid { get; set; }
        public int? Mesid { get; set; }
        public int Ejercicioid { get; set; }
        public string Ejercicio { get; set; } = null!;
        public string? Mes { get; set; }
    }
}
