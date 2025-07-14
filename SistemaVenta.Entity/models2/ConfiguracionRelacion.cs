using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionRelacion
    {
        public int Pkid { get; set; }
        public string BalanceOrigenA { get; set; } = null!;
        public string BalanceOrigenB { get; set; } = null!;
        public string PropiedadReferencia { get; set; } = null!;
        public string PropiedadBalance { get; set; } = null!;
        public string TipoRelacion { get; set; } = null!;

        public virtual CptoOperacion Pk { get; set; } = null!;
    }
}
