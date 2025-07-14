using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RegistroVentasDocumentoIdentidad
    {
        public int Pkid { get; set; }
        public string ClienteDocumentoIdentidad { get; set; } = null!;
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
    }
}
