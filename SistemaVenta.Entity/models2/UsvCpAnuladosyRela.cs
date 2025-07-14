using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCpAnuladosyRela
    {
        public int Pkid { get; set; }
        public DateTime? Fecha { get; set; }
        public string DestipoCp { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public string NroCorreDoc { get; set; } = null!;
        public string? TipoCompCode { get; set; }
        public string? CodTipoDocDocRela { get; set; }
        public string? NumeroGrRela { get; set; }
    }
}
