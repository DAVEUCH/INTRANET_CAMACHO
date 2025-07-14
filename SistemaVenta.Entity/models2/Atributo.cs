using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Atributo
    {
        public string Pkid { get; set; } = null!;
        public string IdtipoDato { get; set; } = null!;
        public bool EsId { get; set; }

        public virtual TipoDato IdtipoDatoNavigation { get; set; } = null!;
        public virtual CaracteristicaEstructural Pk { get; set; } = null!;
    }
}
