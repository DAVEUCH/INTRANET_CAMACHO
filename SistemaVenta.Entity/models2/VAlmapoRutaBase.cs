using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoRutaBase
    {
        public string? Sucursal { get; set; }
        public string? CodVendAnt { get; set; }
        public string? CodVendNuevo { get; set; }
        public string? CodClienteAnt { get; set; }
        public string? CodClienteNvo { get; set; }
        public double? RutaDia { get; set; }
        public string? ZonaDeReparto { get; set; }
        public string? Codigozonaventa { get; set; }
        public string? F9 { get; set; }
    }
}
