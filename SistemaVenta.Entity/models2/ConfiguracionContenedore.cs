using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionContenedore
    {
        public ConfiguracionContenedore()
        {
            Contenedor3s = new HashSet<Contenedor3>();
        }

        public int Pkid { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsPerfil { get; set; }
        public int? Idusuario { get; set; }

        public virtual ICollection<Contenedor3> Contenedor3s { get; set; }
    }
}
