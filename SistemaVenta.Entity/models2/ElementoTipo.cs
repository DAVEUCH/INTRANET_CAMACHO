using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ElementoTipo
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
        public bool Reemplazo { get; set; }
        public bool CriterioBusqueda { get; set; }
        public string Alias { get; set; } = null!;
        public int Orden { get; set; }

        public virtual Clasificador IdclasificadorNavigation { get; set; } = null!;
        public virtual CaracteristicaEstructural CaracteristicaEstructural { get; set; } = null!;
        public virtual Operacion Operacion { get; set; } = null!;
    }
}
