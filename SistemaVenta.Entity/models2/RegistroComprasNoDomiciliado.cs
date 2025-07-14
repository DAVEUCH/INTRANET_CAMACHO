using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RegistroComprasNoDomiciliado
    {
        public string? Periodo { get; set; }
        public string? CodigoUnicoOperacion { get; set; }
        public string? NumeroCorrelativoAsiento { get; set; }
        public string? FechaEmision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string? ValorAdquisicion { get; set; }
        public string OtrosAdicionales { get; set; } = null!;
        public string? ImporteTotalAdquisicion { get; set; }
        public string TipoComprobantePagoDua { get; set; } = null!;
        public string SerieComprobantePago { get; set; } = null!;
        public int? AñoDua { get; set; }
        public string NumeroComprobantePago { get; set; } = null!;
        public string MontoRetencionIgv { get; set; } = null!;
        public string MonedaCodigo { get; set; } = null!;
        public string? TimpoCambio { get; set; }
        public string PaisResidenciaCodigo { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string DomicilioExtranjero { get; set; } = null!;
        public string? DocumentoIdentidad { get; set; }
        public string NumeroIdentificacionFiscal { get; set; } = null!;
        public string ApellidosNombresBeneficiario { get; set; } = null!;
        public string PaisBeneficiario { get; set; } = null!;
        public string VinculoConBeneficiario { get; set; } = null!;
        public string? RentaBruta { get; set; }
        public string DeduccionCostoEnajenacion { get; set; } = null!;
        public string? RentaNeta { get; set; }
        public string? TasaRetencion { get; set; }
        public decimal? ImpuestoRetenido { get; set; }
        public string ConveniosEvitarDobleImposicionTabla25 { get; set; } = null!;
        public string ExoneracionAplicadaTabla33 { get; set; } = null!;
        public string TipoRentaTabla31 { get; set; } = null!;
        public string ModalidadServicioPrestadoTabla32 { get; set; } = null!;
        public string? AplicacionArt76 { get; set; }
        public bool ProveedorAgenteRetencion { get; set; }
        public bool Extranjero { get; set; }
        public int Idperiodo { get; set; }
    }
}
