using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabInventarioProductosAñoyMesRfmScore02
    {
        public string? MarcaNombre { get; set; }
        public double? Idmarca { get; set; }
        public double? Idproducto { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoInterno { get; set; }
        public string? Linea { get; set; }
        public string? Unid { get; set; }
        public DateTime? UltfecIngreso1 { get; set; }
        public double? UltCostoNacionalizado { get; set; }
        public DateTime? UltVtaFec { get; set; }
        public double? ImpVentasDol { get; set; }
        public double? Undvtas { get; set; }
        public double? Trans { get; set; }
        public DateTime? UltFechaVtaAñoMes { get; set; }
        public double? PrecioVentaLp { get; set; }
        public double? UndVendidas { get; set; }
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public double? SaldoAnterior { get; set; }
        public double? EntraAlmacen { get; set; }
        public double? SaldoFinal { get; set; }
        public double? Factor { get; set; }
        public double? Cantclie { get; set; }
        public double? PuntuaciónActualidad { get; set; }
        public double? PuntuaciónFrecuencia { get; set; }
        public double? PuntuaciónMonetaria { get; set; }
        public double? PuntuaciónRfm { get; set; }
        public double? ScoreRfm { get; set; }
        public string SegRfm { get; set; } = null!;
        public int? StockPdv02 { get; set; }
        public int? StockPdv04 { get; set; }
        public int? StockPdv05 { get; set; }
        public int? StockPdv06 { get; set; }
        public int? StockPdv07 { get; set; }
        public int? StockPdv09 { get; set; }
    }
}
