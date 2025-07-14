using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Ejercicio
    {
        public Ejercicio()
        {
            NumCpContableEjercicios = new HashSet<NumCpContableEjercicio>();
            Periodos = new HashSet<Periodo>();
        }

        public int Pkid { get; set; }
        public string Año { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Cerrado { get; set; }

        public virtual ICollection<NumCpContableEjercicio> NumCpContableEjercicios { get; set; }
        public virtual ICollection<Periodo> Periodos { get; set; }
    }
}
