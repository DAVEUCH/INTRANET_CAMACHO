using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDistribucionCosto
    {
        public int Id { get; set; }
        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public int IdcptoOperacion { get; set; }
    }
}
