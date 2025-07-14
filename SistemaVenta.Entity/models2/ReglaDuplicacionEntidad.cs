using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReglaDuplicacionEntidad
    {
        public string Pkid { get; set; } = null!;
        public string IdconfiguracionDuplicacionEntidad { get; set; } = null!;
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string ValorEnTexto { get; set; } = null!;
        public int Regla { get; set; }
        public bool UsarReflexion { get; set; }
        public bool UsarExpresion { get; set; }
        public bool UsarMetodo { get; set; }
        public int Posicion { get; set; }

        public virtual ConfiguracionDuplicacionEntidad IdconfiguracionDuplicacionEntidadNavigation { get; set; } = null!;
    }
}
