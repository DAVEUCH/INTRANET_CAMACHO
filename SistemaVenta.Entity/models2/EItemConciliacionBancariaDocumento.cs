using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConciliacionBancariaDocumento
    {
        public int DocumentosId { get; set; }
        public int IdconciliacionBancaria { get; set; }
        public int DocumentosIdcp { get; set; }
        public string DocumentosIdtipoCp { get; set; } = null!;
        public int DocumentosIditemConciliacionBancaria { get; set; }
    }
}
