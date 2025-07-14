using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInformacionOperacionesDocumentosDetalle
    {
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public bool ComprobanteTercero { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public int PeriodoId { get; set; }
        public int MonedaId { get; set; }
        public string MonedaDescripcion { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public string TipoComprobanteCodigo { get; set; } = null!;
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public string PersonaDocumentoIdentidad { get; set; } = null!;
        public string PersonaDireccionDescripcion { get; set; } = null!;
        public string PersonaDireccionDistrito { get; set; } = null!;
        public string PersonaDireccionProvincia { get; set; } = null!;
        public string PersonaDireccionDepartamento { get; set; } = null!;
        public string ComprobanteTipoCp { get; set; } = null!;
    }
}
