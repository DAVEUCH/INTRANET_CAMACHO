using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionVistaFiltro
    {
        public string Pkid { get; set; } = null!;
        public string IdconfiguracionVista { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Filtro { get; set; } = null!;

        public virtual ConfiguracionVistum IdconfiguracionVistaNavigation { get; set; } = null!;
        public virtual Usuario IdusuarioNavigation { get; set; } = null!;
    }
}
