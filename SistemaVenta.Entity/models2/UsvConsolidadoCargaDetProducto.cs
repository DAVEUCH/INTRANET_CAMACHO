using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvConsolidadoCargaDetProducto
    {
        public string ConsolidadoCargaNombreTipoCp { get; set; } = null!;
        public string ConsolidadoCargaNumero { get; set; } = null!;
        public DateTime ConsolidadoCargaFecha { get; set; }
        public string? ChoferNombre { get; set; }
        public string? VehiculoNombre { get; set; }
        public string? NumeroFactura { get; set; }
        public string? NumeroGuia { get; set; }
        public string? NombreCliente { get; set; }
        public string? DetalleProductoCodigo { get; set; }
        public string? DetalleProductoNombre { get; set; }
        public string? DetalleUnidadBase { get; set; }
        public int? DetalleUnidadBaseFactor { get; set; }
        public string? DetalleUnidadRef { get; set; }
        public int? DetalleUnidadRefFactor { get; set; }
        public int? DetalleProductoCantidad { get; set; }
    }
}
