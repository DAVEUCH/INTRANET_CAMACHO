using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteDiferenciaCambioCaja
    {
        public int DocId { get; set; }
        public string DocCodigo { get; set; } = null!;
        public string DocTipoCp { get; set; } = null!;
        public string DocNumero { get; set; } = null!;
        public DateTime DocFechaEmision { get; set; }
        public string DocNumContable { get; set; } = null!;
        public int OperacionId { get; set; }
        public string OperacionCodigo { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public string? CuentaNumero { get; set; }
        public string? CuentaDescripcion { get; set; }
        public decimal CuentaCargo { get; set; }
        public decimal CuentaAbono { get; set; }
        public int CajaId { get; set; }
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public int PeriodoId { get; set; }
        public string PeriodoDescripcion { get; set; } = null!;
    }
}
