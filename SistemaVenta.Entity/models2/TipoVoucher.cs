using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoVoucher
    {
        public int Pkid { get; set; }
        public string TipoOperacion { get; set; } = null!;
        public bool AjusteDiferenciaTipoCambio { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
