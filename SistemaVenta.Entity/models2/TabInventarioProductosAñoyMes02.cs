using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabInventarioProductosAñoyMes02
    {
        public string MarcaNombre { get; set; } = null!;
        public int Idmarca { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string Linea { get; set; } = null!;
        public string Unid { get; set; } = null!;
        public DateTime? UltfecIngreso1 { get; set; }
        public decimal? UltCostoNacionalizado { get; set; }
        public DateTime? UltVtaFec { get; set; }
        public decimal ImpVentasDol { get; set; }
        public int? Undvtas { get; set; }
        public int? Trans { get; set; }
        public DateTime? UltFechaVtaAñoMes { get; set; }
        public decimal? PrecioVentaLp { get; set; }
        public int? UndVendidas { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? SaldoAnterior { get; set; }
        public int? EntraAlmacen { get; set; }
        public int? SaldoFinal { get; set; }
        public int? Factor { get; set; }
        public int? Cantclie { get; set; }
    }
}
