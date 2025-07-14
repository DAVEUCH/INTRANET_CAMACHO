using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECondicion
    {
        public int CondicionesId { get; set; }
        public int IdpropiedadCasoContable { get; set; }
        public string CondicionesOperador { get; set; } = null!;
        public string CondicionesValor { get; set; } = null!;
        public string CondicionesOperadorLogico { get; set; } = null!;
        public int CondicionesIndexItemRelacionLogica { get; set; }
        public string CondicionesRutaPropiedadAtributo { get; set; } = null!;
    }
}
