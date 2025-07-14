using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalAsientoDestinoA
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string Periodo { get; set; } = null!;
        public int IdasientoTransferencia { get; set; }
        public int IdcuentaContable { get; set; }
        public string Cuenta { get; set; } = null!;
        public decimal? CargoMonedaBase { get; set; }
        public decimal? AbonoMonedaBase { get; set; }
        public decimal CargoMonedaBase2 { get; set; }
        public decimal AbonoMonedaBase2 { get; set; }
    }
}
