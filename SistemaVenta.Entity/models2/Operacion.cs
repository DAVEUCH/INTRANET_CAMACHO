using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Operacion
    {
        public string Pkid { get; set; } = null!;
        public string IdensambladoEjecutante { get; set; } = null!;
        public string IdensambladoEjecutante2 { get; set; } = null!;
        public string Ejecutante { get; set; } = null!;
        public string Ejecutante2 { get; set; } = null!;
        public int TipoParametro { get; set; }
        public string Parametro { get; set; } = null!;
        public int TipoParametro2 { get; set; }
        public string Parametro2 { get; set; } = null!;
        public bool Auditable { get; set; }
        public int TipoValorDeRetorno { get; set; }
        public string IdtipoValorDeRetornoReferencia { get; set; } = null!;
        public bool PostCondicionesEnElServidor { get; set; }

        public virtual ElementoTipo Pk { get; set; } = null!;
    }
}
