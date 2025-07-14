using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActivoFijoMetodoDepreciacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string NumeroDocumentoAutorizacion { get; set; } = null!;
    }
}
