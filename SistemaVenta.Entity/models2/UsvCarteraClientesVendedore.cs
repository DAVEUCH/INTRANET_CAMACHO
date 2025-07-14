using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCarteraClientesVendedore
    {
        public int Idpersona { get; set; }
        public int Idresponsable { get; set; }
        public decimal? MaxVtas { get; set; }
    }
}
