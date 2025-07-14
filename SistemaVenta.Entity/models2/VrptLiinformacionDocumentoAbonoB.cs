using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoAbonoB
    {
        public int DocumentoAbonoId { get; set; }
        public string ItemLetraTipoCp { get; set; } = null!;
        public DateTime ItemLetraFecha { get; set; }
        public DateTime ItemLetraFechaEmision { get; set; }
        public string ItemLetraNumero { get; set; } = null!;
        public string ItemLetraObservacion { get; set; } = null!;
        public string? ItemLetraNombre { get; set; }
        public bool ItemLetraAnulado { get; set; }
        public string ItemLetraMonedaDescripcion { get; set; } = null!;
        public string ItemLetraMonedaSimbolo { get; set; } = null!;
        public bool ItemLetraMonedaEsBase { get; set; }
        public DateTime ItemLetraFechaVencimiento { get; set; }
        public decimal ItemLetraTotal { get; set; }
        public decimal ItemLetraSaldo { get; set; }
        public string ItemLetraTipoCobrarPagar { get; set; } = null!;
        public bool ItemLetraEnBanco { get; set; }
        public string ItemLetraNumeroEnBanco { get; set; } = null!;
        public string ItemLetraBanco { get; set; } = null!;
        public string ItemLetraEstado { get; set; } = null!;
        public int ItemLetraDias { get; set; }
        public decimal ItemLetraPorcentaje { get; set; }
        public bool? EsLetra { get; set; }
    }
}
