using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoRutaRepartoBase
    {
        public string? Sucursal { get; set; }
        public string? CodVendAnt { get; set; }
        public string? CodVendNuevo { get; set; }
        public string? CodClienteAnt { get; set; }
        public string? CodClienteNvo { get; set; }
        public int? RutaDia { get; set; }
        public string? Zonareparto { get; set; }
        public string? Zonaventa { get; set; }
        public string? F9 { get; set; }
    }
}
