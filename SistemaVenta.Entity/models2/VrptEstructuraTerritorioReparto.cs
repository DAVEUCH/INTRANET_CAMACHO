using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptEstructuraTerritorioReparto
    {
        public int Idvehiculo { get; set; }
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public int Idempleado { get; set; }
        public string EmpleadoCodigo { get; set; } = null!;
        public string EmpleadoNombre { get; set; } = null!;
        public string? Lunes { get; set; }
        public string? Martes { get; set; }
        public string? Miercoles { get; set; }
        public string? Jueves { get; set; }
        public string? Viernes { get; set; }
        public string? Sabado { get; set; }
        public string? Domingo { get; set; }
    }
}
