using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ETipoCpInvent
    {
        public int Id { get; set; }
        public int Idsucursal { get; set; }
        public string IdreporteImpresion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string TipoCp { get; set; } = null!;
        public int Numero { get; set; }
        public string Serie { get; set; } = null!;
        public int LongitudNumero { get; set; }
        public int LongitudSerie { get; set; }
        public int MaximoNumeroItems { get; set; }
        public bool NumeracionAutomatica { get; set; }
        public int PeriodoAnulacion { get; set; }
        public int IdnumCpContable { get; set; }
        public bool NumeracionContable { get; set; }
        public bool RequiereMotivoAnulacion { get; set; }
        public bool GenerarNumeracionAlGuardar { get; set; }
        public bool PermitirFechasFuturas { get; set; }
        public bool PermitirFechasDiferidas { get; set; }
        public bool Imprimible { get; set; }
        public int TipoCpInventId { get; set; }
        public int TipoCpInventIdalmacen { get; set; }
        public bool TipoCpInventRestringirAlmacen { get; set; }
        public string? TipoCpInventTipoMovimiento { get; set; }
        public int IdtipoComprobantePago { get; set; }
        public bool EsComprobantePago { get; set; }
        public bool TipoCpInventRequiereTransportista { get; set; }
        public bool TipoCpInventImportacion { get; set; }
        public int Idimpuesto { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool LibroDiario { get; set; }
        public bool Tercero { get; set; }
        public bool Activo { get; set; }
        public bool ResumirEnLibroAuxiliar { get; set; }
        public bool PermitirFechasPasadas { get; set; }
        public bool PercepcionSinMontoMinimo { get; set; }
    }
}
