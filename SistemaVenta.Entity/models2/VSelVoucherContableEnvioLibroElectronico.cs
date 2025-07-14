using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSelVoucherContableEnvioLibroElectronico
    {
        public int Id { get; set; }
        public string NumVoucherCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
    }
}
