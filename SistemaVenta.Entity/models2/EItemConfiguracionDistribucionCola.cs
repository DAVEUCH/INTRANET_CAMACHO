using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionDistribucionCola
    {
        public int ItemsId { get; set; }
        public string? ItemsRuta { get; set; }
        public string? ItemsValor { get; set; }
        public int? ItemsIdcola { get; set; }
        public int IdconfiguracionDistribucionCola { get; set; }
    }
}
