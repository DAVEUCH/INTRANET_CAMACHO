using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLeRegistroVentas2010001
    {
        public int? Periodo { get; set; }
        public string NumeroOperacion { get; set; } = null!;
        public string NumeroCorrelativo { get; set; } = null!;
        public string? FechaEmision { get; set; }
        public string FechaVencimiento { get; set; } = null!;
        public string TipoComprobantePagoCodigo { get; set; } = null!;
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string Campo9 { get; set; } = null!;
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string ClienteDocumentoIdentidad { get; set; } = null!;
        public string? ClienteNombre { get; set; }
        public int ValorExportacion { get; set; }
        public decimal? BaseImponible { get; set; }
        public int ValorExonerado { get; set; }
        public decimal? ValorInafecto { get; set; }
        public int ValorIsc { get; set; }
        public decimal? ValorIgv { get; set; }
        public string BaseImponibleArrozPilado { get; set; } = null!;
        public string ValorIgvarrozPilado { get; set; } = null!;
        public int ValorOtrosCargos { get; set; }
        public decimal? Total { get; set; }
        public string? TipoDeCambio { get; set; }
        public string? ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string? ReferenciaNumeroSerie { get; set; }
        public string ReferenciaNumero { get; set; } = null!;
        public string ValorFob { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string CampoLibre { get; set; } = null!;
        public int PeriodoId { get; set; }
        public int Idmoneda { get; set; }
    }
}
