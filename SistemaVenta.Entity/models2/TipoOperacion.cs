using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoOperacion
    {
        public TipoOperacion()
        {
            ConfiguracionCpInventarios = new HashSet<ConfiguracionCpInventario>();
            CpInventarios = new HashSet<CpInventario>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<ConfiguracionCpInventario> ConfiguracionCpInventarios { get; set; }
        public virtual ICollection<CpInventario> CpInventarios { get; set; }
    }
}
