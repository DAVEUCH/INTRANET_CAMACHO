using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasAnticipo
    {
        public DateTime FechaEmision { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int IdPeriodo { get; set; }
        public int Idcliente { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idtipocp { get; set; }
        public int SucursalId { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? ValorIgvsoles { get; set; }
        public decimal? TotalSoles { get; set; }
    }
}
