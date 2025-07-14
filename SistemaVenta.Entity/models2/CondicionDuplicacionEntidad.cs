using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CondicionDuplicacionEntidad
    {
        public string Pkid { get; set; } = null!;
        public string IdconfiguracionDuplicacionEntidad { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public string ValorEnTexto { get; set; } = null!;
        public string MensajeValidacion { get; set; } = null!;
        public int Posicion { get; set; }

        public virtual ConfiguracionDuplicacionEntidad IdconfiguracionDuplicacionEntidadNavigation { get; set; } = null!;
    }
}
