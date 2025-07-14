using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalAsientoDestinoC
    {
        public int IdcargoAbono { get; set; }
        public int IdcuentaContable { get; set; }
        public string Cuenta { get; set; } = null!;
        public decimal CargoMonedaBase { get; set; }
        public decimal AbonoMonedaBase { get; set; }
    }
}
