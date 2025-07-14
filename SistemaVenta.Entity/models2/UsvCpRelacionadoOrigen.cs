using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCpRelacionadoOrigen
    {
        public string OrigenTipoCp { get; set; } = null!;
        public string OrigenNumCp { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string? OrigenNombre { get; set; }
        public int Idcp { get; set; }
        public int IdcpRelacionado { get; set; }
    }
}
