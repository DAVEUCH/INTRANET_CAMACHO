using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class BonificacionHistorica
    {
        public BonificacionHistorica()
        {
            ParametroEntradaBonificacions = new HashSet<ParametroEntradaBonificacion>();
        }

        public int Pkid { get; set; }
        public string Procedimiento { get; set; } = null!;
        public string? EnlaceHistorico { get; set; }

        public virtual ICollection<ParametroEntradaBonificacion> ParametroEntradaBonificacions { get; set; }
    }
}
