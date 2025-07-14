using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRepConsolidadoCargaComprobante
    {
        public int ConsolidadoCargaId { get; set; }
        public string ConsolidadoCargaNumero { get; set; } = null!;
        public DateTime ConsolidadoCargaFecha { get; set; }
        public DateTime CpVentaFechaEmision { get; set; }
        public string CpVentaTipoDoc { get; set; } = null!;
        public string CpVentaNumero { get; set; } = null!;
        public string? CpVentaCliente { get; set; }
        public string CpVentaDireccionEntrega { get; set; } = null!;
        public string? NumeroGuia { get; set; }
        public DateTime? FecEmisionGuia { get; set; }
        public string? NumeroPedido { get; set; }
        public string? Agencia { get; set; }
        public string BultosyPesos { get; set; } = null!;
        public int? BultoGr { get; set; }
        public decimal? PesoGr { get; set; }
        public string VehiculoPlaca { get; set; } = null!;
    }
}
