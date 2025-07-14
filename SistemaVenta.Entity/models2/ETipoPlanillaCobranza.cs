using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETipoPlanillaCobranza
    {
        public int Id { get; set; }
        public int Idsucursal { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public int Numero { get; set; }
        public string Serie { get; set; } = null!;
        public int LongitudNumero { get; set; }
        public int LongitudSerie { get; set; }
        public int MaximoNumeroItems { get; set; }
        public bool Contabilizable { get; set; }
        public bool ContabilizacionManual { get; set; }
        public bool NumeracionAutomatica { get; set; }
        public int PeriodoAnulacion { get; set; }
        public int IdreporteImpresion { get; set; }
        public int IdnumCpContable { get; set; }
        public bool NumeracionContable { get; set; }
        public bool RequiereMotivoAnulacion { get; set; }
        public bool Imprimible { get; set; }
        public bool PermitirFechasDiferidas { get; set; }
        public bool PermitirFechasFuturas { get; set; }
        public bool GenerarNumeracionAlGuardar { get; set; }
        public string TipoPlanillaCobranzaIdcaja { get; set; } = null!;
        public bool TipoPlanillaCobranzaRestringirCaja { get; set; }
    }
}
