using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESolicitudSoporte
    {
        public int Id { get; set; }
        public int Idproyecto { get; set; }
        public int Idcliente { get; set; }
        public int IdtipoSolicitud { get; set; }
        public int IdestadoSolicitud { get; set; }
        public int IdresponsableIngreso { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public int Impacto { get; set; }
        public int Dificultad { get; set; }
        public int Prioridad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Informante { get; set; } = null!;
        public string Codigo { get; set; } = null!;
    }
}
