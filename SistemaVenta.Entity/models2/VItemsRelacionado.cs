using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VItemsRelacionado
    {
        public int Id { get; set; }
        public string NumCpRelacionadoN1 { get; set; } = null!;
        public int IdcpRelacionadoN1 { get; set; }
        public string NumCpRelacionadoN2 { get; set; } = null!;
        public int IdcpRelacionadoN2 { get; set; }
        public int IditemCpRelacionadoN1 { get; set; }
        public int IditemCpRelacionadoN2 { get; set; }
    }
}
