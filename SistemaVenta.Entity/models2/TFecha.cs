using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TFecha
    {
        public string? Año { get; set; }
        public string? Mes { get; set; }
        public DateTime Fecha { get; set; }
        public string? NombreMes { get; set; }
    }
}
