using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRegComprasLe82
    {
        public int? Periodo { get; set; }
        public string? Cuo { get; set; }
        public string? NumAsientoCorrelativo { get; set; }
        public string? FechaEmision { get; set; }
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? NumSerieDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string ValorAdq { get; set; } = null!;
        public string Otros { get; set; } = null!;
        public string? ImporteTotal { get; set; }
        public string? ReferenciaTipoComprobantePago { get; set; }
        public string? ReferenciaNumeroSerie { get; set; }
        public string? AñoDua { get; set; }
        public string? ReferenciaNumero { get; set; }
        public string? ImpuestoBaseGravada18 { get; set; }
        public string? CodigoMoneda { get; set; }
        public string? TipoDeCambio { get; set; }
        public string? Pais { get; set; }
        public string? RazonSocial { get; set; }
        public string Domicilio { get; set; } = null!;
        public string? NumeroDocIdentidad { get; set; }
        public string NumIdentFiscal { get; set; } = null!;
        public string PersonaPaga { get; set; } = null!;
        public string PaisResiBeni { get; set; } = null!;
        public string Vehiculo { get; set; } = null!;
        public string? ImporteTotal2 { get; set; }
        public int Campo { get; set; }
        public string? ImporteTotal3 { get; set; }
        public int Tasa { get; set; }
        public int Impuesto { get; set; }
        public string Convenio { get; set; } = null!;
        public string Exonera { get; set; } = null!;
        public string TipoRenta { get; set; } = null!;
        public int ModalServi { get; set; }
        public string Aplica { get; set; } = null!;
        public int? EstadoIdentificaAnotacion { get; set; }
        public int Idperiodo { get; set; }
    }
}
