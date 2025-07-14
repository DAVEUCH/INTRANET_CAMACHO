using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvvComp
    {
        public string RucEmisor { get; set; } = null!;
        public string Rzcliente { get; set; } = null!;
        public string? PeriodoCod { get; set; }
        public string CarSunat { get; set; } = null!;
        public string? FechaEmision { get; set; }
        public string? FechaVencimiento { get; set; }
        public string TipoComprobantePagoCodigo { get; set; } = null!;
        public string? NumeroSerieDoc { get; set; }
        public int? Año { get; set; }
        public string? NumeroDoc { get; set; }
        public string NumeroDocFinal { get; set; } = null!;
        public string? TipoDocumentoIdentidad { get; set; }
        public string? NrodocIdentidad { get; set; }
        public string? Rzcliente3 { get; set; }
        public decimal? BiGravada { get; set; }
        public decimal? Igv { get; set; }
        public int BiGravadoDgng { get; set; }
        public int IgvIpmDgng { get; set; }
        public int BiGravadoDng { get; set; }
        public int IgvIpmDng { get; set; }
        public decimal? ValorAdqNg { get; set; }
        public int Isc { get; set; }
        public int Icbper { get; set; }
        public int OtrosTribCargos { get; set; }
        public decimal? Total { get; set; }
        public string CodigoMoneda { get; set; } = null!;
        public string? TipoDeCambio { get; set; }
        public string? ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string ReferenciaNumeroSerie { get; set; } = null!;
        public string Dam { get; set; } = null!;
        public string ReferenciaNumero { get; set; } = null!;
        public int Clasi { get; set; }
    }
}
