using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Empleado
    {
        public Empleado()
        {
            ActividadSoportes = new HashSet<ActividadSoporte>();
            ActivoFijoUbicacionActivoFijos = new HashSet<ActivoFijoUbicacionActivoFijo>();
            CargoCobranzas = new HashSet<CargoCobranza>();
            CpOrdenPagos = new HashSet<CpOrdenPago>();
            SolicitudSoportes = new HashSet<SolicitudSoporte>();
        }

        public int Pkid { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string LicenciaConducir { get; set; } = null!;
        public int IdcargoEmpleado { get; set; }

        public virtual CargoEmpleado IdcargoEmpleadoNavigation { get; set; } = null!;
        public virtual Persona Pk { get; set; } = null!;
        public virtual Vendedor Vendedor { get; set; } = null!;
        public virtual ICollection<ActividadSoporte> ActividadSoportes { get; set; }
        public virtual ICollection<ActivoFijoUbicacionActivoFijo> ActivoFijoUbicacionActivoFijos { get; set; }
        public virtual ICollection<CargoCobranza> CargoCobranzas { get; set; }
        public virtual ICollection<CpOrdenPago> CpOrdenPagos { get; set; }
        public virtual ICollection<SolicitudSoporte> SolicitudSoportes { get; set; }
    }
}
