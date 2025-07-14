using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EReglaDuplicacionEntidad
    {
        public string ReglasId { get; set; } = null!;
        public string IdconfiguracionDuplicacionEntidad { get; set; } = null!;
        public string ReglasRutaCaracteristicaEstructural { get; set; } = null!;
        public string ReglasValorEnTexto { get; set; } = null!;
        public int ReglasRegla { get; set; }
        public bool ReglasUsarReflexion { get; set; }
        public bool ReglasUsarExpresion { get; set; }
        public bool ReglasUsarMetodo { get; set; }
        public int ReglasPosicion { get; set; }
    }
}
