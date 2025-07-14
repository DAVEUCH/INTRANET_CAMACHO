using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoConciliacionBancarium
    {
        public int Pkid { get; set; }
        public int IdconfiguracionConciliacionBancaria { get; set; }
        public bool AplicarConfiguracion { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
