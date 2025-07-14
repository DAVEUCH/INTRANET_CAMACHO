using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionConsolidadoCargaCabecera
    {
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoNumero { get; set; } = null!;
        public string ConsolidadoVehiculoCodigo { get; set; } = null!;
        public string ConsolidadoVehiculoNombre { get; set; } = null!;
        public string Transportista { get; set; } = null!;
        public string? TransportistaDocIdentidad { get; set; }
        public string? TransportistaDireccion { get; set; }
        public string Placa { get; set; } = null!;
        public string Placa2 { get; set; } = null!;
        public string Marca { get; set; } = null!;
        public string Chofer { get; set; } = null!;
        public string? ChoferDocIdentidad { get; set; }
        public string ChoferLicencia { get; set; } = null!;
        public int ConsolidadoVehiculoId { get; set; }
        public int ConsolidadoId { get; set; }
        public int ChoferId { get; set; }
        public string VendedorEmail { get; set; } = null!;
    }
}
