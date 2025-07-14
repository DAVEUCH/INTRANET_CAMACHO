using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteDaotingreso
    {
        public string Daotperiodo { get; set; } = null!;
        public string DaotidtipoPersona { get; set; } = null!;
        public string DaottipoPersona { get; set; } = null!;
        public string DaotidtipoDocDeclarado { get; set; } = null!;
        public string DaottipoDocDeclarado { get; set; } = null!;
        public string? DaotnumeroDocDeclarado { get; set; }
        public decimal? DaotimporteTotal { get; set; }
        public string DaotcodDeclarado { get; set; } = null!;
        public string Daotdeclarado { get; set; } = null!;
    }
}
