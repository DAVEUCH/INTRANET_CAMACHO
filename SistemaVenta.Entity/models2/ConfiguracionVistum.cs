using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionVistum
    {
        public ConfiguracionVistum()
        {
            ColumnaConfiguracionVista = new HashSet<ColumnaConfiguracionVistum>();
            ItemConfiguracionVistaFiltros = new HashSet<ItemConfiguracionVistaFiltro>();
        }

        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int AnchoInicial { get; set; }
        public int AltoInicial { get; set; }
        public bool TieneCheckBox { get; set; }
        public int IconoPequeño { get; set; }
        public int IconoGrande { get; set; }
        public int IconoSeleccion { get; set; }
        public bool SeleccionMultiple { get; set; }
        public string Consulta { get; set; } = null!;
        public bool? RequerirFiltro { get; set; }
        public string IdcontenedorConfiguracionVista { get; set; } = null!;

        public virtual ContenedorConfiguracionVistum IdcontenedorConfiguracionVistaNavigation { get; set; } = null!;
        public virtual ICollection<ColumnaConfiguracionVistum> ColumnaConfiguracionVista { get; set; }
        public virtual ICollection<ItemConfiguracionVistaFiltro> ItemConfiguracionVistaFiltros { get; set; }
    }
}
