using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoDato
    {
        public TipoDato()
        {
            Atributos = new HashSet<Atributo>();
        }

        public string Pkid { get; set; } = null!;
        public bool Serializable { get; set; }

        public virtual Clasificador Pk { get; set; } = null!;
        public virtual ICollection<Atributo> Atributos { get; set; }
    }
}
