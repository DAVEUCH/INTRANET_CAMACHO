using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemEnvioLibroElectronico
    {
        public int Id { get; set; }
        public int IdenvioLibroElectronico { get; set; }
        public int IdvoucherContableResumen { get; set; }
        public string NumeroUnico { get; set; } = null!;
        public int? EstadoEnvio { get; set; }
    }
}
