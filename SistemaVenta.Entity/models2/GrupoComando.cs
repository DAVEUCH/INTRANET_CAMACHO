using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GrupoComando
    {
        public GrupoComando()
        {
            Comando2s = new HashSet<Comando2>();
            Comandos = new HashSet<Comando>();
        }

        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Posicion { get; set; }

        public virtual ICollection<Comando2> Comando2s { get; set; }
        public virtual ICollection<Comando> Comandos { get; set; }
    }
}
