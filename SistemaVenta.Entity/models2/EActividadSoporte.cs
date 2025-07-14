using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActividadSoporte
    {
        public int Id { get; set; }
        public int IdsolicitudSoporte { get; set; }
        public int Idresponsable { get; set; }
        public string Detalle { get; set; } = null!;
        public string Solucion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public int Duracion { get; set; }
        public string Codigo { get; set; } = null!;
        public int Idestado { get; set; }
    }
}
