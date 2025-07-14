using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionCpto
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int? NroDocs { get; set; }
        public string TipoCp { get; set; } = null!;
        public DateTime? FechaMin { get; set; }
        public DateTime? FechaMax { get; set; }
        public string? Clase { get; set; }
        public string ClaseOrigen { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Detalle { get; set; } = null!;
        public bool Contabilizable { get; set; }
        public int SaldoContable { get; set; }
        public int SaldoDisponible { get; set; }
        public string TipoMovimientoCaja { get; set; } = null!;
        public int CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public int CostoUltimaCompra { get; set; }
        public int CostoReferencia { get; set; }
        public int CostoParalelo { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public string PropiedadEstadoAsociado { get; set; } = null!;
        public string PropiedadBalanceAsociado { get; set; } = null!;
        public int ActualizaEstadoBalance { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public int MovSaldo { get; set; }
        public string BalanceOrigenA { get; set; } = null!;
        public string BalanceOrigenB { get; set; } = null!;
        public string PropiedadReferencia { get; set; } = null!;
        public string PropiedadBalance { get; set; } = null!;
        public string TipoRelacion { get; set; } = null!;
        public bool Activo { get; set; }
        public string Libro { get; set; } = null!;
        public string Glosa { get; set; } = null!;
        public string OrigenCuentaContable { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string RutaMonto { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public string Abono { get; set; } = null!;
        public string CondicionRuta { get; set; } = null!;
        public string CondicionOperador { get; set; } = null!;
        public string CuentasCpto { get; set; } = null!;
        public string CondicionValor { get; set; } = null!;
        public string Enlace { get; set; } = null!;
        public string PkidcargoAbono { get; set; } = null!;
        public string PkidasientoTipo { get; set; } = null!;
        public string RutaDocCobrarPagar { get; set; } = null!;
        public string RutaMoneda { get; set; } = null!;
        public string RutaCentroDeCosto { get; set; } = null!;
        public string TipoMovimientoInv { get; set; } = null!;
        public bool GestionaLote { get; set; }
        public bool RequiereCentroDeCosto { get; set; }
        public bool RestringirAlmacenItem { get; set; }
        public bool SugerenciaCompra { get; set; }
    }
}
