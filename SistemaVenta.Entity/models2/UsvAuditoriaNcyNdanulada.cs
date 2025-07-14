using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvAuditoriaNcyNdanulada
    {
        public long Pkid { get; set; }
        public int Idusuario { get; set; }
        public string NombreTipo { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public int? Identidad { get; set; }
        public string Pc { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
