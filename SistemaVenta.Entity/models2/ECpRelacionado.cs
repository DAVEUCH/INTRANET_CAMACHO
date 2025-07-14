using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpRelacionado
    {
        public int CpsRelacionadosIdcp { get; set; }
        public int CpsRelacionadosIdcpRelacionado { get; set; }
        public string CpsRelacionadosIdtipoCpRelacionado { get; set; } = null!;
        public string CpsRelacionadosIdtipoCpDestino { get; set; } = null!;
        public int Idcp { get; set; }
        public int IdcpRelacionado { get; set; }
        public int CpsDestinoIdcp { get; set; }
        public int CpsDestinoIdcpRelacionado { get; set; }
        public string CpsDestinoIdtipoCpRelacionado { get; set; } = null!;
        public string CpsDestinoIdtipoCpDestino { get; set; } = null!;
    }
}
