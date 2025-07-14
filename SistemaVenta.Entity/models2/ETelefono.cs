using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETelefono
    {
        public int Idpersona { get; set; }
        public int TelefonosId { get; set; }
        public string TelefonosNumeroTelefono { get; set; } = null!;
        public string TelefonosTipoTelefono { get; set; } = null!;
        public bool TelefonosPrincipal { get; set; }
    }
}
