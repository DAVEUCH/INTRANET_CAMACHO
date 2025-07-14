using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionDistribucionCola
    {
        public ConfiguracionDistribucionCola()
        {
            ItemConfiguracionDistribucionColas = new HashSet<ItemConfiguracionDistribucionCola>();
        }

        public int Pkid { get; set; }
        public string? Descripcion { get; set; }
        public string? IdtipoReferenciado { get; set; }

        public virtual ICollection<ItemConfiguracionDistribucionCola> ItemConfiguracionDistribucionColas { get; set; }
    }
}
