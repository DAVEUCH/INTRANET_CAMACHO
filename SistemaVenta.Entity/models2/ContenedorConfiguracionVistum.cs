using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ContenedorConfiguracionVistum
    {
        public ContenedorConfiguracionVistum()
        {
            ConfiguracionVista = new HashSet<ConfiguracionVistum>();
        }

        public string Pkid { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public string IdconfiguracionVista { get; set; } = null!;

        public virtual Clasificador IdtipoReferenciadoNavigation { get; set; } = null!;
        public virtual ICollection<ConfiguracionVistum> ConfiguracionVista { get; set; }
    }
}
