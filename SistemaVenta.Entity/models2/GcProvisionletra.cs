using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcProvisionletra
    {
        public int Pkid { get; set; }
        public int? Idpersona { get; set; }
        public DateTime? FechaProvision { get; set; }
        public string? UserReg { get; set; }
    }
}
