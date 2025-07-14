using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpRelacionadoCanjeLetra
    {
        public int Idcp { get; set; }
        public string OrigenTipoCp { get; set; } = null!;
        public string OrigenNumCp { get; set; } = null!;
        public string? OrigenNombre { get; set; }
        public DateTime OrigenFecha { get; set; }
        public string OrigenMoneda { get; set; } = null!;
        public decimal OrigenTotal { get; set; }
        public bool OrigenAnulado { get; set; }
        public int IdtipoCpRelacionado { get; set; }
        public int IdcpRelacionado { get; set; }
    }
}
