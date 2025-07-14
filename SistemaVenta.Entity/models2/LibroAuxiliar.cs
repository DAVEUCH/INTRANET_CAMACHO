using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class LibroAuxiliar
    {
        public LibroAuxiliar()
        {
            AsientoTipos = new HashSet<AsientoTipo>();
            Asientos = new HashSet<Asiento>();
            ConfiguracionCierreAperturas = new HashSet<ConfiguracionCierreApertura>();
            Cps = new HashSet<Cp>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<AsientoTipo> AsientoTipos { get; set; }
        public virtual ICollection<Asiento> Asientos { get; set; }
        public virtual ICollection<ConfiguracionCierreApertura> ConfiguracionCierreAperturas { get; set; }
        public virtual ICollection<Cp> Cps { get; set; }
    }
}
