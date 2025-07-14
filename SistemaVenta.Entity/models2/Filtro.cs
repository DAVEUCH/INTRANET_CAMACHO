using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Filtro
    {
        public Filtro()
        {
            FiltroCondicions = new HashSet<FiltroCondicion>();
            FiltroOrdenamientos = new HashSet<FiltroOrdenamiento>();
        }

        public string Pkid { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Idvista { get; set; } = null!;
        public int Maximo { get; set; }

        public virtual Usuario IdusuarioNavigation { get; set; } = null!;
        public virtual ICollection<FiltroCondicion> FiltroCondicions { get; set; }
        public virtual ICollection<FiltroOrdenamiento> FiltroOrdenamientos { get; set; }
    }
}
