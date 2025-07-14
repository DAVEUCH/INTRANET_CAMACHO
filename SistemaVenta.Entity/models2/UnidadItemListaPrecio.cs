using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UnidadItemListaPrecio
    {
        public UnidadItemListaPrecio()
        {
            Escalas = new HashSet<Escala>();
        }

        public int Pkid { get; set; }
        public int IditemListaPrecios { get; set; }
        public int Idunidad { get; set; }
        public string FormatoVenta { get; set; } = null!;
        public bool Modificado { get; set; }
        public bool Predeterminado { get; set; }
        public bool PermitirDecimales { get; set; }

        public virtual ICollection<Escala> Escalas { get; set; }
    }
}
