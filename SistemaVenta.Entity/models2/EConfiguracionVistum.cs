using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionVistum
    {
        public string ConfiguracionesVistaId { get; set; } = null!;
        public string ConfiguracionesVistaNombre { get; set; } = null!;
        public int ConfiguracionesVistaAnchoInicial { get; set; }
        public int ConfiguracionesVistaAltoInicial { get; set; }
        public bool ConfiguracionesVistaTieneCheckBox { get; set; }
        public int ConfiguracionesVistaIconoPequeño { get; set; }
        public int ConfiguracionesVistaIconoGrande { get; set; }
        public int ConfiguracionesVistaIconoSeleccion { get; set; }
        public bool ConfiguracionesVistaSeleccionMultiple { get; set; }
        public string ConfiguracionesVistaConsulta { get; set; } = null!;
        public bool ConfiguracionesVistaRequerirFiltro { get; set; }
        public string IdcontenedorConfiguracionVista { get; set; } = null!;
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int AnchoInicial { get; set; }
        public int AltoInicial { get; set; }
        public bool TieneCheckBox { get; set; }
        public int IconoPequeño { get; set; }
        public int IconoSeleccion { get; set; }
        public bool SeleccionMultiple { get; set; }
        public string Consulta { get; set; } = null!;
        public bool RequerirFiltro { get; set; }
        public int IconoGrande { get; set; }
    }
}
