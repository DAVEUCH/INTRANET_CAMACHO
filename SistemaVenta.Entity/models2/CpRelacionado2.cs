using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpRelacionado2
    {
        public int Idcp { get; set; }
        public int IdcpRelacionado { get; set; }
        public string IdtipoCpRelacionado { get; set; } = null!;
        public string IdtipoCpDestino { get; set; } = null!;
    }
}
