using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemServicio
    {
        public int Pkid { get; set; }
        public int Idservicio { get; set; }
        public int Idunidad { get; set; }

        public virtual ProductoServicio IdservicioNavigation { get; set; } = null!;
        public virtual ItemCp Pk { get; set; } = null!;
    }
}
