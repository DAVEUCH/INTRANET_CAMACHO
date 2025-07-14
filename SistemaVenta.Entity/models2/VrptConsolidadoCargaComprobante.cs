using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptConsolidadoCargaComprobante
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
        public int Flete { get; set; }
        public DateTime CpVentaFechaEmision { get; set; }
        public string CpVentaTipoDoc { get; set; } = null!;
        public string CpVentaNumero { get; set; } = null!;
        public string? CpVentaCliente { get; set; }
        public string CpVentaVendedorCodigo { get; set; } = null!;
        public string CpVentaDireccionEntrega { get; set; } = null!;
        public string CpVentaZona { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string? NumPediddo { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string? EmpresaTransporte { get; set; }
        public string VehiculoPlaca { get; set; } = null!;
        public string? DireccionEntrega { get; set; }
    }
}
