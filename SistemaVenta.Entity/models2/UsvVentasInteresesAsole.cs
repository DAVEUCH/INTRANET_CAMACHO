using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasInteresesAsole
    {
        public int Idvta { get; set; }
        public DateTime FechaEmision { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int IdPeriodo { get; set; }
        public string NumeroDoc { get; set; } = null!;
        public int Idcliente { get; set; }
        public string? NombreCliente { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idtipocp { get; set; }
        public int Idsucursal { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? ValorIgvsoles { get; set; }
        public decimal? TotalSoles { get; set; }
    }
}
