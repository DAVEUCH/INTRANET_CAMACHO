using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Condicion
    {
        public int Pkid { get; set; }
        public int IdpropiedadCasoContable { get; set; }
        public string Operador { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public string OperadorLogico { get; set; } = null!;
        public int IndexItemRelacionLogica { get; set; }
        public string RutaPropiedadAtributo { get; set; } = null!;

        public virtual PropiedadCasoContable IdpropiedadCasoContableNavigation { get; set; } = null!;
    }
}
