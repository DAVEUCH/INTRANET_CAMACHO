using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCpDma
    {
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? TipoComprobantePago { get; set; }
        public string? TipoCpAbreviacion { get; set; }
        public string? TipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public string? Responsable { get; set; }
        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string Expr1 { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public int IdvoucherContable { get; set; }
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public bool Revisado { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public string? CptoOperacionCodigo { get; set; }
        public string? CptoOperacion { get; set; }
        public int? Expr2 { get; set; }
        public int? IdtipoTercero { get; set; }
        public int? IdtipoDocIdentidad { get; set; }
        public string? Email { get; set; }
        public string? Web { get; set; }
        public string? Expr3 { get; set; }
        public string? DocIdentidad { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public bool? Descriptivo { get; set; }
        public bool? Activo { get; set; }
        public bool? AgenteRetencion { get; set; }
        public bool? AgentePercepcion { get; set; }
        public bool? Extranjero { get; set; }
        public string? CuentaBancaria { get; set; }
        public DateTime? FechaAniversario { get; set; }
        public DateTime? FechaCumpleaños { get; set; }
        public int? IddireccionPrincipal { get; set; }
        public bool? ExceptuadoDePercepcion { get; set; }
    }
}
