using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DConsolidadoCargaDetalleGuiaNess
    {
        public int ConsolidadoCargaId { get; set; }
        public string? ConsolidadoCargaTipoCp { get; set; }
        public string ConsolidadoCargaNumero { get; set; } = null!;
        public DateTime ConsolidadoCargaFecha { get; set; }
        public int? ConsolidadoEstadoOperacion { get; set; }
        public string? ConsolidadoEstado { get; set; }
        public string? ChoferCodigo { get; set; }
        public string? ChoferNombre { get; set; }
        public string ZonaReparto { get; set; } = null!;
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
        public int DetalleProductoCantidad { get; set; }
        public decimal DetalleUnidadBasePeso { get; set; }
        public decimal DetalleUnidadBaseVolumen { get; set; }
        public decimal DetalleUnidadRefPeso { get; set; }
        public decimal DetalleUnidadRefVolumen { get; set; }
        public int Flete { get; set; }
        public decimal DetalleProductoTotal { get; set; }
        public int SaldoFisico { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string CodigoVendedor { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string OrdenVisita { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public int Pkid { get; set; }
        public string PedidoNumCp { get; set; } = null!;
        public string GuiaNumCp { get; set; } = null!;
        public string DireccionClienteEntrega { get; set; } = null!;
        public string AgenciaTransporte { get; set; } = null!;
    }
}
