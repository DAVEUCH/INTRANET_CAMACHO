using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ColumnaConfiguracionVistum
    {
        public string Pkid { get; set; } = null!;
        public string IdconfiguracionVista { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public int Ancho { get; set; }
        public string Formato { get; set; } = null!;
        public int Icono { get; set; }
        public string NombreAtributo { get; set; } = null!;
        public int IdtipoDato { get; set; }
        public int Alineacion { get; set; }
        public int Orden { get; set; }
        public bool OrdenamientoPorDefecto { get; set; }
        public string NombreSql { get; set; } = null!;
        public bool Tag { get; set; }
        public bool Visible { get; set; }

        public virtual ConfiguracionVistum IdconfiguracionVistaNavigation { get; set; } = null!;
    }
}
