using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductoCosto
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Monedabase { get; set; }
        public string Simbolo { get; set; } = null!;
        public decimal Costoreferenciasoles { get; set; }
        public decimal Costoreferenciadolares { get; set; }
        public decimal Costopromediosoles { get; set; }
        public decimal Costopromediodolares { get; set; }
        public decimal Costoultimacomprasoles { get; set; }
        public decimal Costoultimacompradolares { get; set; }
        public decimal? PorcentajeImpuesto { get; set; }
        public bool Activo { get; set; }
    }
}
