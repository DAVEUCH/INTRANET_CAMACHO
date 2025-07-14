using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptConsolidadoCargaReparto
    {
        public int ConsolidadoCargaId { get; set; }
        public string? ConsolidadoCargaTipoCp { get; set; }
        public string ConsolidadoCargaNumero { get; set; } = null!;
        public DateTime ConsolidadoCargaFecha { get; set; }
        public int? ConsolidadoEstadoOperacion { get; set; }
        public string? ConsolidadoEstado { get; set; }
        public string? ChoferCodigo { get; set; }
        public string? ChoferNombre { get; set; }
        public string? ChoferLicencia { get; set; }
        public string? VehiculoCodigo { get; set; }
        public string? VehiculoNombre { get; set; }
        public decimal? VehiculoCapacidadPeso { get; set; }
        public decimal? VehiculoCapacidadVolumen { get; set; }
        public string? VehiculoModelo { get; set; }
        public string? VehiculoMarca { get; set; }
        public string? VehiculoPlaca { get; set; }
        public string DetalleAlmacenCodigo { get; set; } = null!;
        public string DetalleAlmacenNombre { get; set; } = null!;
        public string DetalleAlmacenDireccion { get; set; } = null!;
        public int DetalleProductoId { get; set; }
        public string DetalleProductoCodigo { get; set; } = null!;
        public string DetalleProductoNombre { get; set; } = null!;
        public string DetalleUnidadBase { get; set; } = null!;
        public int DetalleUnidadBaseFactor { get; set; }
        public string DetalleUnidadRef { get; set; } = null!;
        public int DetalleUnidadRefFactor { get; set; }
        public int? DetalleProductoCantidad { get; set; }
        public decimal DetalleUnidadBasePeso { get; set; }
        public decimal DetalleUnidadBaseVolumen { get; set; }
        public decimal DetalleUnidadRefPeso { get; set; }
        public decimal DetalleUnidadRefVolumen { get; set; }
    }
}
