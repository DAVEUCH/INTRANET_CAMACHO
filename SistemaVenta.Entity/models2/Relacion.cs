using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Relacion
    {
        public int Pkid { get; set; }
        public string TipoCpOrigen { get; set; } = null!;
        public string BalanceOrigenA { get; set; } = null!;
        public string BalanceOrigenB { get; set; } = null!;
        public string Cardinalidad { get; set; } = null!;
        public string PropiedadReferencia { get; set; } = null!;
        public string PropiedadBalance { get; set; } = null!;
        public string TipoRelacion { get; set; } = null!;

        public virtual Cp Pk { get; set; } = null!;
    }
}
