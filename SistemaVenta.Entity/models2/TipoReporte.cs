using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoReporte
    {
        public TipoReporte()
        {
            Reportes = new HashSet<Reporte>();
        }

        public int Pkid { get; set; }
        public string? Nombre { get; set; }
        public bool? Standard { get; set; }

        public virtual ICollection<Reporte> Reportes { get; set; }
    }
}
