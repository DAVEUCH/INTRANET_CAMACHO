using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Ordenamiento
    {
        public Ordenamiento()
        {
            OrdenamientoSqls = new HashSet<OrdenamientoSql>();
        }

        public string Pkid { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Posicion { get; set; }

        public virtual Reporte IdreporteNavigation { get; set; } = null!;
        public virtual ICollection<OrdenamientoSql> OrdenamientoSqls { get; set; }
    }
}
