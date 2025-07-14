using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasClientesyVendedorSum
    {
        public int Idpersona { get; set; }
        public int Idresponsable { get; set; }
        public decimal? TotVtas { get; set; }
    }
}
