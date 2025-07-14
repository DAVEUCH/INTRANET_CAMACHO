using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionCpRelacionado
    {
        public DateTime CpRelacionadoFecha { get; set; }
        public DateTime CpRelacionadoFechaEmision { get; set; }
        public string CpRelacionadoNumCp { get; set; } = null!;
        public string CpRelacionadoTipoCpAbreviacion { get; set; } = null!;
        public int CpRelacionadoId { get; set; }
        public int CpOrigenId { get; set; }
    }
}
