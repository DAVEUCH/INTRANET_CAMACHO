using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionReporte
    {
        public ConfiguracionReporte()
        {
            ItemConfiguracionReportes = new HashSet<ItemConfiguracionReporte>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Idusuario { get; set; }
        public string IdtipoReporte { get; set; } = null!;

        public virtual Usuario IdusuarioNavigation { get; set; } = null!;
        public virtual ICollection<ItemConfiguracionReporte> ItemConfiguracionReportes { get; set; }
    }
}
