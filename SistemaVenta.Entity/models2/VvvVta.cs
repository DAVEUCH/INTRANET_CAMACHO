using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvvVta
    {
        public string RucEmisor { get; set; } = null!;
        public string Rzcliente { get; set; } = null!;
        public string? PeriodoCod { get; set; }
        public string CarSunat { get; set; } = null!;
        public string? FechaEmision { get; set; }
        public string? FechaVencimiento { get; set; }
        public string TipoComprobantePagoCodigo { get; set; } = null!;
        public string NumeroSerieDoc { get; set; } = null!;
        public string? NumeroDoc { get; set; }
        public string NumeroDocFinal { get; set; } = null!;
        public string TipoDocumentoIdentidad { get; set; } = null!;
        public string? RucCliente { get; set; }
        public string? Rzcliente3 { get; set; }
        public int ValorExportacion { get; set; }
        public decimal? BiGravada { get; set; }
        public decimal? DescuentoBi { get; set; }
        public decimal? Igv { get; set; }
        public decimal? DsctoIgv { get; set; }
        public int MtoExonerado { get; set; }
        public decimal? MtoInafecto { get; set; }
        public int Isc { get; set; }
        public int BiIvap { get; set; }
        public int Ivap { get; set; }
        public int Icbper { get; set; }
        public int OtrosTributos { get; set; }
        public decimal? Total { get; set; }
        public string CodigoMoneda { get; set; } = null!;
        public string? TipoDeCambio { get; set; }
        public string? ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string ReferenciaNumeroSerie { get; set; } = null!;
        public string ReferenciaNumero { get; set; } = null!;
    }
}
