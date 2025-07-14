using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VistaReporte
    {
        public VistaReporte()
        {
            OrdenamientoSqls = new HashSet<OrdenamientoSql>();
            ParametroSqls = new HashSet<ParametroSql>();
        }

        public string Pkid { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public int TipoVista { get; set; }
        public int Posicion { get; set; }

        public virtual ICollection<OrdenamientoSql> OrdenamientoSqls { get; set; }
        public virtual ICollection<ParametroSql> ParametroSqls { get; set; }
    }
}
