using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VContexto
    {
        public string Ensamblado { get; set; } = null!;
        public string Ensamblado2 { get; set; } = null!;
        public string Ejecutante { get; set; } = null!;
        public string Ejecutante2 { get; set; } = null!;
        public string? Entidad { get; set; }
        public string Esquema { get; set; } = null!;
        public string Parametro { get; set; } = null!;
        public string Idtipo { get; set; } = null!;
        public string Idoperacion { get; set; } = null!;
        public bool OperacionAuditable { get; set; }
        public bool CacheableNivel2 { get; set; }
        public bool Coleccion { get; set; }
        public string Parametro2 { get; set; } = null!;
        public string Operacion { get; set; } = null!;
    }
}
