using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoConsolidadoCarga
    {
        public int ConsolidadoId { get; set; }
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoNumCp { get; set; } = null!;
        public int VehiculoId { get; set; }
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string VehiculoModelo { get; set; } = null!;
        public string VehiculoMarca { get; set; } = null!;
        public string VehiculoPlaca { get; set; } = null!;
        public string VehiculoPlaca2 { get; set; } = null!;
        public decimal VehiculoCapacidadPeso { get; set; }
        public decimal VehiculoCapacidadVolumen { get; set; }
        public string TransportistaCodigo { get; set; } = null!;
        public string TransportistaNombre { get; set; } = null!;
        public string TransportistaRuc { get; set; } = null!;
        public string TransportistaDireccion { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string ChoferDocumentoIdentidad { get; set; } = null!;
        public string ChoferLicenciaConducir { get; set; } = null!;
    }
}
