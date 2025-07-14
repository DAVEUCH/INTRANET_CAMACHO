using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptGuiaFormato2
    {
        public int ComprobanteId { get; set; }
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public int? ItemCantidad { get; set; }
        public string ItemUnidadBase { get; set; } = null!;
        public string? VehiculoNombre { get; set; }
        public decimal? VehiculoCapacidadPeso { get; set; }
        public decimal? VehiculoCapacidadVolumen { get; set; }
        public string? VehiculoModelo { get; set; }
        public string? VehiculoMarca { get; set; }
        public string? VehiculoPlaca { get; set; }
        public string? VehiculoPlaca2 { get; set; }
        public string? VehiculoCertificadoInscripcion { get; set; }
        public string? TransportistaNombre { get; set; }
        public string? ChoferNombre { get; set; }
        public string? LicenciaConducir { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public string? TransportistaDi { get; set; }
        public string ComprobantePuntoPartida { get; set; } = null!;
        public string? ChoferCodigo { get; set; }
        public int? ConsolidadoId { get; set; }
    }
}
