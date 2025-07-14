using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoCargo
    {
        public int DocumentoId { get; set; }
        public int DocumentoCargoId { get; set; }
        public int DocumentoCargoTipoCpId { get; set; }
        public string DocumentoCargoTipoCpAbreviacion { get; set; } = null!;
        public int DocumentoCargoPersonaId { get; set; }
        public string DocumentoCargoPersonaCodigo { get; set; } = null!;
        public string DocumentoCargoPersonaNombre { get; set; } = null!;
        public string? DocumentoCargoPersonaDocIdentidad { get; set; }
        public DateTime DocumentoCargoFecha { get; set; }
        public DateTime DocumentoCargoFechaEmision { get; set; }
        public DateTime DocumentoCargoFechaVencimiento { get; set; }
        public string DocumentoCargoNumero { get; set; } = null!;
        public string DocumentoCargoObservacion { get; set; } = null!;
        public bool DocumentoCargoAnulado { get; set; }
        public decimal DocumentoCargoSaldo { get; set; }
        public decimal DocumentoCargoTotal { get; set; }
        public string DocumentoCargoTipoCobrarPagar { get; set; } = null!;
        public bool DocumentoCargoEsCredito { get; set; }
        public int DocumentoCargoMonedaId { get; set; }
        public string DocumentoCargoMonedaDescripcion { get; set; } = null!;
        public string DocumentoCargoMonedaSimbolo { get; set; } = null!;
        public bool DocumentoCargoMonedaEsBase { get; set; }
        public int DocumentoCargoSucursalId { get; set; }
        public string DocumentoCargoSucursalNombre { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoId { get; set; }
        public string DocumentoCargoModalidadCreditoCodigo { get; set; } = null!;
        public string DocumentoCargoModalidadCreditoDescripcion { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoDiasCredito { get; set; }
        public bool? DocumentoCargoEsLetra { get; set; }
        public int DocumentoCargoLetraBancoId { get; set; }
        public string DocumentoCargoLetraBancoNombre { get; set; } = null!;
        public int DocumentoCargoLetraEstadoId { get; set; }
        public string DocumentoCargoLetraEstadoDescripcion { get; set; } = null!;
        public bool DocumentoCargoLetraEnBanco { get; set; }
        public string DocumentoCargoLetraNumeroUnicoEnBanco { get; set; } = null!;
    }
}
