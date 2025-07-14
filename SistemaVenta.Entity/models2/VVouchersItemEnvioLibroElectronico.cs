using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VVouchersItemEnvioLibroElectronico
    {
        public int Id { get; set; }
        public string? NumCp { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
    }
}
