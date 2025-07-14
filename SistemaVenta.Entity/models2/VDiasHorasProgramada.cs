using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VDiasHorasProgramada
    {
        public DateTime? Fecha { get; set; }
        public string CodigoRecurso { get; set; } = null!;
        public string Dia { get; set; } = null!;
        public string Hora { get; set; } = null!;
        public int Asignado { get; set; }
        public int Idrecurso { get; set; }
    }
}
