using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargoEmpleado
    {
        public CargoEmpleado()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Vendedor { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
