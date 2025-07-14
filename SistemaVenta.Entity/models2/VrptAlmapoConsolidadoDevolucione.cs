using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoConsolidadoDevolucione
    {
        public int ConsolidadoCargaId { get; set; }
        public DateTime ConsolidadoCargaFecha { get; set; }
        public string ConsolidadoCargaNumCp { get; set; } = null!;
        public int ChoferId { get; set; }
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public int VehiculoId { get; set; }
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string VehiculoPlaca { get; set; } = null!;
        public string? ConsolidadoZonas { get; set; }
        public int DetalleProductoId { get; set; }
        public string DetalleProductoCodigo { get; set; } = null!;
        public string DetalleProductoNombre { get; set; } = null!;
        public int DetalleProductoCantidadBase { get; set; }
        public string? Vendedor1Codigo { get; set; }
        public string? Vendedor2Codigo { get; set; }
        public string? Vendedor3Codigo { get; set; }
        public string? Vendedor4Codigo { get; set; }
        public string? Vendedor5Codigo { get; set; }
        public string? Vendedor6Codigo { get; set; }
        public string? Vendedor7Codigo { get; set; }
        public string? Vendedor8Codigo { get; set; }
        public int? Vendedor1CantidadBase { get; set; }
        public int? Vendedor2CantidadBase { get; set; }
        public int? Vendedor3CantidadBase { get; set; }
        public int? Vendedor4CantidadBase { get; set; }
        public int? Vendedor5CantidadBase { get; set; }
        public int? Vendedor6CantidadBase { get; set; }
        public int? Vendedor7CantidadBase { get; set; }
        public int? Vendedor8CantidadBase { get; set; }
        public int ProductoFactor { get; set; }
        public string FormatoUnidad { get; set; } = null!;
        public int NroComprobantes { get; set; }
        public int NroClientes { get; set; }
        public decimal? TotalMinoristaContado { get; set; }
        public decimal? TotalMinoristaCredito { get; set; }
        public decimal? TotalMayoristaContado { get; set; }
        public decimal? TotalMayoristaCredito { get; set; }
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public decimal DetalleTotal { get; set; }
    }
}
