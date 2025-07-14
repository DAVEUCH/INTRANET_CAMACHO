using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroSubActividad
    {
        public string Pkid { get; set; } = null!;
        public string IdsubActividad { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string ParametroTipo { get; set; } = null!;
        public string IdvalorTipo { get; set; } = null!;
        public string IdvalorObjetoDatos { get; set; } = null!;
        public string IdvalorEnsamblado { get; set; } = null!;
        public string ValorClase { get; set; } = null!;
        public string ValorDiscreto { get; set; } = null!;

        public virtual SubActividad IdsubActividadNavigation { get; set; } = null!;
    }
}
