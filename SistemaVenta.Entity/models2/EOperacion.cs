using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EOperacion
    {
        public string Pkid { get; set; } = null!;
        public string Idclasificador { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Ordenado { get; set; }
        public bool Unico { get; set; }
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public bool Coleccion { get; set; }
        public bool Obligatorio { get; set; }
        public string IdensambladoEjecutante { get; set; } = null!;
        public string Ejecutante { get; set; } = null!;
        public int TipoParametro { get; set; }
        public string Parametro { get; set; } = null!;
        public int TipoParametro2 { get; set; }
        public string Parametro2 { get; set; } = null!;
        public bool Reemplazo { get; set; }
        public bool CriterioBusqueda { get; set; }
        public string Alias { get; set; } = null!;
        public bool Auditable { get; set; }
        public int TipoValorDeRetorno { get; set; }
        public string IdtipoValorDeRetornoReferencia { get; set; } = null!;
        public string Ejecutante2 { get; set; } = null!;
        public string IdensambladoEjecutante2 { get; set; } = null!;
        public int Orden { get; set; }
        public bool PostCondicionesEnElServidor { get; set; }
    }
}
