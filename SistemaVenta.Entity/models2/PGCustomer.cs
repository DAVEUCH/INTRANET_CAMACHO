using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PGCustomer
    {
        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string SubcustomerCode { get; set; } = null!;
        public string SubcustomerName { get; set; } = null!;
    }
}
