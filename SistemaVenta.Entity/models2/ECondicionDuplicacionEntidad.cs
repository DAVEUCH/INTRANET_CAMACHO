using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECondicionDuplicacionEntidad
    {
        public string CondicionesId { get; set; } = null!;
        public string IdconfiguracionDuplicacionEntidad { get; set; } = null!;
        public string CondicionesRuta { get; set; } = null!;
        public string CondicionesOperador { get; set; } = null!;
        public string CondicionesValorEnTexto { get; set; } = null!;
        public string CondicionesMensajeValidacion { get; set; } = null!;
        public int CondicionesPosicion { get; set; }
    }
}
