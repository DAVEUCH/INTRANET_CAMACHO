using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConsolidadoCarga
    {
        public int ItemsPkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string ItemsIdcpRelacionado { get; set; } = null!;
        public int Id { get; set; }
        public string IdcpRelacionado { get; set; } = null!;
        public int ItemsId { get; set; }
        public int ItemsIdconsolidadoCarga { get; set; }
    }
}
