using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NumCpContableEjercicio
    {
        public int Pkid { get; set; }
        public int Idejercicio { get; set; }
        public int IdnumCpContable { get; set; }

        public virtual Ejercicio IdejercicioNavigation { get; set; } = null!;
        public virtual NumCpContable IdnumCpContableNavigation { get; set; } = null!;
    }
}
