using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargoAbonoTipoReferencium
    {
        public int Pkid { get; set; }
        public int IdcargoAbonoTipo { get; set; }
        public string RutaReferencia { get; set; } = null!;

        public virtual CargoAbonoTipo IdcargoAbonoTipoNavigation { get; set; } = null!;
    }
}
