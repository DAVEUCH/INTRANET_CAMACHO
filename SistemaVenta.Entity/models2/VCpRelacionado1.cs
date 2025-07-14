using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpRelacionado1
    {
        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public string? TipoCp { get; set; }
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public int CpOrigenPkid { get; set; }
        public string CpOrigenIdtipoOd { get; set; } = null!;
        public int CpOrigenIdtipoCp { get; set; }
        public string CpOrigenTipoCp { get; set; } = null!;
        public string CpOrigenNumCp { get; set; } = null!;
        public DateTime CpOrigenFecha { get; set; }
        public int CpAncestroPkid { get; set; }
        public string CpAncestroIdtipoOd { get; set; } = null!;
        public int CpAncestroIdtipoCp { get; set; }
        public string CpAncestroTipoCp { get; set; } = null!;
        public string CpAncestroNumCp { get; set; } = null!;
        public DateTime CpAncestroFecha { get; set; }
    }
}
