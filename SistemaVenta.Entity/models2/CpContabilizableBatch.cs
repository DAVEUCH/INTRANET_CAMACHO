using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpContabilizableBatch
    {
        public CpContabilizableBatch()
        {
            CpContabilizables = new HashSet<CpContabilizable>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<CpContabilizable> CpContabilizables { get; set; }
    }
}
