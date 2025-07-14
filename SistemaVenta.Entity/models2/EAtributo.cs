using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EAtributo
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
        public string Campo { get; set; } = null!;
        public bool Modificable { get; set; }
        public bool Derivado { get; set; }
        public bool Volatil { get; set; }
        public bool Persistible { get; set; }
        public string ValorPorDefecto { get; set; } = null!;
        public string IdtipoDato { get; set; } = null!;
        public bool EsId { get; set; }
        public bool Reemplazo { get; set; }
        public bool CriterioBusqueda { get; set; }
        public string Alias { get; set; } = null!;
        public int Orden { get; set; }
        public bool ActualizacionEnLote { get; set; }
    }
}
