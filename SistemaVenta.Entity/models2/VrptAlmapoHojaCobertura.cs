using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoHojaCobertura
    {
        public int VendedorId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public int DocId { get; set; }
        public DateTime DocFechaEmision { get; set; }
        public string? DocTipoCp { get; set; }
        public string? DocNumero { get; set; }
        public decimal DocTotal { get; set; }
        public int ZonaId { get; set; }
        public string ZonaCodigo { get; set; } = null!;
        public string ZonaNombre { get; set; } = null!;
        public string DocDireccionEntrega { get; set; } = null!;
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public string CategoriaCliente { get; set; } = null!;
        public string FormaPago { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string ConsolidadoNumCp { get; set; } = null!;
    }
}
