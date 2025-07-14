using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoFormato1
    {
        public int? ConsolidadoId { get; set; }
        public string ComprobanteCodSunat { get; set; } = null!;
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string PuntoDeLlegada { get; set; } = null!;
        public string? VehiculoModelo { get; set; }
        public string? VehiculoMarca { get; set; }
        public string? VehiculoPlaca { get; set; }
        public string ComprobantePuntoPartida { get; set; } = null!;
        public string? ChoferNombre { get; set; }
        public string? TransportistaNombre { get; set; }
        public DateTime? ConsolidadoFecha { get; set; }
        public string? ChoferDi { get; set; }
        public string? LicenciaConducir { get; set; }
        public string? TransportistaDi { get; set; }
        public string? ChoferCodigo { get; set; }
        public int ComprobanteId { get; set; }
        public string? ComprobantePuntoLlegada { get; set; }
    }
}
