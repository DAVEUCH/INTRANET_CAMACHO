using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoDocIdentidad
    {
        public TipoDocIdentidad()
        {
            Personas = new HashSet<Persona>();
            TipoCpVenta = new HashSet<TipoCpVentum>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Longitud { get; set; }
        public string Abreviacion { get; set; } = null!;

        public virtual ICollection<Persona> Personas { get; set; }
        public virtual ICollection<TipoCpVentum> TipoCpVenta { get; set; }
    }
}
