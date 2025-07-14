using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProgramacion
    {
        public int ProgramacionesId { get; set; }
        public int ProgramacionesIdrecursoActividad { get; set; }
        public string ProgramacionesDia { get; set; } = null!;
        public string ProgramacionesHora { get; set; } = null!;
        public int IdrecursoActividad { get; set; }
        public DateTime ProgramacionesFecha { get; set; }
    }
}
