using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpInventarioTransferenciaFreddy
    {
        public int CpPkid { get; set; }
        public string CpNumCp { get; set; } = null!;
        public string CpPersona { get; set; } = null!;
        public DateTime CpFecha { get; set; }
        public DateTime CpFechaEmision { get; set; }
        public string CpProductoCodigo { get; set; } = null!;
        public string CpProductoDescripcion { get; set; } = null!;
        public decimal CpProductoCantidad { get; set; }
        public string CpAlmacenOrigen { get; set; } = null!;
        public string CpAlmacenDestino { get; set; } = null!;
        public int Idunidad { get; set; }
    }
}
