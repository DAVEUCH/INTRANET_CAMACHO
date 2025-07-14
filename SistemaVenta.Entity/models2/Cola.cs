using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Cola
    {
        public Cola()
        {
            ItemConfiguracionDistribucionColas = new HashSet<ItemConfiguracionDistribucionCola>();
        }

        public int Pkid { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<ItemConfiguracionDistribucionCola> ItemConfiguracionDistribucionColas { get; set; }
    }
}
