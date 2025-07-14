using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranMigrarCobranza
    {
        public string? Codnum { get; set; }
        public string Codfor { get; set; } = null!;
        public string Unimon { get; set; } = null!;
        public decimal Imppag { get; set; }
        public string? Codcli { get; set; }
        public string? Feccob { get; set; }
        public string Horacob { get; set; } = null!;
        public decimal Camdol { get; set; }
        public string? Codigoven { get; set; }
        public string Tipode { get; set; } = null!;
        public string? Nusedo { get; set; }
        public string? Numdoc { get; set; }
    }
}
