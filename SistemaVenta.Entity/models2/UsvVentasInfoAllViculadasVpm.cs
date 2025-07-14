using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasInfoAllViculadasVpm
    {
        public string NumeroContable { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteDocumentoIdentidad { get; set; } = null!;
        public string? ClienteNombre { get; set; }
        public int Idpersona { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? ValorDescuento { get; set; }
        public int ValorExportacion { get; set; }
        public int ValorAfecto { get; set; }
        public int ValorAfectoArrendamiento { get; set; }
        public int ValorAfectoTerceroVpm { get; set; }
        public decimal? ValorAfectoVinculaGci { get; set; }
        public decimal? ValorAfectoVinculaIrc { get; set; }
        public int ValorAfectoInteres { get; set; }
        public int ValorAfectoAnticipos { get; set; }
        public int ValorAfectoObsequios { get; set; }
        public int ValorExonerado { get; set; }
        public decimal? ValorInafecto { get; set; }
        public int ValorIsc { get; set; }
        public decimal? ValorIgv { get; set; }
        public int ValorOtrosCargos { get; set; }
        public decimal? Total { get; set; }
        public decimal TipoDeCambio { get; set; }
        public DateTime ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string ReferenciaNumeroSerie { get; set; } = null!;
        public string ReferenciaNumero { get; set; } = null!;
        public string ModalidadCreditoCodigo { get; set; } = null!;
        public string ModalidadCreditoDescripcion { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string ZonaCodigo { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public int SucursalId { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Idperiodo { get; set; }
        public bool ResumirEnLibroAuxiliar { get; set; }
        public string NumCp { get; set; } = null!;
        public string PeriodoDesc { get; set; } = null!;
        public int Idejercicio { get; set; }
        public string SucursalNombre { get; set; } = null!;
    }
}
