using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NumCpContable
    {
        public NumCpContable()
        {
            NumCpContableEjercicios = new HashSet<NumCpContableEjercicio>();
            NumCpContablePeriodos = new HashSet<NumCpContablePeriodo>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Serie { get; set; }
        public int Longitud { get; set; }

        public virtual ICollection<NumCpContableEjercicio> NumCpContableEjercicios { get; set; }
        public virtual ICollection<NumCpContablePeriodo> NumCpContablePeriodos { get; set; }
    }
}
