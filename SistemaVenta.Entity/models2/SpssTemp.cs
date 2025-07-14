using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SpssTemp
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
        public double? StockPdv02 { get; set; }
        public double? StockPdv04 { get; set; }
        public double? StockPdv05 { get; set; }
        public double? StockPdv06 { get; set; }
        public double? StockPdv07 { get; set; }
        public double? StockPdv09 { get; set; }
        public int? PuntuaciónActualidad { get; set; }
        public int? PuntuaciónFrecuencia { get; set; }
        public int? PuntuaciónMonetaria { get; set; }
        public int? PuntuaciónRfm { get; set; }
    }
}
