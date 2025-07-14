using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CaracteristicaEstructural
    {
        public string Pkid { get; set; } = null!;
        public string Campo { get; set; } = null!;
        public bool Modificable { get; set; }
        public bool Derivado { get; set; }
        public bool Volatil { get; set; }
        public bool Persistible { get; set; }
        public string ValorPorDefecto { get; set; } = null!;
        public bool ActualizacionEnLote { get; set; }

        public virtual ElementoTipo Pk { get; set; } = null!;
        public virtual Atributo Atributo { get; set; } = null!;
        public virtual Referencium Referencium { get; set; } = null!;
    }
}
