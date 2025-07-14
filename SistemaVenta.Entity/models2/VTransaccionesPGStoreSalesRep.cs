using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VTransaccionesPGStoreSalesRep
    {
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? SubcustomerCode { get; set; }
        public string? SubcustomerName { get; set; }
        public string? StoreSalesrepCode { get; set; }
        public string? StoreSalesrepName { get; set; }
        public string? StoreSupervisorCode { get; set; }
        public string? StoreSupervisorName { get; set; }
    }
}
