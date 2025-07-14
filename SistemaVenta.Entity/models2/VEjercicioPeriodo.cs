using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VEjercicioPeriodo
    {
        public int Pkid { get; set; }
        public int Idejercicio { get; set; }
        public string Mes { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Cerrado { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Apertura { get; set; }
        public bool Cierre { get; set; }
        public string Año { get; set; } = null!;
        public bool EjercicioActivo { get; set; }
        public bool EjercicioCerrado { get; set; }
    }
}
