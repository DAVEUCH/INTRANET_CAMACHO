using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESalidasCajaConsolidadoCargaValidar
    {
        public int IdconsolidadoCarga { get; set; }
        public int IdcpCajaSalida { get; set; }
        public string NumCp { get; set; } = null!;
    }
}
