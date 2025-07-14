using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionGeneracionProducto
    {
        public ConfiguracionGeneracionProducto()
        {
            ItemConfiguracionGeneracionProductos = new HashSet<ItemConfiguracionGeneracionProducto>();
        }

        public int Pkid { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<ItemConfiguracionGeneracionProducto> ItemConfiguracionGeneracionProductos { get; set; }
    }
}
