using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEnvioLibroElectronico
    {
        public int Id { get; set; }
        public int Idperiodo { get; set; }
        public string? Xmlitems { get; set; }
    }
}
