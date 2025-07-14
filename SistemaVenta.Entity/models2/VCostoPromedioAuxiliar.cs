using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCostoPromedioAuxiliar
    {
        public DateTime Fecha { get; set; }
        public int? Cantidad { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? ValorVentaDolares { get; set; }
        public int Idproducto { get; set; }
        public int Idcp { get; set; }
        public int Iditem { get; set; }
        public decimal TipoCambioFecha { get; set; }
        public string Mes { get; set; } = null!;
        public string Año { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}
