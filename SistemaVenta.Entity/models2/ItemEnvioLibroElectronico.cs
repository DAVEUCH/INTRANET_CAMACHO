using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemEnvioLibroElectronico
    {
        public int Pkid { get; set; }
        public int IdenvioLibroElectronico { get; set; }
        public int IdvoucherContableResumen { get; set; }
        public string NumeroUnico { get; set; } = null!;
        public int? EstadoEnvio { get; set; }

        public virtual EnvioLibroElectronico IdenvioLibroElectronicoNavigation { get; set; } = null!;
    }
}
